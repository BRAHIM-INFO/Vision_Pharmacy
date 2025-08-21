using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vision_Pharmacy.Code;
using Vision_Pharmacy.Core;
using Vision_Pharmacy.Data;
using Vision_Pharmacy.Gui.EmployeeGui;
using Vision_Pharmacy.Gui.OtherGui;

namespace Vision_Pharmacy.Gui.MedicationGui
{
    public partial class MedicationAddForm : DevExpress.XtraEditors.XtraForm
    {
        // تعريف المتغيرات للمنزلقات
        #region 
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        #endregion

        // Fileds  
        private int RowId;
        private List<int> IdList = new List<int>();
        private readonly MedicationUserControl medicationUserControl;
        private readonly int id;
        private readonly LoadingUser loading;
        private IDataHelper<Medication> _dataHelper;
        private Medication Medication;
        private IDataHelper<Category> _dataHelperCategory;
        private IDataHelper<MedicineType> _dataHelperMedicineType;
        private IDataHelper<Strength> _dataHelperStrength;
        private IDataHelper<Unites> _dataHelperUnites;
        private IDataHelper<Suppliers> _dataHelperSupplier;
        private Category Category;
        private int ResultAddOrEdit;
        public MedicationAddForm(int Id, MedicationUserControl MedicationUserControl)
        {
            InitializeComponent();
            loading = LoadingUser.Instance();
            _dataHelperCategory = (IDataHelper<Category>)ContainerConfig.ObjectType("Category");
            _dataHelperMedicineType = (IDataHelper<MedicineType>)ContainerConfig.ObjectType("MedicineType");
            _dataHelperStrength = (IDataHelper<Strength>)ContainerConfig.ObjectType("Strength");
            _dataHelperUnites = (IDataHelper<Unites>)ContainerConfig.ObjectType("Unites");
            _dataHelperSupplier = (IDataHelper<Suppliers>)ContainerConfig.ObjectType("Supplier");
            LoadDataCategory();
            LoadDataSupplier();
            LoadDataMedicineType();
            LoadDataStrength();
            LoadDataUnites();

            // Set Property Instance
            id = Id;
            this.medicationUserControl = MedicationUserControl;
            loading = LoadingUser.Instance();
            _dataHelper = (IDataHelper<Medication>)ContainerConfig.ObjectType("Medication");
            // Set DataFileds for Edit void
            if (id > 0)
            {
                SetDataToFileds();
            }

        }

        public MedicationAddForm(string _Barcode,  string _Supplier)
        {
            InitializeComponent();
            loading = LoadingUser.Instance();
            _dataHelperCategory = (IDataHelper<Category>)ContainerConfig.ObjectType("Category");
            _dataHelperMedicineType = (IDataHelper<MedicineType>)ContainerConfig.ObjectType("MedicineType");
            _dataHelperStrength = (IDataHelper<Strength>)ContainerConfig.ObjectType("Strength");
            _dataHelperUnites = (IDataHelper<Unites>)ContainerConfig.ObjectType("Unites");
            _dataHelperSupplier = (IDataHelper<Suppliers>)ContainerConfig.ObjectType("Supplier");
            LoadDataCategory();
            LoadDataSupplier();
            LoadDataMedicineType();
            LoadDataStrength();
            LoadDataUnites();
            Barcodetxt.Text = _Barcode; 
            Suppliertxt.Text = _Supplier; 
            // Set Property Instance 
            Barcodetxt.ReadOnly = true;
            Suppliertxt.Enabled = false;
            

            // Set Property Instance 
            loading = LoadingUser.Instance();
            _dataHelper = (IDataHelper<Medication>)ContainerConfig.ObjectType("Medication");
            // Set DataFileds for Edit void
            if (id > 0)
            {
                SetDataToFileds();
            }

        }

        public async void LoadDataCategory()
        {
            loading.Show();
            // Check if connection is available
            if (_dataHelperCategory.IsDbConnect())
            {
                Categorytxt.Items.Clear();
                foreach (var item in await Task.Run(() => _dataHelperCategory.GetData()))
                {
                    Categorytxt.Items.Add(item.Name);
                }
            }
            else
            {
                MessageCollection.ShowServerMessage();
            }
            loading.Hide();
        }

        public async void LoadDataMedicineType()
        {
            loading.Show();
            // Check if connection is available
            if (_dataHelperMedicineType.IsDbConnect())
            {
                MedicineTypetxt.Items.Clear();
                foreach (var item in await Task.Run(() => _dataHelperMedicineType.GetData()))
                {
                    MedicineTypetxt.Items.Add(item.Name);
                }
            }
            else
            {
                MessageCollection.ShowServerMessage();
            }
            loading.Hide();
        }

        public async void LoadDataStrength()
        {
            loading.Show();
            // Check if connection is available
            if (_dataHelperStrength.IsDbConnect())
            {
                Strengthtxt.Items.Clear();
                foreach (var item in await Task.Run(() => _dataHelperStrength.GetData()))
                {
                    Strengthtxt.Items.Add(item.Name);
                }
            }
            else
            {
                MessageCollection.ShowServerMessage();
            }
            loading.Hide();
        }

        public async void LoadDataUnites()
        {
            loading.Show();
            // Check if connection is available
            if (_dataHelperStrength.IsDbConnect())
            {
                Unitetxt.Items.Clear();
                foreach (var item in await Task.Run(() => _dataHelperUnites.GetData()))
                {
                    Unitetxt.Items.Add(item.Name);
                }
            }
            else
            {
                MessageCollection.ShowServerMessage();
            }
            loading.Hide();
        }

        public async void LoadDataSupplier()
        {
            loading.Show();
            // Check if connection is available
            if (_dataHelperSupplier.IsDbConnect())
            {
                Suppliertxt.Items.Clear();
                foreach (var item in await Task.Run(() => _dataHelperSupplier.GetData()))
                {
                    Suppliertxt.Items.Add(item.Name);
                }
            }
            else
            {
                MessageCollection.ShowServerMessage();
            }
            loading.Hide();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            CategoryAddForm CategoryAddForm = new CategoryAddForm();
            CategoryAddForm.ShowDialog();
            LoadDataCategory();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MedicAddForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void btnForm_Click(object sender, EventArgs e)
        {
            MedicineTypeAddForm MedicineTypeAddForm = new MedicineTypeAddForm();
            MedicineTypeAddForm.ShowDialog();
            LoadDataMedicineType();
        }

        private void btnStrength_Click(object sender, EventArgs e)
        {
            StrengthAddForm StrengthAddForm = new StrengthAddForm();
            StrengthAddForm.ShowDialog();
            LoadDataStrength();
        }

        private void btnUnite_Click(object sender, EventArgs e)
        {
            UniteAddForm UniteAddForm = new UniteAddForm();
            UniteAddForm.ShowDialog();
            LoadDataUnites();
        }

        private void buttonSaveSup_Click(object sender, EventArgs e)
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
         
        #region Methods 
        private void LoadImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "اختر صورة الدواء";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Filter = "Image (.png,jpg)|*.png;*.jpg";
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                PicChange.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private async void AddData()
        {
            // Set Data
            SetDataForAdd();
            // Send data and get result
            ResultAddOrEdit = await Task.Run(() => _dataHelper.Add(Medication));
            // check the result of proccess
            if (ResultAddOrEdit == 1) // Seccessfuly
            {
                // Show Notifiction
                MessageCollection.ShowAddNotification();
                ClearFileds();
                // Updat View
                if(medicationUserControl != null) medicationUserControl.LoadData();
            }
            else // End with database error
            {
                MessageCollection.ShowServerMessage();
            }
        }
        private async void EditData()
        {
            // Set Data
            SetDataForEdit();
            ResultAddOrEdit = await Task.Run(() => _dataHelper.Edit(Medication));
            // check the result of proccess
            if (ResultAddOrEdit == 1) // Seccessfuly
            {
                // Show Notification
                MessageCollection.ShowEditNotification();
                // Updat View
                medicationUserControl.LoadData();
            }
            else // End with database error
            {
                MessageCollection.ShowServerMessage();
            }
        }

        private void ClearFileds()
        {
            Nametxt.PlaceholderText = "اسم الدواء";
            GenericNametxt.PlaceholderText = "الاسم العلمي";
            Manufacturertxt.PlaceholderText = "الشركة المصنعة";
            QuantityInStocktxt.PlaceholderText = "كمية المتوفرة";
            MinimumStockLeveltxt.PlaceholderText = "الحد الأدنى للتنبيه";
            BatchNumbertxt.PlaceholderText = "رقم الدفعة";
            LocationInStoretxt.PlaceholderText = "مكان التخزين";
            Barcodetxt.PlaceholderText = "باركود الدواء";
            Notestxt.PlaceholderText = "ملاحظات إضافية";
            MedicineTypetxt.Text = "";
            Strengthtxt.Text = "";
            Categorytxt.Text = "";
            Unitetxt.Text = "";
            SalePricetxt.Text = "0";
            PurchasePricetxt.Text = "0";
            Suppliertxt.Text = ""; 
            Discounttxt.PlaceholderText = "0";
            RequiresPrescriptiontxt.IsOn = true;
            IsActivetxt.IsOn = true;
        }

        private async void SetDataToFileds()
        {
            if (_dataHelper.IsDbConnect())
            {
                Medication = await Task.Run(() => _dataHelper.Find(id));

                Nametxt.Text = Medication.Name.ToString(); 
                GenericNametxt.Text = Medication.GenericName.ToString();
                Manufacturertxt.Text = Medication.Manufacturer.ToString();
                QuantityInStocktxt.Text = Medication.QuantityInStock.ToString();
                MinimumStockLeveltxt.Text = Medication.MinimumStockLevel.ToString();
                BatchNumbertxt.Text = Medication.BatchNumber.ToString();
                LocationInStoretxt.Text = Medication.LocationInStore.ToString();
                Barcodetxt.Text = Medication.Barcode.ToString();
                Notestxt.Text = Medication.Notes.ToString();
                MedicineTypetxt.Text = Medication.Form.ToString();
                Strengthtxt.Text = Medication.Strength.ToString();
                Categorytxt.Text = Medication.Category.ToString();
                Unitetxt.Text = Medication.Unite.ToString();
                SalePricetxt.Text = Medication.SalePrice.ToString();
                PurchasePricetxt.Text = Medication.PurchasePrice.ToString();
                 Discounttxt.Text = Medication.Discount.ToString();
                RequiresPrescriptiontxt.IsOn = Medication.RequiresPrescription;
                IsActivetxt.IsOn = Medication.IsActive;
                ExpiryDatetxt.Text = Medication.ExpiryDate.ToString("yyyy-MM-dd");
                DateAddedtxt.Text = Medication.DateAdded.ToString("yyyy-MM-dd");
                ImageHelper.ByteArrayToImage(Medication.Image, PicChange);
            }
            else
            {
                MessageCollection.ShowServerMessage();

            }
            Medication = null;
        }
        private void SetDataForAdd()
        {
            var supplier = _dataHelperSupplier.GetData().FirstOrDefault(s => s.Name == Suppliertxt.Text);
            if (supplier == null)
            {
                MessageBox.Show("المورد غير موجود في قاعدة البيانات. يرجى إضافته أولاً.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // تحويل الصورة إلى مصفوفة بايت
            byte[] imageBytes = ImageHelper.ImageToByteArray(PicChange);
            Medication = new Medication
            {
                Name = Nametxt.Text,
                GenericName = GenericNametxt.Text,
                Manufacturer = Manufacturertxt.Text,
                Form = MedicineTypetxt.Text,
                Strength = Strengthtxt.Text,
                Category = Categorytxt.Text,
                SalePrice = decimal.Parse(SalePricetxt.Text),
                PurchasePrice = decimal.Parse(PurchasePricetxt.Text),
                Unite = Unitetxt.Text,
                QuantityInStock = int.Parse(QuantityInStocktxt.Text),
                MinimumStockLevel = int.Parse(MinimumStockLeveltxt.Text),
                ExpiryDate = DateTime.Parse(ExpiryDatetxt.Text),
                BatchNumber = BatchNumbertxt.Text,
                //SupplierId = _dataHelperSupplier.GetData().FirstOrDefault(s => s.Name == Suppliertxt.Text)?.Id ?? 0, // Assuming you want to set the supplier ID
                //SupplierName = Suppliertxt.Text,
                RequiresPrescription = RequiresPrescriptiontxt.IsOn,
                DateAdded = DateTime.Parse(DateAddedtxt.Text),
                Notes = Notestxt.Text,
                LocationInStore = LocationInStoretxt.Text,
                Barcode = Barcodetxt.Text,
                Discount = double.Parse(Discounttxt.Text),
                Image = imageBytes,
                IsActive = IsActivetxt.IsOn // Assuming new Medication are active by default
            };


        }
        private void SetDataForEdit()
        {
            byte[] imageBytes = ImageHelper.ImageToByteArray(PicChange);
            Medication = new Medication
            {
                Id = this.id,
                Name = Nametxt.Text,
                GenericName = GenericNametxt.Text,
                Manufacturer = Manufacturertxt.Text,
                Form = MedicineTypetxt.Text,
                Strength = Strengthtxt.Text,
                Category = Categorytxt.Text,
                SalePrice = decimal.Parse(SalePricetxt.Text),
                PurchasePrice = decimal.Parse(PurchasePricetxt.Text),
                Unite = Unitetxt.Text,
                QuantityInStock = int.Parse(QuantityInStocktxt.Text),
                MinimumStockLevel = int.Parse(MinimumStockLeveltxt.Text),
                ExpiryDate = DateTime.Parse(ExpiryDatetxt.Text),
                BatchNumber = BatchNumbertxt.Text,
                //SupplierName = Suppliertxt.Text,
                //SupplierId = _dataHelperSupplier.GetData().FirstOrDefault(s => s.Name == Suppliertxt.Text)?.Id ?? 0, // Assuming you want to set the supplier ID
                DateAdded = DateTime.Parse(DateAddedtxt.Text),
                Notes = Notestxt.Text,
                LocationInStore = LocationInStoretxt.Text,
                Barcode = Barcodetxt.Text,
                Discount = double.Parse(Discounttxt.Text),
                Image = imageBytes,
                RequiresPrescription = RequiresPrescriptiontxt.IsOn,
                IsActive = IsActivetxt.IsOn // Assuming new Medication are active by default
            };
        }
        private bool IsRequiredFiledEmpty()
        {
            if (Nametxt.Text == string.Empty & Barcodetxt.Text == string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        private void PurchasePricetxt_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(PurchasePricetxt.Text, out decimal value))
            {
                PurchasePricetxt.Text = value.ToString("N2"); // 1,234.56
            }
            else
            {
                PurchasePricetxt.Text = "0.00";
            }
        }

        private void SalePricetxt_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(SalePricetxt.Text, out decimal value))
            {
                SalePricetxt.Text = value.ToString("N2"); // 1,234.56
            }
            else
            {
                SalePricetxt.Text = "0.00";
            }
        }

        private void PurchasePricetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // السماح بالأرقام فقط والفاصلة العشرية والـ backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // منع أكثر من فاصلة عشرية
            if ((e.KeyChar == '.' || e.KeyChar == ',') && (PurchasePricetxt.Text.Contains('.') || PurchasePricetxt.Text.Contains(',')))
            {
                e.Handled = true;
            }
        }

        private void SalePricetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // السماح بالأرقام فقط والفاصلة العشرية والـ backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // منع أكثر من فاصلة عشرية
            if ((e.KeyChar == '.' || e.KeyChar == ',') && (SalePricetxt.Text.Contains('.') || SalePricetxt.Text.Contains(',')))
            {
                e.Handled = true;
            }
        }

        private void Barcodetxt_KeyDown(object sender, KeyEventArgs e)
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

        private void Suppliertxt_KeyDown(object sender, KeyEventArgs e)
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

        private void Strengthtxt_KeyDown(object sender, KeyEventArgs e)
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

        private void Unitetxt_KeyDown(object sender, KeyEventArgs e)
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

        private void Discounttxt_KeyDown(object sender, KeyEventArgs e)
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

        private void DateAddedtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // لمنع صوت الـ "ding"
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void PicChange_Click(object sender, EventArgs e)
        {
            LoadImage();
        }
    }
}