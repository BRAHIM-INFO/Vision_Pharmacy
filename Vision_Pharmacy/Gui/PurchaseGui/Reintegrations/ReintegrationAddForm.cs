using DevExpress.Diagram.Core;
using DevExpress.Utils.Svg;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using DevExpress.XtraScheduler.Native;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vision_Pharmacy.Code;
using Vision_Pharmacy.Core;
using Vision_Pharmacy.Data;
using Vision_Pharmacy.Gui.MedicationGui;
using Vision_Pharmacy.Gui.OtherGui;
using Vision_Pharmacy.Gui.SaleGui;
using Vision_Pharmacy.Gui.SupplierGui;

namespace Vision_Pharmacy.Gui.PurchaseGui.Reintegrations
{
    public partial class ReintegrationAddForm : DevExpress.XtraEditors.XtraForm
    {
        private IDataHelper<Sale> _dataHelperSale;
        private IDataHelper<Medication> _dataHelperMedication;
        private readonly LoadingUser loading;
        private Sale Sale;

        // في أعلى الفورم:
        private List<Sale> _seles;
        private Dictionary<string, Sale> _medBySale;
        private BindingList<SaleItem> SaleItems = new BindingList<SaleItem>();
        private RepositoryItemButtonEdit actionButtons;
        DataTable dtPurchases = new DataTable();
        bool isUpdating = false;
        public ReintegrationAddForm()
        {
            InitializeComponent();
            InitializeGrid();
            loading = LoadingUser.Instance();
            _dataHelperSale = (IDataHelper<Sale>)ContainerConfig.ObjectType("Sale");
            _dataHelperMedication = (IDataHelper<Medication>)ContainerConfig.ObjectType("Medication");

            // توليد أرقام الفواتير
            GenerateFactureNum();

            // إعداد الإكمال التلقائي لرقم الفاتورة
            AutoCompleteFacture();

            // إعداد محرر الكمية المخصص
            SetupQuantityEditor();
        }

        // إعداد محرر الكمية المخصص
        private void SetupQuantityEditor()
        {
            // -----------------------------
            // 1. إنشاء محرر الأزرار للكمية
            // -----------------------------
            RepositoryItemButtonEdit btnQty = new RepositoryItemButtonEdit();
            btnQty.Buttons.Clear();

            btnQty.Buttons.Add(new EditorButton(ButtonPredefines.Plus));
            btnQty.Buttons.Add(new EditorButton(ButtonPredefines.Minus));

            btnQty.TextEditStyle = TextEditStyles.DisableTextEditor;

            // ربط الحدث
            btnQty.ButtonClick += BtnQty_ButtonClick;

            // ربطه بالعمود
            DGListeReturns.RepositoryItems.Add(btnQty);
            gridView1.Columns["Quantity"].ColumnEdit = btnQty;

            // -----------------------------
            // 2. تحديث Total عند تغيير الكمية
            // -----------------------------
            gridView1.CellValueChanged += GridView1_CellValueChanged;

        }

        // ✅ إنشاء الأعمدة وربطها بالـGrid
        private void InitializeGrid()
        {
            dtPurchases.Columns.Add("Barcode", typeof(string));
            dtPurchases.Columns.Add("Name", typeof(string));
            dtPurchases.Columns.Add("Quantity", typeof(int));
            dtPurchases.Columns.Add("SalePrice", typeof(decimal));
            dtPurchases.Columns.Add("Total", typeof(decimal));

            DGListeReturns.DataSource = dtPurchases;

            foreach (DevExpress.XtraGrid.Columns.GridColumn col in gridView1.Columns)
                col.OptionsColumn.AllowEdit = false;

            gridView1.Columns["Quantity"].OptionsColumn.AllowEdit = true;
            //gridView1.Columns["SalePrice"].OptionsColumn.AllowEdit = true;

            var view = gridView1;
            view.OptionsBehavior.Editable = true;
            view.OptionsView.ShowGroupPanel = false;
            view.Columns["Quantity"].OptionsColumn.AllowEdit = true;

            // زر حذف
            RepositoryItemButtonEdit btnDelete = new RepositoryItemButtonEdit();
            btnDelete.Buttons[0].Caption = "🗑️";
            btnDelete.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
            btnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            btnDelete.ButtonClick += BtnDelete_ButtonClick;

            var colDelete = view.Columns.AddVisible("Delete", "🗑️");
            colDelete.ColumnEdit = btnDelete;
            colDelete.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            colDelete.Width = 30;

            if (Properties.Settings.Default.ChangeLang == "Ar")
            {
                // تعيين مصدر البيانات للـ GridControl
                view.Columns["Barcode"].Caption = "باركود الدواء";
                view.Columns["Name"].Caption = "اسم الدواء";
                view.Columns["Quantity"].Caption = "الكمية ";
                view.Columns["SalePrice"].Caption = "سعر البيع";
                view.Columns["Total"].Caption = "المجموع";
            }
            else
            {
                // Set the data source for the GridControl
                view.Columns["Barcode"].Caption = "Barcode";
                view.Columns["Name"].Caption = "Name";
                view.Columns["Quantity"].Caption = "Quantity";
                view.Columns["SalePrice"].Caption = "Sale Price";
                view.Columns["Total"].Caption = "Total";
            }
        }

        // حدث عند الضغط على أزرار الزيادة والنقصان
        private void BtnQty_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var view = gridView1;
            int row = view.FocusedRowHandle;

            int qty = Convert.ToInt32(view.GetRowCellValue(row, "Quantity"));
            //int stock = Convert.ToInt32(view.GetRowCellValue(row, "Stock"));

            if (e.Button.Kind == ButtonPredefines.Plus)
                qty++;
            else if (e.Button.Kind == ButtonPredefines.Minus && qty > 1)
                qty--;

            // لا تتجاوز المخزون
            //if (qty > stock)
            //    qty = stock;

            view.SetRowCellValue(row, "Quantity", qty);

            //var view = gridView1;
            //var row = view.GetFocusedDataRow();
            //if (row == null) return;
            //int quantity = Convert.ToInt32(row["Quantity"]);
            //if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            //{
            //    quantity++;
            //}
            //else if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Minus)
            //{
            //    if (quantity > 1)
            //        quantity--;
            //}

            //row["Quantity"] = quantity;
            //// تحديث المجموع
            //decimal price = Convert.ToDecimal(row["SalePrice"]);
            //row["Quantity"] = quantity;
            //row["Total"] = quantity * price;
            //DGListeReturns.RefreshDataSource();
            //UpdateTotalAmount();
        }

        // حدث عند الضغط على أزرار الزيادة والنقصان 
        public void GridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (isUpdating) return;   // منع التكرار
            isUpdating = true;

            try
            {
                if (e.Column.FieldName == "Quantity")
                {
                    GridView view = (GridView)sender;

                    int qty = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "Quantity"));
                    //int stock = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "Stock"));
                    decimal price = Convert.ToDecimal(view.GetRowCellValue(e.RowHandle, "SalePrice"));

                    //if (qty > stock)
                    //{
                    //    qty = stock;
                    //}

                    // تحديث الكمية والقيمة الإجمالية
                    view.SetRowCellValue(e.RowHandle, "Quantity", qty);
                    view.SetRowCellValue(e.RowHandle, "Total", qty * price);
                }
            }
            finally
            {
                isUpdating = false;
            }
        }

        // اريد جعل FactureNum تولد اوتوماتيكيا بشكل 01-2025 / 02-2025
        public async void GenerateFactureNum()
        {
            loading.Show();
            // Check if connection is available
            if (_dataHelperSale.IsDbConnect())
            {
                txtFactureNum.Items.Clear();
                foreach (var item in await Task.Run(() => _dataHelperSale.GetData()))
                {
                    txtFactureNum.Items.Add(item.FactureNum);
                }
            }
            else
            {
                MessageCollection.ShowServerMessage();
            }
            loading.Hide();
        }

        // تحميل الفواتير من الداتا 
        private async void AutoCompleteFacture()
        {
            // حمّل الأدوية من الداتا (نفس أسلوبك مع Task.Run)
            _seles = await Task.Run(() => _dataHelperSale.GetData());

            // جهّز قائمة الباركود
            var seles = _seles
                .Where(m => !string.IsNullOrWhiteSpace(m.FactureNum))
                .Select(m => m.FactureNum.Trim())
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .ToArray();

            // اضبط AutoComplete لـ Barcodetxt
            var ac = new AutoCompleteStringCollection();
            ac.AddRange(seles);
            txtFactureNum.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtFactureNum.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtFactureNum.AutoCompleteCustomSource = ac;

            // قاموس للوصول السريع بالباركود
            _medBySale = _seles
                .Where(m => !string.IsNullOrWhiteSpace(m.FactureNum))
                .GroupBy(m => m.FactureNum.Trim(), StringComparer.OrdinalIgnoreCase)
                .ToDictionary(g => g.Key, g => g.First(), StringComparer.OrdinalIgnoreCase);
        }

        private void UpdateTotalAmount()
        {
            if (dtPurchases.Rows.Count == 0)
            {
                txtTotalAmount.Text = "0.00";
                return;
            }

            try
            {
                decimal totalSum = 0;
                // الوصول إلى DataSource للـ Grid (عادة DataTable)
                if (gridView1.DataSource is DataTable dt)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["Total"] != DBNull.Value)
                            totalSum += Convert.ToDecimal(row["Total"]);
                    }
                }

                // عرض النتيجة في TextBox
                txtTotalAmount.Text = totalSum.ToString("N2"); // بصيغة 2 أرقام عشرية
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في حساب المجموع: " + ex.Message);
            }


            decimal total = dtPurchases.AsEnumerable()
                .Sum(r => r.Field<decimal>("Total"));

            txtTotalAmount.Text = total.ToString("N2"); // مثال: 1,250.00
        }

        // 🗑️ حذف صف عند الضغط على زر الحذف
        private void BtnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var view = gridView1;
            int rowHandle = view.FocusedRowHandle;
            if (rowHandle >= 0)
            {
                view.DeleteRow(rowHandle);
                UpdateTotalAmount();
                //txtTotalAmount.Text = "0.00";
            }
        }

        private async void txtFactureNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                string FactureNum = txtFactureNum.Text.Trim();
                string msg = "";
                if (string.IsNullOrEmpty(FactureNum))
                    return;

                // جلب الدواء من قاعدة البيانات (باستخدام DataHelper أو أي Repository عندك)
                var _sale = await Task.Run(() => _dataHelperSale.GetData().Where(m => m.FactureNum == FactureNum));

                txtDoctors.Text = _sale.Where(m => !string.IsNullOrEmpty(m.DoctorName)).Select(m => m.DoctorName).FirstOrDefault() ?? "";
                txtNotes.Text = _sale.Where(m => !string.IsNullOrEmpty(m.Notes)).Select(m => m.Notes).FirstOrDefault() ?? "";
                txtTotalAmount.Text = _sale.FirstOrDefault()?.TotalAmount.ToString("N2") ?? "0.00";
                txtCustomer.Text = _sale.Where(m => !string.IsNullOrEmpty(m.CustomerName)).Select(m => m.CustomerName).FirstOrDefault() ?? "";
                txtdate.Text = _sale.FirstOrDefault().FactureDate.ToString();


                foreach (var itemSale in _sale)
                {
                    // 🆕 المنتج غير موجود → نضيف سطرًا جديدًا
                    DataRow newRow = dtPurchases.NewRow();
                    newRow["Barcode"] = itemSale.Barcode;
                    newRow["Name"] = _dataHelperMedication.GetData().FirstOrDefault(m => m.Barcode == itemSale.Barcode)?.Name;
                    newRow["Quantity"] = itemSale.Quantity;
                    newRow["SalePrice"] = itemSale.SalePrice;
                    newRow["Total"] = itemSale.TotalItem;
                    dtPurchases.Rows.Add(newRow);
                }

                // تحديث واجهة XtraGrid
                // 🔗 ربط الجدول بالـ GridControl
                DGListeReturns.DataSource = dtPurchases;
                //UpdateTotalAmount();

            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (isUpdating) return;

            GridView view = gridView1;
            int row = view.FocusedRowHandle;

            if (row < 0) return;  // لا يوجد سطر محدد

            // قراءة الكمية
            string barcodeItem = Convert.ToString(view.GetRowCellValue(row, "Barcode")) ?? "";
            int qty = Convert.ToInt32(view.GetRowCellValue(row, "Quantity"));
            int stock = _dataHelperMedication
               .GetData()
               .Where(x => x.Barcode == barcodeItem)
               .Select(m => m.QuantityInStock)
               .FirstOrDefault();

            decimal price = Convert.ToDecimal(view.GetRowCellValue(row, "SalePrice"));

            bool changed = false;

            // زيادة الكمية عند الضغط على "+"
            if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Oemplus)
            {
                qty++;
                if (qty < stock)
                {
                    //qty = stock;
                    changed = true;
                }
                else
                    changed = false;
            }

            // إنقاص الكمية عند الضغط على "-"
            if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus)
            {
                if (qty > 1)
                    qty--;

                changed = true;
            }

            if (changed)
            {
                try
                {
                    isUpdating = true;

                    view.SetRowCellValue(row, "Quantity", qty);
                    view.SetRowCellValue(row, "Total", qty * price);
                }
                finally
                {
                    isUpdating = false;
                }

                // منع إصدار صوت خطأ من لوحة المفاتيح
                e.Handled = true;
            }
            else
            {
                if (qty > stock)
                {
                    // رسالة المخزون غير كافي
                    MessageBox.Show($"المخزون لا يكفي. الكمية المتاحة: {stock}", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            UpdateTotalAmount();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}