using DevExpress.Utils.Svg;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
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
using Vision_Pharmacy.Gui.SupplierGui;

namespace Vision_Pharmacy.Gui.PurchaseGui
{
    public partial class purchUserControl : DevExpress.XtraEditors.XtraForm
    {

        // Fields
        private readonly int id;
        private readonly PurchaseUserControl PurchaseUserControl;
        private readonly IDataHelper<Suppliers> _dataHelperSupplier;
        private IDataHelper<Purchase> _dataHelperPurchase;
        private IDataHelper<Medication> _dataHelperMedication;
        private IDataHelper<Unites> _dataHelperUnites;
        private IDataHelper<Strength> _dataHelperStrength;
        private IDataHelper<MedicineType> _dataHelperMedicineType;
        private IDataHelper<Category> _dataHelperCategory;
        private readonly LoadingUser loading;
        private Purchase Purchase;
        private Suppliers Supplier;
        private int RowId;
        private static SupplierUserControl _supplierUser;
        private List<int> IdList;
        private string searchItem;
        AllClasses AllClasses = new AllClasses();
        private int ResultAddOrEdit;
        private Label labelEmptyData;
        DataTable dtPurchases = new DataTable();

        // في أعلى الفورم:
        private List<Medication> _meds;
        private Dictionary<string, Medication> _medByBarcode;
        private BindingList<PurchaseItem> purchaseItems = new BindingList<PurchaseItem>();
        private RepositoryItemButtonEdit actionButtons;

        public purchUserControl(int Id, PurchaseUserControl PurchaseUserControl)
        {
            InitializeComponent();

            InitializeGrid();


            loading = LoadingUser.Instance();
            labelEmptyData = ComponentsObject.Instance().LabelEmptyData();
            _dataHelperPurchase = (IDataHelper<Purchase>)ContainerConfig.ObjectType("Purchase");
            _dataHelperSupplier = (IDataHelper<Suppliers>)ContainerConfig.ObjectType("Supplier");
            _dataHelperMedication = (IDataHelper<Medication>)ContainerConfig.ObjectType("Medication");
            LoadDataSupplier();
            AutoCompleteBarcode();
            // Set Property Instance
            id = Id;
            if (id > 0)
            {
                SetDataToFileds();
            }
            else
            {
                txtFactureNum.Text = GenerateFactureNum();
                txtFactureNum.HideSelection = true;
                txtSupplier.Focus();
            }

            //// إنشاء أعمدة الجدول
            //dtPurchases.Columns.Add("Barcode", typeof(string));
            //dtPurchases.Columns.Add("Name", typeof(string));
            //dtPurchases.Columns.Add("Quantity", typeof(int));
            //dtPurchases.Columns.Add("PurchasePrice", typeof(decimal));
            //dtPurchases.Columns.Add("Total", typeof(decimal));

            //DGListePurchase.DataSource = dtPurchases;


            // gridView1.OptionsView.ShowFooter = true;
            // gridView1.Columns["Total"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            // gridView1.Columns["Total"].SummaryItem.DisplayFormat = "المجموع: {0:N2}";

            // // السماح بالتحرير في عمود الكمية فقط
            // gridView1.OptionsBehavior.Editable = true;

            // foreach (DevExpress.XtraGrid.Columns.GridColumn col in gridView1.Columns)
            //     col.OptionsColumn.AllowEdit = false;

            // gridView1.Columns["Quantity"].OptionsColumn.AllowEdit = true;

            // 🔹 إنشاء محرر الأزرار (ButtonEdit)
            var buttonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            buttonEdit.Buttons.Clear();

            // زر النقصان
            buttonEdit.Buttons.Add(new DevExpress.XtraEditors.Controls.EditorButton(
            DevExpress.XtraEditors.Controls.ButtonPredefines.Minus));
            // زر الزيادة
            buttonEdit.Buttons.Add(new DevExpress.XtraEditors.Controls.EditorButton(
                DevExpress.XtraEditors.Controls.ButtonPredefines.Plus));

            // // إخفاء مربع النص داخل الخلية (اختياري)
            // buttonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;

            // // ربط الحدث عند الضغط على أحد الزرين
            buttonEdit.ButtonClick += ButtonEdit_ButtonClick;

            // // تطبيق المحرر على عمود الكمية
            // gridView1.Columns["Quantity"].ColumnEdit = buttonEdit;
            gridView1.CellValueChanged += gridView1_CellValueChanged;
            timer1.Interval = 1000; // كل ثانية
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void UpdateTotalAmount()
        {
            if (dtPurchases.Rows.Count == 0)
            {
                txtTotalAmount.Text = "0.00";
                return;
            }

            decimal total = dtPurchases.AsEnumerable()
                .Sum(r => r.Field<decimal>("Total"));

            txtTotalAmount.Text = total.ToString("N2"); // مثال: 1,250.00
        }



        // ✅ إنشاء الأعمدة وربطها بالـGrid
        private void InitializeGrid()
        {
            dtPurchases.Columns.Add("Barcode", typeof(string));
            dtPurchases.Columns.Add("Name", typeof(string));
            dtPurchases.Columns.Add("Quantity", typeof(int));
            dtPurchases.Columns.Add("PurchasePrice", typeof(decimal));
            dtPurchases.Columns.Add("Total", typeof(decimal));

            DGListePurchase.DataSource = dtPurchases;

            //gridView1.OptionsView.ShowFooter = true;
            //gridView1.Columns["Total"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            //gridView1.Columns["Total"].SummaryItem.DisplayFormat = "المجموع: {0:N2}";

            foreach (DevExpress.XtraGrid.Columns.GridColumn col in gridView1.Columns)
                col.OptionsColumn.AllowEdit = false;

            gridView1.Columns["Quantity"].OptionsColumn.AllowEdit = true;


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
        }

        // 🗑️ حذف صف عند الضغط على زر الحذف
        private void BtnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var view = gridView1;
            int rowHandle = view.FocusedRowHandle;
            if (rowHandle >= 0)
            {
                view.DeleteRow(rowHandle);
                txtTotalAmount.Text = "0.00";
            }
        }

        //**************************************
        public void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Quantity")
            {
                var row = gridView1.GetDataRow(e.RowHandle);
                if (row != null)
                {
                    int quantity = Convert.ToInt32(row["Quantity"]);
                    decimal price = Convert.ToDecimal(row["PurchasePrice"]);
                    row["Quantity"] = quantity;
                    row["Total"] = quantity * price;
                    UpdateTotalAmount();
                }
            }
        }

        private void ButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var view = gridView1;
            var row = view.GetFocusedDataRow();

            if (row == null) return;

            int quantity = Convert.ToInt32(row["Quantity"]);

            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                quantity++;
            }
            else if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Minus)
            {
                if (quantity > 1)
                    quantity--;
            }

            row["Quantity"] = quantity;

            // تحديث المجموع
            decimal price = Convert.ToDecimal(row["PurchasePrice"]);
            row["Quantity"] = quantity;
            row["Total"] = quantity * price;

            DGListePurchase.RefreshDataSource();
            UpdateTotalAmount();
        }

        private async void SetDataToFileds()
        {
            if (_dataHelperPurchase.IsDbConnect())
            {
                string IdList = await Task.Run(() => _dataHelperPurchase.Find(id).FactureNum);

                var purchases = await Task.Run(() => _dataHelperPurchase.GetData().Where(p => p.FactureNum == IdList).ToList());
                foreach (var item in purchases)
                {
                    txtFactureNum.Text = item.FactureNum.ToString();
                    txtSupplier.Text = item.SupplierName;
                    txtTypePaimt.Text = item.TypePaimt.ToString();
                    txtTotalAmount.Text = item.TotalAmount.ToString();
                    txtNotes.Text = item.Notes;
                    txtPurchaseDate.Text = item.FactureDate.ToString("yyyy-MM-dd");

                    var med = _dataHelperMedication.GetData().FirstOrDefault(m => m.Barcode == item.Barcode);
                    // عرف قائمة من PurchaseItem
                    purchaseItems = new BindingList<PurchaseItem>();

                    purchaseItems.Add(new PurchaseItem
                    {
                        Barcode = item.Barcode,
                        Name = med.Name,
                        GenericName = med.GenericName,
                        Quantity = item.Quantity,
                        PurchasePrice = item.PurchasePrice,
                        SalePrice = item.SalePrice,
                        TotalItem = item.TotalItem
                    });
                }


                // اربط القائمة مع GridControl
                DGListePurchase.DataSource = purchaseItems;

                // تحديث العرض
                gridView1.BestFitColumns();

                // اربط القائمة مع GridControl
                DGListePurchase.DataSource = purchaseItems;

                // تحديث العرض
                gridView1.BestFitColumns();
            }
            else
            {
                MessageCollection.ShowServerMessage();

            }
            Purchase = null;
        }

        // اريد جعل FactureNum تولد اوتوماتيكيا بشكل 01-2025 / 02-2025
        public string GenerateFactureNum()
        {
            int currentYear = DateTime.Now.Year;

            // نجيب آخر فاتورة لنفس السنة
            var lastFacture = _dataHelperPurchase.GetData()
                .Where(p => p.FactureDate.Year == currentYear)
                .OrderByDescending(p => p.Id)
                .FirstOrDefault();

            int nextNumber = 1;

            if (lastFacture != null && !string.IsNullOrEmpty(lastFacture.FactureNum))
            {
                string[] parts = lastFacture.FactureNum.Split('-');
                if (parts.Length == 2 && int.TryParse(parts[0], out int lastNumber))
                {
                    nextNumber = lastNumber + 1;
                }
            }

            return $"{nextNumber:D2}-{currentYear}";
        }

        // جلب بيانات الموردين
        public async void LoadDataSupplier()
        {
            loading.Show();
            // Check if connection is available
            if (_dataHelperSupplier.IsDbConnect())
            {
                txtSupplier.Items.Clear();
                foreach (var item in await Task.Run(() => _dataHelperSupplier.GetData()))
                {
                    txtSupplier.Items.Add(item.Name);
                }
            }
            else
            {
                MessageCollection.ShowServerMessage();
            }
            loading.Hide();
        }

        // تحميل الباركودات من الداتا 
        private async void AutoCompleteBarcode()
        {
            // حمّل الأدوية من الداتا (نفس أسلوبك مع Task.Run)
            _meds = await Task.Run(() => _dataHelperMedication.GetData());

            // جهّز قائمة الباركود
            var barcodes = _meds
                .Where(m => !string.IsNullOrWhiteSpace(m.Barcode))
                .Select(m => m.Barcode.Trim())
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .ToArray();

            // اضبط AutoComplete لـ Barcodetxt
            var ac = new AutoCompleteStringCollection();
            ac.AddRange(barcodes);
            Barcodetxt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Barcodetxt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            Barcodetxt.AutoCompleteCustomSource = ac;

            // قاموس للوصول السريع بالباركود
            _medByBarcode = _meds
                .Where(m => !string.IsNullOrWhiteSpace(m.Barcode))
                .GroupBy(m => m.Barcode.Trim(), StringComparer.OrdinalIgnoreCase)
                .ToDictionary(g => g.Key, g => g.First(), StringComparer.OrdinalIgnoreCase);
        }

        //اظافة وتحديث كمية المنتج في القائمة
        private void AddOrUpdateProduct(Medication med)
        {
            // التحقق هل المنتج موجود مسبقًا في DataTable (المصدر المرتبط بـ XtraGrid)
            DataRow existingRow = dtPurchases.AsEnumerable()
                .FirstOrDefault(r => r.Field<string>("Barcode") == med.Barcode);

            if (existingRow != null)
            {
                // ✅ المنتج موجود بالفعل → نزيد الكمية ونحدث المجموع
                int currentQty = existingRow.Field<int>("Quantity");
                decimal purchasePrice = existingRow.Field<decimal>("PurchasePrice");
                existingRow["Quantity"] = currentQty + 1;
                existingRow["Total"] = (currentQty + 1) * purchasePrice;
                UpdateTotalAmount();
            }
            else
            {
                // 🆕 المنتج غير موجود → نضيف سطرًا جديدًا
                DataRow newRow = dtPurchases.NewRow();
                newRow["Barcode"] = med.Barcode;
                newRow["Name"] = med.Name;
                newRow["Quantity"] = 1;
                newRow["PurchasePrice"] = med.PurchasePrice;
                newRow["Total"] = "100";
                dtPurchases.Rows.Add(newRow);
            }

            // تحديث واجهة XtraGrid
            // 🔗 ربط الجدول بالـ GridControl
            DGListePurchase.DataSource = dtPurchases;
            UpdateTotalAmount();
        }

        // التعامل مع حدث الضغط على زر الإدخال في حقل الباركود
        private async void Barcodetxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barcode = Barcodetxt.Text.Trim();
                string msg = "";
                if (string.IsNullOrEmpty(barcode))
                    return;

                Reinitialis:
                // جلب الدواء من قاعدة البيانات (باستخدام DataHelper أو أي Repository عندك)
                var medication = await Task.Run(() => _dataHelperMedication.GetData()
                                        .FirstOrDefault(m => m.Barcode == barcode));

                if (medication != null)
                {
                    //اظافة مباشرة الى القائمة
                    try
                    {
                        AddOrUpdateProduct(medication);
                        // تنظيف الحقول بعد الإضافة (اختياري)
                        Barcodetxt.Clear();
                        Barcodetxt.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("خطأ: " + ex.Message, "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (Properties.Settings.Default.ChangeLang == "Ar") msg = "❌ الباركود غير موجود في قاعدة البيانات\nهل تريد إنشاء منتج جديد؟";
                    else msg = "❌ The barcode does not exist in the database.\nDo you want to create a new product?";
                    var result = MessageBox.Show(msg, "تنبيه",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        if (string.IsNullOrWhiteSpace(txtSupplier.Text))
                        {
                            if (Properties.Settings.Default.ChangeLang == "Ar")
                            {
                                MessageBox.Show(
                                    "⚠️ يرجى اختيار المورد أولاً قبل إنشاء المنتج الجديد.",
                                    "تنبيه",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning
                                );
                            }
                            else
                            {
                                MessageBox.Show(
                                    "⚠️ Please select a supplier first before creating a new product.",
                                    "Warning",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning
                                );
                            }
                            return; // إيقاف العملية وعدم فتح النافذة &é"&"&  

                        }
                        else
                        {
                            MedicationAddForm MedicationAddForm = new MedicationAddForm(Barcodetxt.Text, txtSupplier.Text);
                            MedicationAddForm.ShowDialog();
                            Thread.Sleep(1000); // الانتظار قليلاً للتأكد من إضافة المنتج
                            AutoCompleteBarcode(); // إعادة تحميل الباركودات
                            goto Reinitialis; // إعادة التحقق من الباركود بعد إضافة المنتج
                        }

                    }
                }
                //if (!string.IsNullOrEmpty(Barcodetxt.Text))
                //{
                //    if (e.KeyCode == Keys.Enter)
                //    {

                //        e.SuppressKeyPress = true; // لمنع صوت الـ "ding"
                //        this.SelectNextControl((Control)sender, true, true, true, true);
                //    }
                //}
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            var view = gridView1;
            int rowHandle = view.FocusedRowHandle;
            if (rowHandle < 0) return;

            DataRow row = view.GetDataRow(rowHandle);
            if (row == null) return;

            int quantity = Convert.ToInt32(row["Quantity"]);
            decimal price = Convert.ToDecimal(row["PurchasePrice"]);

            // زيادة الكمية
            if (e.KeyCode == Keys.Add || (e.KeyCode == Keys.Oemplus && e.Shift))
            {
                quantity++;
                row["Quantity"] = quantity;
                row["Total"] = quantity * price;
                UpdateTotalAmount();
                e.Handled = true;
            }
            // نقصان الكمية
            else if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus)
            {
                if (quantity > 1)
                {
                    quantity--;
                    row["Quantity"] = quantity;
                    row["Total"] = quantity * price;
                    UpdateTotalAmount();
                }
                e.Handled = true;
            }
            // حذف الصف
            else if (e.KeyCode == Keys.Delete)
            {
                view.DeleteRow(rowHandle);
                e.Handled = true;
            }

            DGListePurchase.RefreshDataSource();
            UpdateTotalAmount();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTimerClock.Text = DateTime.Now.ToString("HH:mm:ss");
            // صيغة 24 ساعة - إذا تحب 12 ساعة مع AM/PM استعمل "hh:mm:ss tt"
            txtdate.Text = DateTime.Now.ToString("yyyy-MM-dd"); //"dddd, dd MMMM yyyy HH:mm:ss",
                                                                //new System.Globalization.CultureInfo("ar-DZ"));
                                                                // مثال: الاثنين، 18 أغسطس 2025 14:35:12
        }
    }
}