using DevExpress.Utils.Svg;
using DevExpress.XtraBars.InternalItems;
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
using Vision_Pharmacy.Gui.SaleGui;
using Vision_Pharmacy.Gui.SupplierGui;

namespace Vision_Pharmacy.Gui.SaleGui
{
    public partial class SaleAddForm : DevExpress.XtraEditors.XtraForm
    {
        // Fields
        private readonly int id;
        private readonly SaleUserControl SaleUserControl;
        private readonly IDataHelper<Customer> _dataHelperCustomer;
        private IDataHelper<Sale> _dataHelperSale;
        private IDataHelper<Medication> _dataHelperMedication;
        private IDataHelper<Doctor> _dataHelperDoctor;
        private IDataHelper<Strength> _dataHelperStrength;
        private IDataHelper<MedicineType> _dataHelperMedicineType;
        private IDataHelper<Category> _dataHelperCategory;
        private readonly LoadingUser loading;
        private Sale Sale;
        private Customer Customer;
        private int RowId;
        private static SupplierUserControl _supplierUser;
        private List<int> IdList;
        private string searchItem;
        AllClasses AllClasses = new AllClasses();
        private int ResultAddOrEdit;
        private Label labelEmptyData;
        DataTable dtSales = new DataTable();

        // في أعلى الفورم:
        private List<Medication> _meds;
        private Dictionary<string, Medication> _medByBarcode;
        private BindingList<SaleItem> SaleItems = new BindingList<SaleItem>();
        private RepositoryItemButtonEdit actionButtons;
        DataTable dtPurchases = new DataTable();

        public SaleAddForm(int Id, SaleUserControl SaleUserControl)
        {
            InitializeComponent();
            InitializeGrid();
            loading = LoadingUser.Instance();
            labelEmptyData = ComponentsObject.Instance().LabelEmptyData();
            _dataHelperSale = (IDataHelper<Sale>)ContainerConfig.ObjectType("Sale");
            _dataHelperCustomer = (IDataHelper<Customer>)ContainerConfig.ObjectType("Customer");
            _dataHelperMedication = (IDataHelper<Medication>)ContainerConfig.ObjectType("Medication");
            _dataHelperDoctor = (IDataHelper<Doctor>)ContainerConfig.ObjectType("Doctor");
            LoadDataDoctors();
            LoadDataCustomer();
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
                txtCustomer.Focus();
            }
        }

        #region

        // جلب بيانات الفاتورة وتعيينها في الحقول
        private async void SetDataToFileds()
        {
            if (_dataHelperSale.IsDbConnect())
            {
                string IdList = await Task.Run(() => _dataHelperSale.Find(id).FactureNum);

                var Sales = await Task.Run(() => _dataHelperSale.GetData().Where(p => p.FactureNum == IdList).ToList());
                SaleItems = new BindingList<SaleItem>();
                foreach (var item in Sales)
                {
                    txtFactureNum.Text = item.FactureNum.ToString();
                    txtCustomer.Text = item.CustomerName;
                    txtTypePaimt.Text = item.TypePaimt.ToString();
                    txtTotalAmount.Text = item.TotalAmount.ToString();
                    txtNotes.Text = item.Notes;
                    txtSaleDate.Text = item.FactureDate.ToString("yyyy-MM-dd");

                    var med = _dataHelperMedication.GetData().FirstOrDefault(m => m.Barcode == item.Barcode);
                    // عرف قائمة من SaleItem


                    SaleItems.Add(new SaleItem
                    {
                        Barcode = item.Barcode,
                        Name = med.Name,
                        GenericName = med.GenericName,
                        Quantity = item.Quantity,
                        UnitPrice = item.SalePrice,
                        Discount = item.Discount
                    });
                }

                // تحديث العرض
                gridView1.BestFitColumns();

                // اربط القائمة مع GridControl
                DGListeSale.DataSource = SaleItems;

                // تحديث العرض
                gridView1.BestFitColumns();
            }
            else
            {
                MessageCollection.ShowServerMessage();

            }
            Sale = null;
        }

        // اريد جعل FactureNum تولد اوتوماتيكيا بشكل 01-2025 / 02-2025
        public string GenerateFactureNum()
        {
            int currentYear = DateTime.Now.Year;

            // نجيب آخر فاتورة لنفس السنة
            var lastFacture = _dataHelperSale.GetData()
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
        public async void LoadDataCustomer()
        {
            loading.Show();
            // Check if connection is available
            if (_dataHelperCustomer.IsDbConnect())
            {
                txtCustomer.Items.Clear();
                foreach (var item in await Task.Run(() => _dataHelperCustomer.GetData()))
                {
                    txtCustomer.Items.Add(item.FullName);
                }
            }
            else
            {
                MessageCollection.ShowServerMessage();
            }
            loading.Hide();
        }

        // جلب بيانات الأطباء
        public async void LoadDataDoctors()
        {
            loading.Show();
            // Check if connection is available
            if (_dataHelperDoctor.IsDbConnect())
            {
                txtDoctors.Items.Clear();
                foreach (var item in await Task.Run(() => _dataHelperDoctor.GetData()))
                {
                    txtDoctors.Items.Add(item.FullName);
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

        #endregion

        private void btnDoctrs_Click(object sender, EventArgs e)
        {
            Doctors.DoctorAddForm DoctorAddForm = new Doctors.DoctorAddForm(0, null);
            DoctorAddForm.ShowDialog();
        }

        private void btnForm_Click(object sender, EventArgs e)
        {
            CustomerGui.CustomerAddForm CustomerAddForm = new CustomerGui.CustomerAddForm(0, null);
            CustomerAddForm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTimerClock.Text = DateTime.Now.ToString("HH:mm:ss");
            // صيغة 24 ساعة - إذا تحب 12 ساعة مع AM/PM استعمل "hh:mm:ss tt"
            txtdate.Text = DateTime.Now.ToString("yyyy-MM-dd"); //"dddd, dd MMMM yyyy HH:mm:ss",
                                                                //new System.Globalization.CultureInfo("ar-DZ"));
                                                                // مثال: الاثنين، 18 أغسطس 2025 14:35:12
        }

        //private void UpdateTotalAmount()
        //{
        //    if (dtPurchases.Rows.Count == 0)
        //    {
        //        txtTotalAmount.Text = "0.00"; 
        //        return;
        //    }

        //    try
        //    {
        //        decimal totalSum = 0;
        //        // الوصول إلى DataSource للـ Grid (عادة DataTable)
        //        if (gridView1.DataSource is DataTable dt)
        //        {
        //            foreach (DataRow row in dt.Rows)
        //            {
        //                if (row["Total"] != DBNull.Value)
        //                    totalSum += Convert.ToDecimal(row["Total"]);
        //            }
        //        }

        //        // عرض النتيجة في TextBox
        //        txtTotalAmount.Text = totalSum.ToString("N2"); // بصيغة 2 أرقام عشرية
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("خطأ في حساب المجموع: " + ex.Message);
        //    }


        //    decimal total = dtPurchases.AsEnumerable()
        //        .Sum(r => r.Field<decimal>("Total"));

        //    txtTotalAmount.Text = total.ToString("N2"); // مثال: 1,250.00
        //}

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

        // ✅ إنشاء الأعمدة وربطها بالـGrid
        private void InitializeGrid()
        {
            dtPurchases.Columns.Add("Barcode", typeof(string));
            dtPurchases.Columns.Add("Name", typeof(string));
            dtPurchases.Columns.Add("Quantity", typeof(int));
            dtPurchases.Columns.Add("SalePrice", typeof(decimal));
            dtPurchases.Columns.Add("Total", typeof(decimal));

            DGListeSale.DataSource = dtPurchases;

            foreach (DevExpress.XtraGrid.Columns.GridColumn col in gridView1.Columns)
                col.OptionsColumn.AllowEdit = false;

            gridView1.Columns["Quantity"].OptionsColumn.AllowEdit = true;
            gridView1.Columns["SalePrice"].OptionsColumn.AllowEdit = true;

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
                view.Columns["Quantity"].Caption = "كمية المتوفرة";
                view.Columns["SalePrice"].Caption = "سعر البيع";
                view.Columns["Total"].Caption = "المجموع";
            }
            else
            {
                // Set the data source for the GridControl
                view.Columns["Barcode"].Caption = "Barcode";
                view.Columns["Name"].Caption = "Name";
                view.Columns["Quantity"].Caption = "Quantity Available";
                view.Columns["SalePrice"].Caption = "Sale Price";
                view.Columns["Total"].Caption = "Total";
            }
        }

        //اظافة وتحديث كمية المنتج في القائمة
        private void UpdateProduct(Medication med)
        {
            //// التحقق هل المنتج موجود مسبقًا في DataTable (المصدر المرتبط بـ XtraGrid)
            DataRow existingRow = dtPurchases.AsEnumerable()
                  .FirstOrDefault(r => r.Field<string>("Barcode") == med.Barcode);

            int QtyInstock = _dataHelperMedication
                           .GetData()
                           .Where(x => x.Barcode == med.Barcode)
                           .Select(m => m.QuantityInStock)
                           .FirstOrDefault();

            if (QtyInstock >= 1)
            {
                if (existingRow != null)
                {
                    // ✅ المنتج موجود بالفعل → نزيد الكمية ونحدث المجموع
                    int currentQty = existingRow.Field<int>("Quantity");
                    decimal SalePrice = existingRow.Field<decimal>("SalePrice");
                    existingRow["Quantity"] = currentQty + 1;
                    existingRow["Total"] = (currentQty + 1) * SalePrice;

                }
                else
                {

                    // 🆕 المنتج غير موجود → نضيف سطرًا جديدًا
                    DataRow newRow = dtPurchases.NewRow();
                    newRow["Barcode"] = med.Barcode;
                    newRow["Name"] = med.Name;
                    newRow["Quantity"] = 1;
                    newRow["SalePrice"] = med.SalePrice;
                    newRow["Total"] = med.PurchasePrice;
                    dtPurchases.Rows.Add(newRow);
                }
                // تحديث واجهة XtraGrid
                // 🔗 ربط الجدول بالـ GridControl
                DGListeSale.DataSource = dtPurchases;
                UpdateTotalAmount();
            }
            else
            {
                // رسالة المخزون غير كافي
                MessageBox.Show($"المخزون لا يكفي. الكمية المتاحة: {QtyInstock}", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

           
        }

        // تحديث المبلغ الإجمالي
        private void UpdateTotalAmount()
        {
            var dt = (DataTable)DGListeSale.DataSource;
            decimal total = dt.AsEnumerable().Sum(r => r.Field<decimal>("Total"));
            txtMontantHT.Text = $"{total:N2}";
            txtDescount.Text = "0";
            UpdateTotalAfterDiscount();
        }

        private void UpdateTotalAfterDiscount()
        {
            decimal montantHT = 0;
            decimal discount = 0;

            decimal.TryParse(txtMontantHT.Text, out montantHT);
            decimal.TryParse(txtDescount.Text, out discount);

            // 🔹 إذا كان الخصم نسبة مئوية (%)
            decimal discountValue = montantHT * (discount / 100);

            // 🔹 المجموع النهائي بعد الخصم
            decimal totalAmount = montantHT - discountValue;

            txtTotalAmount.Text = totalAmount.ToString("N2");
        }

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
                var medication = await Task.Run(() => _dataHelperMedication.GetData().AsEnumerable()
                                        .FirstOrDefault(m => m.Barcode == barcode));

               
                if (medication != null)
                {
                    //اظافة مباشرة الى القائمة
                    try
                    {
                        UpdateProduct(medication);
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
                        if (string.IsNullOrWhiteSpace(txtCustomer.Text))
                        {
                            if (Properties.Settings.Default.ChangeLang == "Ar")
                            {
                                MessageBox.Show(
                                    "⚠️ يرجى اختيار العميل أولاً قبل إنشاء المنتج الجديد.",
                                    "تنبيه",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning
                                );
                            }
                            else
                            {
                                MessageBox.Show(
                                    "⚠️ Please select a Customer first before creating a new product.",
                                    "Warning",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning
                                );
                            }
                            return; // إيقاف العملية وعدم فتح النافذة &é"&"&  

                        }
                        else
                        {
                            MedicationAddForm MedicationAddForm = new MedicationAddForm(Barcodetxt.Text, txtCustomer.Text);
                            MedicationAddForm.ShowDialog();
                            Thread.Sleep(1000); // الانتظار قليلاً للتأكد من إضافة المنتج
                            AutoCompleteBarcode(); // إعادة تحميل الباركودات
                            goto Reinitialis; // إعادة التحقق من الباركود بعد إضافة المنتج
                        }

                    }
                }
                if (!string.IsNullOrEmpty(Barcodetxt.Text))
                {
                    if (e.KeyCode == Keys.Enter)
                    {

                        e.SuppressKeyPress = true; // لمنع صوت الـ "ding"
                        this.SelectNextControl((Control)sender, true, true, true, true);
                    }
                }
            }
        }

        private async void SetDataForAdd()
        {
            Customer = _dataHelperCustomer.GetData().FirstOrDefault(s => s.FullName == txtCustomer.Text);
            if (Customer == null)
            {
                if (Properties.Settings.Default.ChangeLang == "Ar")
                    MessageBox.Show("العميل غير موجودة في قاعدة البيانات. يرجى إضافته أولاً.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show("The invoice does not exist in the database. Please add it first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // 1. إنشاء الفاتورة من TextBox
            Sale = new Sale();
            // 2. المرور على الأصناف في GridControl
            var view = DGListeSale.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            if (view != null)
            {
                for (int i = 0; i < view.RowCount; i++)
                {
                    if (!view.IsDataRow(i)) continue;

                    Sale.FactureNum = txtFactureNum.Text;
                    Sale.FactureDate = DateTime.Parse(txtSaleDate.Text);
                    Sale.TypePaimt = txtTypePaimt.Text;
                    Sale.TotalAmount = decimal.TryParse(txtTotalAmount.Text, out var total) ? total : 0;
                    Sale.Notes = txtNotes.Text;
                    Sale.CustomerName = txtCustomer.Text;
                    Sale.DoctorName = txtDoctors.Text;
                    Sale.CustomerId = Customer.Id;


                    Sale.Barcode = view.GetRowCellValue(i, "Barcode")?.ToString();
                    Sale.SalePrice = view.GetRowCellValue(i, "SalePrice") != null ?
                                            Convert.ToDecimal(view.GetRowCellValue(i, "SalePrice")) : 0;
                    Sale.Quantity = view.GetRowCellValue(i, "Quantity") != null ?
                                        Convert.ToInt32(view.GetRowCellValue(i, "Quantity")) : 0;

                    // 3. تحديث جدول Medication
                    // 1. جلب الدواء من قاعدة البيانات عبر الباركود
                    var med = _dataHelperMedication.GetData().FirstOrDefault(m => m.Barcode == Sale.Barcode);
                    if (med != null)
                    {
                        int oldQty = med.QuantityInStock;
                        decimal salePrice = med.SalePrice; // السعر الحالي للبيع

                        int soldQty = Sale.Quantity; // الكمية المباعة (من GridControl)

                        // التحقق من توفر الكمية
                        if (soldQty <= oldQty)
                        {
                            // طرح الكمية المباعة من المخزون
                            med.QuantityInStock = oldQty - soldQty;

                            // (اختياري) يمكنك تسجيل الربح أو الهامش إن أردت:
                            decimal purchasePrice = med.PurchasePrice;
                            decimal totalRevenue = soldQty * salePrice;
                            decimal totalCost = soldQty * purchasePrice;
                            decimal profit = totalRevenue - totalCost;

                            // يمكنك حفظ هذا الربح في جدول آخر مثلاً Reports أو SalesHistory
                            // أو فقط عرضه للمستخدم في الواجهة
                        }
                        else
                        {
                            MessageBox.Show($"الكمية غير كافية في المخزون! الكمية المتوفرة: {oldQty}",
                                            "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("الدواء غير موجود في قاعدة البيانات!",
                                        "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    _dataHelperMedication.Edit(med);
                    _dataHelperSale.Add(Sale);
                    Sale = new Sale();
                }
            }
        }

        private async void AddData()
        {
            // Set Data
            SetDataForAdd();
            // Send data and get result

            // check the result of proccess
            if (ResultAddOrEdit == 1) // Seccessfuly
            {
                // Show Notifiction
                MessageCollection.ShowAddNotification();

                // Updat View
                // if (SaleUserControl != null) SaleUserControl.LoadData();
            }
            else // End with database error
            {
                // MessageCollection.ShowServerMessage();
            }
        }
        private async void EditData()
        {
            if (_dataHelperSale.IsDbConnect())
            {
                if (IdList.Count > 0)
                {
                    for (int i = 0; i < IdList.Count; i++)
                    {
                        RowId = IdList[i];
                        _dataHelperSale.Delete(RowId);
                    }
                }
            }

            // Set Data
            SetDataForAdd();
            ResultAddOrEdit = await Task.Run(() => _dataHelperSale.Add(Sale));
            // check the result of proccess
            if (ResultAddOrEdit == 1) // Seccessfuly
            {
                // Show Notification
                MessageCollection.ShowEditNotification();
                // Updat View
                // if (SaleUserControl != null) SaleUserControl.LoadData();
            }
            else // End with database error
            {
                MessageCollection.ShowServerMessage();
            }
        }

        // التحقق من الحقول المطلوبة فارغة
        private bool IsRequiredFiledEmpty()
        {
            if (txtCustomer.Text == string.Empty & txtTypePaimt.Text == string.Empty & txtDoctors.Text == string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // check requirments of fileds
            if (IsRequiredFiledEmpty())
            {
                MessageCollection.ShowEmptyFields();
            }
            else
            {
                loading.Show();
                // Check if add or edit
                if (id == 0)
                {
                    // Add
                    AddData(); 
                }
                else
                {
                    // Edit
                    EditData();
                }
                loading.Hide();
                this.Close(); 
                
                // رسالة المخزون غير كافي
                MessageBox.Show($"تم تسجيل الفاتورة بنجاح رقم : {txtFactureNum.Text}", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtDescount_TextChanged(object sender, EventArgs e)
        {
            // نجرب تحويل النص إلى رقم
            if (decimal.TryParse(txtMontantHT.Text, out decimal montantHT) &&
                decimal.TryParse(txtDescount.Text, out decimal discount))
            {
                // نضمن أن التخفيض لا يكون أكبر من المبلغ الأصلي
                if (discount > montantHT)
                {
                    discount = montantHT;
                    txtDescount.Text = discount.ToString();
                    txtDescount.SelectionStart = txtDescount.Text.Length; // لتجنب إعادة كتابة النص
                }

                // حساب المبلغ بعد التخفيض
                decimal total = montantHT - discount;
                txtTotalAmount.Text = total.ToString("0.00"); // صيغة رقمية بمئتين
            }
            else
            {
                // إذا كان النص غير رقمي نجعل الإجمالي يساوي المبلغ الأصلي
                txtTotalAmount.Text = txtMontantHT.Text;
            }
        }
    }
}