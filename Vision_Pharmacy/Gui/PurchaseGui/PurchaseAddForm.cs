using DevExpress.Utils.Svg;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraScheduler.Native;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;
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
    public partial class PurchaseAddForm : DevExpress.XtraEditors.XtraForm
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
        private List<int> IdList = new List<int>();
        private string searchItem;
        AllClasses AllClasses = new AllClasses();
        private int ResultAddOrEdit;
        private Label labelEmptyData;
        // في أعلى الفورم:
        private List<Medication> _meds;
        private Dictionary<string, Medication> _medByBarcode;
        private BindingList<PurchaseItem> purchaseItems = new BindingList<PurchaseItem>();
        private RepositoryItemButtonEdit actionButtons;
        public PurchaseAddForm(int Id, PurchaseUserControl PurchaseUserControl)
        {
            InitializeComponent();
            AllClasses.RoundButtonCorners(btnAdd, 15);
            AllClasses.RoundButtonCorners(btnSave, 15);

            loading = LoadingUser.Instance();
            labelEmptyData = ComponentsObject.Instance().LabelEmptyData();
            _dataHelperPurchase = (IDataHelper<Purchase>)ContainerConfig.ObjectType("Purchase");
            _dataHelperSupplier = (IDataHelper<Suppliers>)ContainerConfig.ObjectType("Supplier");
            _dataHelperMedication = (IDataHelper<Medication>)ContainerConfig.ObjectType("Medication");
            _dataHelperUnites = (IDataHelper<Unites>)ContainerConfig.ObjectType("Unites");
            _dataHelperStrength = (IDataHelper<Strength>)ContainerConfig.ObjectType("Strength");
            _dataHelperMedicineType = (IDataHelper<MedicineType>)ContainerConfig.ObjectType("MedicineType");
            _dataHelperCategory = (IDataHelper<Category>)ContainerConfig.ObjectType("Category");
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

            if (Properties.Settings.Default.ChangeLang == "Ar")
            {
                 ApplyArabicResources();
            }
            else
            {
                 ApplyEnglishResources();
            }
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

                //var purch = _dataHelperPurchase.GetData().FirstOrDefault(m => m.FactureNum == Purchase.FactureNum);

                //var med = _dataHelperMedication.GetData().FirstOrDefault(m => m.Barcode == purch.Barcode);
                //// عرف قائمة من PurchaseItem
                //purchaseItems = new BindingList<PurchaseItem>();

                //var PurchItems = _dataHelperPurchase.GetData().Where(i => i.FactureNum == Purchase.FactureNum).ToList();

                //foreach(var item in PurchItems)
                //    {
                //        purchaseItems.Add(new PurchaseItem
                //        { 
                //            Barcode = item.Barcode,
                //            Name = med.Name,
                //            GenericName = med.GenericName,
                //            Quantity = item.Quantity,
                //            PurchasePrice = item.PurchasePrice,
                //            SalePrice = item.SalePrice,
                //            TotalItem = item.TotalItem
                //        });
                //} 

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

        private async void PurchaseAddForm_Load(object sender, EventArgs e)
        {
            loading.Show();
            if (_dataHelperPurchase.IsDbConnect())
            {

                //DGListePurchase.DataSource = await Task.Run(() => _dataHelperPurchase.GetData().GroupBy(p => p.FactureNum).Select(g => g.First()).ToList());
                DGListePurchase.DataSource = purchaseItems;
                // تحميل البيانات بشكل غير متزامن
                //SetDataGridViewColumns();
                var view = (DevExpress.XtraGrid.Views.Grid.GridView)DGListePurchase.MainView;
                view.OptionsView.ShowGroupPanel = false;
                if (view != null)
                {
                    //// عمود الأزرار
                    //GridColumn colAction = view.Columns.AddVisible("Action", "حذف المنتج");
                    //colAction.UnboundType = DevExpress.Data.UnboundColumnType.Object;
                    //colAction.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
                    //colAction.Width = 100; // عرض العمود

                    //// RepositoryItemButtonEdit واحد بثلاثة أزرار
                    //actionButtons = new RepositoryItemButtonEdit
                    //{
                    //    TextEditStyle = TextEditStyles.HideTextEditor
                    //}; 

                    //// أفرغ الأزرار الافتراضية
                    //actionButtons.Buttons.Clear();
                    ////زر حذف
                    //var btnDelete = new EditorButton(ButtonPredefines.Glyph);
                    //btnDelete.ImageOptions.SvgImage = SvgImage.FromStream(new MemoryStream(Properties.Resources.delete));
                    //btnDelete.Tag = "delete";                   // مفتاح تمييز
                    //actionButtons.Buttons.Add(btnDelete);

                    //DGListePurchase.RepositoryItems.Add(actionButtons);
                    //colAction.ColumnEdit = actionButtons;

                    //// حدث النقر
                    //actionButtons.ButtonClick += ActionButtons_ButtonClick;

                    //********************************************************
                    DGListePurchase.DataSource = purchaseItems;

                    // ربط القائمة بالـ GridControl
                    //var view = DGListePurchase.MainView as DevExpress.XtraGrid.Views.Grid.GridView;

                    if (Properties.Settings.Default.ChangeLang == "Ar")
                    {
                        // تعيين مصدر البيانات للـ GridControl
                        view.Columns["Barcode"].Caption = "باركود الدواء";
                        view.Columns["Name"].Caption = "اسم الدواء";
                        view.Columns["GenericName"].Caption = "اسم العلمي";
                        view.Columns["Quantity"].Caption = "كمية المتوفرة";
                        view.Columns["PurchasePrice"].Caption = "سعر الشراء";
                        view.Columns["SalePrice"].Caption = "سعر البيع";
                        view.Columns["TotalItem"].Caption = "المجموع";
                    }
                    else
                    {
                        // Set the data source for the GridControl
                        view.Columns["Barcode"].Caption = "Drug Barcode";
                        view.Columns["Name"].Caption = "Drug Name";
                        view.Columns["GenericName"].Caption = "Generic Name";
                        view.Columns["Quantity"].Caption = "Quantity Available";
                        view.Columns["PurchasePrice"].Caption = "Purchase Price";
                        view.Columns["SalePrice"].Caption = "Sale Price";
                        view.Columns["TotalItem"].Caption = "Total";
                    } 

                    // مثال: عمود السعر
                    view.Columns["PurchasePrice"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center; // محاذاة لليمين
                    view.Columns["PurchasePrice"].AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.None;
                    view.Columns["PurchasePrice"].AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
                    // مثال: عمود المجموع
                    view.Columns["TotalItem"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center; // محاذاة لليمين
                    view.Columns["TotalItem"].AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.None;
                    view.Columns["TotalItem"].AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
                    // مثال: عمود المجموع
                    view.Columns["SalePrice"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center; // محاذاة لليمين
                    view.Columns["SalePrice"].AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.None;
                    view.Columns["SalePrice"].AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
                }
                //********************************************************
                timer1.Interval = 1000; // كل ثانية
                timer1.Tick += timer1_Tick;
                timer1.Start();
            }
            else
            {
                MessageCollection.ShowServerMessage();
                return;
            }
            loading.Hide();
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

        // تحميل صورة الدواء
        private void LoadImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (Properties.Settings.Default.ChangeLang == "Ar") openFileDialog.Title = "اختر صورة الدواء"; 
            else openFileDialog.Title = "Select medicine image"; 
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Filter = "Image (.png,jpg)|*.png;*.jpg";
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                PicChange.Image = Image.FromFile(openFileDialog.FileName);
            }
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
                    // تعبئة الحقول
                    Nametxt.Text = medication.Name;
                    GenericNametxt.Text = medication.GenericName;
                    Manufacturertxt.Text = medication.Manufacturer;
                    MedicineTypetxt.Text = medication.Form; // الشكل الصيدلي
                    Categorytxt.Text = medication.Category;
                    Strengthtxt.Text = medication.Strength;
                    Unitetxt.Text = medication.Unite;
                    QuantityInStocktxt.Text = "0";
                    MinimumStockLeveltxt.Text = "0";
                    BatchNumbertxt.Text = medication.BatchNumber;
                    LocationInStoretxt.Text = medication.LocationInStore;
                    ExpiryDatetxt.Text = medication.ExpiryDate.ToString("yyyy-MM-dd");
                }
                else
                {
                    if (Properties.Settings.Default.ChangeLang == "Ar")   msg = "❌ الباركود غير موجود في قاعدة البيانات\nهل تريد إنشاء منتج جديد؟";
                    else   msg = "❌ The barcode does not exist in the database.\nDo you want to create a new product?"; 
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
                if (!string.IsNullOrEmpty(Nametxt.Text))
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        e.SuppressKeyPress = true; // لمنع صوت الـ "ding"
                        this.SelectNextControl((Control)sender, true, true, true, true);
                    }
                }
            }
        }

        private void PicChange_Click(object sender, EventArgs e)
        {
            LoadImage();
        }

        // التنقل بين الحقول Textbox
        #region
        private void txtSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // لمنع صوت الـ "ding"
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtPurchaseDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // لمنع صوت الـ "ding"
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtTypePaimt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // لمنع صوت الـ "ding"
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void Nametxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // لمنع صوت الـ "ding"
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void GenericNametxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // لمنع صوت الـ "ding"
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void Manufacturertxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // لمنع صوت الـ "ding"
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void MedicineTypetxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // لمنع صوت الـ "ding"
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void Categorytxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // لمنع صوت الـ "ding"
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void Strengthtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // لمنع صوت الـ "ding"
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void Unitetxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // لمنع صوت الـ "ding"
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void PurchasePricetxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // لمنع صوت الـ "ding"
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void SalePricetxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // لمنع صوت الـ "ding"
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void QuantityInStocktxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // لمنع صوت الـ "ding"
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void MinimumStockLeveltxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // لمنع صوت الـ "ding"
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void BatchNumbertxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // لمنع صوت الـ "ding"
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void LocationInStoretxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // لمنع صوت الـ "ding"
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ExpiryDatetxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // لمنع صوت الـ "ding"
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        #endregion

        public class PurchaseItem
        {
            public string Barcode { get; set; }
            public string Name { get; set; }
            public string GenericName { get; set; }
            public int Quantity { get; set; }
            public decimal PurchasePrice { get; set; }
            public decimal SalePrice { get; set; }
            public decimal TotalItem { get; set; }
        }

        /// <summary>
        ///  اجراءات الأزرار في عمود الإجراءات )عرض، تعديل، حذف(
        private void ActionButtons_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            var view = (DevExpress.XtraGrid.Views.Grid.GridView)DGListePurchase.MainView;
            var row = view.GetFocusedRow() as Purchase;
            if (row == null) return;

            // 1) التمييز بالـ Tag (الأفضل)
            var tag = e.Button.Tag as string;
            if (!string.IsNullOrEmpty(tag))
            {
                switch (tag)
                {
                    case "delete":
                        {
                            try
                            {
                                if (Properties.Settings.Default.ChangeLang == "Ar")
                                {
                                    if (MessageBox.Show($"هل تريد حذف المنتج رقم :  {row.FactureNum}؟", "تأكيد", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                    {
                                        view.DeleteRow(view.FocusedRowHandle);
                                        loading.Show();
                                    }
                                }
                                else
                                {
                                    if (MessageBox.Show($"Do you want to delete product number: {row.FactureNum}?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                    {
                                        view.DeleteRow(view.FocusedRowHandle);
                                        loading.Show();
                                    }
                                } 
                            }
                            catch
                            {
                                MessageCollection.ShowServerMessage();
                            }
                            loading.Hide();
                            return;
                        }
                }
            }

            // 2) فfallback بالفهرس داخل نفس الـ Repository (لو لأي سبب الـ Tag ماوصل)
            var repo = (RepositoryItemButtonEdit)sender;
            int idx = repo.Buttons.IndexOf(e.Button); // 0=view, 1=edit, 2=delete
            if (idx == 0)
            {
                if (Properties.Settings.Default.ChangeLang == "Ar")
                {
                    if (MessageBox.Show($"هل تريد حذف المنتج رقم :  {row.FactureNum}؟", "تأكيد", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        view.DeleteRow(view.FocusedRowHandle);
                }
                else
                {
                    if (MessageBox.Show($"Do you want to delete product number: {row.FactureNum}?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        view.DeleteRow(view.FocusedRowHandle);
                }
                   

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (Barcodetxt.Text == string.Empty || Nametxt.Text == string.Empty || GenericNametxt.Text == string.Empty || QuantityInStocktxt.Text == string.Empty || PurchasePricetxt.Text == string.Empty || SalePricetxt.Text == string.Empty)
                {
                    if (Properties.Settings.Default.ChangeLang == "Ar")
                    {
                        MessageBox.Show("الرجاء ملء جميع الحقول المطلوبة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Please fill in all required fields.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                   
                    return;
                }

                int.TryParse(QuantityInStocktxt.Text, out int quantity);
                decimal.TryParse(PurchasePricetxt.Text, out decimal price);
                decimal.TryParse(SalePricetxt.Text, out decimal priceSale);

                var item = new PurchaseItem
                {
                    Barcode = Barcodetxt.Text,
                    Name = Nametxt.Text,
                    GenericName = GenericNametxt.Text,
                    Quantity = quantity,
                    PurchasePrice = price,
                    SalePrice = priceSale,
                    TotalItem = quantity * price
                };

                purchaseItems.Add(item);

                // تنظيف الحقول بعد الإضافة (اختياري)
                Barcodetxt.Clear();
                Nametxt.Clear();
                GenericNametxt.Clear();
                QuantityInStocktxt.Clear();
                PurchasePricetxt.Clear();

                if (Properties.Settings.Default.ChangeLang == "Ar")
                {
                    // تفريغ الحقول بعد الإضافة
                    Barcodetxt.PlaceholderText = "باركود الدواء";
                    Nametxt.PlaceholderText = "اسم الدواء";
                    GenericNametxt.PlaceholderText = "الاسم العلمي";
                    Manufacturertxt.PlaceholderText = "الشركة المصنعة";
                    QuantityInStocktxt.PlaceholderText = "الكمية";
                    MinimumStockLeveltxt.PlaceholderText = "الحد الأدنى";
                    BatchNumbertxt.PlaceholderText = "رقم الدفعة";
                    LocationInStoretxt.PlaceholderText = "مكان التخزين";
                }
                else
                {
                    // Clear fields after adding
                    Barcodetxt.PlaceholderText = "Drug Barcode";
                    Nametxt.PlaceholderText = "Drug Name";
                    GenericNametxt.PlaceholderText = "Generic Name";
                    Manufacturertxt.PlaceholderText = "Manufacturer";
                    QuantityInStocktxt.PlaceholderText = "Quantity";
                    MinimumStockLeveltxt.PlaceholderText = "Minimum";
                    BatchNumbertxt.PlaceholderText = "Batch Number";
                    LocationInStoretxt.PlaceholderText = "Storage Location";
                }
                   
                Barcodetxt.Clear();
                Nametxt.Clear();
                GenericNametxt.Clear();
                Manufacturertxt.Clear();
                QuantityInStocktxt.Clear();
                MinimumStockLeveltxt.Clear();
                BatchNumbertxt.Clear();
                LocationInStoretxt.Clear();
                MedicineTypetxt.Text = string.Empty;
                Categorytxt.Text = string.Empty;
                Strengthtxt.Text = string.Empty;
                Unitetxt.Text = string.Empty;
                PurchasePricetxt.Text = "0";
                SalePricetxt.Text = "0";
                Barcodetxt.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ: " + ex.Message, "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateTotal()
        {
            decimal total = 0;

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                object cellValue = gridView1.GetRowCellValue(i, "TotalItem");
                // غيّر "Amount" إلى اسم العمود عندك (مثلاً "TotalPrice" أو "Price")

                if (cellValue != null && decimal.TryParse(cellValue.ToString(), out decimal value))
                {
                    total += value;
                }
            }

            txtTotalAmount.Text = total.ToString("N2"); // يعرض بمشكل مرتب مع 2 أرقام عشرية
        }

        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTimerClock.Text = DateTime.Now.ToString("HH:mm:ss");
            // صيغة 24 ساعة - إذا تحب 12 ساعة مع AM/PM استعمل "hh:mm:ss tt"
            txtdate.Text = DateTime.Now.ToString("yyyy-MM-dd"); //"dddd, dd MMMM yyyy HH:mm:ss",
                                                                //new System.Globalization.CultureInfo("ar-DZ"));
                                                                // مثال: الاثنين، 18 أغسطس 2025 14:35:12
        }

        private bool IsRequiredFiledEmpty()
        {
            if (txtFactureNum.Text == string.Empty & txtSupplier.Text == string.Empty & txtPurchaseDate.Text == string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private async void SetDataForAdd()
        {
            Supplier = _dataHelperSupplier.GetData().FirstOrDefault(s => s.Name == txtSupplier.Text);
            if (Supplier == null)
            {
                if (Properties.Settings.Default.ChangeLang == "Ar")
                    MessageBox.Show("الفاتورة غير موجودة في قاعدة البيانات. يرجى إضافتها أولاً.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show("The invoice does not exist in the database. Please add it first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // 1. إنشاء الفاتورة من TextBox
            Purchase = new Purchase();
            // 2. المرور على الأصناف في GridControl
            var view = DGListePurchase.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            if (view != null)
            {
                for (int i = 0; i < view.RowCount; i++)
                {
                    if (!view.IsDataRow(i)) continue;

                    Purchase.FactureNum = txtFactureNum.Text;
                    Purchase.FactureDate = DateTime.Parse(txtPurchaseDate.Text);
                    Purchase.TypePaimt = txtTypePaimt.Text;
                    Purchase.TotalAmount = decimal.TryParse(txtTotalAmount.Text, out var total) ? total : 0;
                    Purchase.Notes = txtNotes.Text;
                    Purchase.SupplierName = txtSupplier.Text;
                    Purchase.SupplierId = Supplier.Id;
                    Purchase.Barcode = view.GetRowCellValue(i, "Barcode")?.ToString();
                    Purchase.PurchasePrice = view.GetRowCellValue(i, "PurchasePrice") != null ?
                                             Convert.ToDecimal(view.GetRowCellValue(i, "PurchasePrice")) : 0;
                    Purchase.SalePrice = view.GetRowCellValue(i, "SalePrice") != null ?
                                            Convert.ToDecimal(view.GetRowCellValue(i, "SalePrice")) : 0;
                    Purchase.Quantity = view.GetRowCellValue(i, "Quantity") != null ?
                                        Convert.ToInt32(view.GetRowCellValue(i, "Quantity")) : 0;

                    // 3. تحديث جدول Medication
                    var med = _dataHelperMedication.GetData().FirstOrDefault(m => m.Barcode == Purchase.Barcode);
                    if (med != null)
                    {

                        int oldQty = med.QuantityInStock;
                        decimal oldPurchasePrice = med.PurchasePrice;
                        decimal oldSalePrice = med.SalePrice;

                        int newQty = Purchase.Quantity;                     // من GridControl
                        decimal newPurchasePrice = Purchase.PurchasePrice;  // من GridControl
                        decimal newSalePrice = Purchase.SalePrice;          // من GridControl

                        int totalQty = oldQty + newQty;

                        if (totalQty > 0)
                        {
                            // حساب متوسط سعر الشراء
                            decimal totalPurchaseCost = (oldQty * oldPurchasePrice) + (newQty * newPurchasePrice);
                            med.PurchasePrice = totalPurchaseCost / totalQty;

                            // حساب متوسط سعر البيع
                            decimal totalSaleCost = (oldQty * oldSalePrice) + (newQty * newSalePrice);
                            med.SalePrice = totalSaleCost / totalQty;
                        }
                        else
                        {
                            // إذا مافيش كمية قديمة (منتج جديد)
                            med.PurchasePrice = newPurchasePrice;
                            med.SalePrice = newSalePrice;
                        }
                        //// تحديث الأسعار والكمية
                        med.Id = med.Id;
                        // تحديث المخزون
                        med.QuantityInStock += newQty;
                    }
                    _dataHelperMedication.Edit(med);
                    _dataHelperPurchase.Add(Purchase);
                    Purchase = new Purchase();
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
                if (PurchaseUserControl != null) PurchaseUserControl.LoadData();
            }
            else // End with database error
            {
                MessageCollection.ShowServerMessage();
            }
        }
        private async void EditData()
        {
            if (_dataHelperPurchase.IsDbConnect())
            {
                if (IdList.Count > 0)
                {
                    for (int i = 0; i < IdList.Count; i++)
                    {
                        RowId = IdList[i];
                        _dataHelperPurchase.Delete(RowId);
                    }
                }
            }

            // Set Data
            SetDataForAdd();
            ResultAddOrEdit = await Task.Run(() => _dataHelperPurchase.Add(Purchase));
            // check the result of proccess
            if (ResultAddOrEdit == 1) // Seccessfuly
            {
                // Show Notification
                MessageCollection.ShowEditNotification();
                // Updat View
                PurchaseUserControl.LoadData();
            }
            else // End with database error
            {
                MessageCollection.ShowServerMessage();
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
            }
        }

        // // تغيير اللغة إلى العربية
        private void ApplyArabicResources()
        {
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;

            // General Settings
            lblSupForm.Text = "ادارة المشتريات >  اضافة فاتورة جديدة";
            label1.Text = "رقم الفاتورة";
            label3.Text = "المورد";
            lblEmpEmail.Text = "تاريخ الشراء";
            label4.Text = "طريقة الدفع";
            label16.Text = "باركود الدواء";
            lblSupplierName.Text = "اسم الدواء";
            lblSupplierAddress.Text = "الاسم العلمي";
            lblSupplierPhone.Text = "الشركة المصنعة";


            Barcodetxt.PlaceholderText = "باركود الدواء";
            Nametxt.PlaceholderText = "اسم الدواء";
            GenericNametxt.PlaceholderText = "الاسم العلمي";
            Manufacturertxt.PlaceholderText = "الشركة المصنعة";

            label9.Text = "الشكل الصيدلي";
            label8.Text = "التصنيف";
            lblSupplierEmail.Text = "التركيز";
            label7.Text = "الوحدة";
            label10.Text = "سعر الشراء";
            lblSupplierNotes.Text = "سعر البيع";

            label11.Text = "الكمية";
            label12.Text = "الحد الأدنى";  
            label13.Text = "رقم الدفعة";
            label15.Text = "مكان التخزين";

            QuantityInStocktxt.Text = "الكمية";
            MinimumStockLeveltxt.Text = "الحد الأدنى";
            BatchNumbertxt.Text = "رقم الدفعة";
            LocationInStoretxt.Text = "مكان التخزين";

            label14.Text = "انتهاء الصلاحية";
            label17.Text = "هل يتطلب وصفة طبية؟";
            btnAdd.Text = "اضافة";
            label6.Text = "السعر الفاتورة  الاجمالي";
            btnSave.Text = "حفظ"; 
            label19.Text = "ملاحظات";
            txtNotes.PlaceholderText = " تسجيل ملاحظات ";
            // Form Settings
            this.Text = "اضافة فاتورة جديدة";
        }

        // // تغيير اللغة إلى العربية
        private void ApplyEnglishResources()
        {
            this.RightToLeft = RightToLeft.No;
            this.RightToLeftLayout = false;

            // General Settings
            lblSupForm.Text = "Purchase Management > Add New Invoice";
            label1.Text = "Invoice Number";
            label3.Text = "Supplier";
            lblEmpEmail.Text = "Purchase Date";
            label4.Text = "Payment Method";
            label16.Text = "Medication Barcode";
            lblSupplierName.Text = "Medication Name";
            lblSupplierAddress.Text = "Generic Name";
            lblSupplierPhone.Text = "Manufacturer";

            Barcodetxt.PlaceholderText = "Medication Barcode";
            Nametxt.PlaceholderText = "Medication Name";
            GenericNametxt.PlaceholderText = "Generic Name";
            Manufacturertxt.PlaceholderText = "Manufacturer";

            label9.Text = "Dosage Form";
            label8.Text = "Classification";
            lblSupplierEmail.Text = "Concentration";
            label7.Text = "Unit";
            label10.Text = "Purchase Price";
            lblSupplierNotes.Text = "Selling Price";

            label11.Text = "Quantity";
            label12.Text = "Minimum";
            label13.Text = "Batch Number";
            label15.Text = "Store Location";

            QuantityInStocktxt.Text = "Quantity";
            MinimumStockLeveltxt.Text = "Minimum";
            BatchNumbertxt.Text = "Batch Number";
            LocationInStoretxt.Text = "Store Location";

            label14.Text = "Expiration";
            label17.Text = "Does a prescription require?";
            btnAdd.Text = "Add";
            label6.Text = "Total Invoice Price";
            btnSave.Text = "Save";
            label19.Text = "Notes";
            txtNotes.PlaceholderText = "Record Notes";
            // Form Settings
            this.Text = "Add a new invoice";
        }
    }
}