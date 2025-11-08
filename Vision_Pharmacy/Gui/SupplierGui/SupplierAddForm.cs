using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using Vision_Pharmacy.Code;
using Vision_Pharmacy.Core;
using Vision_Pharmacy.Data;
using Vision_Pharmacy.Gui.OtherGui;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Vision_Pharmacy.Gui.SupplierGui
{
    public partial class SupplierAddForm : DevExpress.XtraEditors.XtraForm
    {


        // تعريف المتغيرات للمنزلقات
        #region 
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        public AllClasses allClasses = new AllClasses();
        #endregion


        // Fileds
        private readonly int id;
        private readonly SupplierUserControl supplierUserControl;
        private readonly LoadingUser loading;
        private IDataHelper<Suppliers> _dataHelper;
        private Label labelEmptyData;
        private Suppliers suppliers;
        private int ResultAddOrEdit;
        AllClasses AllClasses = new AllClasses();

        // Constructores
        public SupplierAddForm(int Id, SupplierUserControl supplierUserControl)
        {
            InitializeComponent();
            AllClasses.RoundPanelCornersForm(this, 25); // 15 مثل bunifu

            // Set Property Instance
            id = Id;
            this.supplierUserControl = supplierUserControl;
            loading = LoadingUser.Instance();
            _dataHelper = (IDataHelper<Suppliers>)ContainerConfig.ObjectType("Supplier");
            // Set DataFileds for Edit void
            if (id > 0)
            {
                SetDataToFileds();
            }

            // Set Language
            if (Properties.Settings.Default.ChangeLang == "Ar")
            {
                ArabicLanguage();
            }
            else
            {
                EnglishLanguage();
            }
        }

        private void PicChange_Click(object sender, EventArgs e)
        {
            LoadImage();
        }
         

        // Events
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
            }
        }


        #region Methods

        private void LoadImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "اختر صورة المورد";
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
            ResultAddOrEdit = await Task.Run(() => _dataHelper.Add(suppliers));
            // check the result of proccess
            if (ResultAddOrEdit == 1) // Seccessfuly
            {
                // Show Notifiction
                MessageCollection.ShowAddNotification();
                ClearFileds();
                // Updat View
               if (supplierUserControl != null) supplierUserControl.LoadData();
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
            ResultAddOrEdit = await Task.Run(() => _dataHelper.Edit(suppliers));
            // check the result of proccess
            if (ResultAddOrEdit == 1) // Seccessfuly
            {
                // Show Notification
                MessageCollection.ShowEditNotification();
                // Updat View
                supplierUserControl.LoadData();
            }
            else // End with database error
            {
                MessageCollection.ShowServerMessage();
            }
        }

        private void ClearFileds()
        {
            txtSupplierName.Text = string.Empty; 
            txtSupplierAddress.Text = string.Empty;
            txtSupplierPhone.Text =string.Empty; 
            txtSupplierEmail.Text =string.Empty; 
            txtSupplierNotes.Text = string.Empty;

        }

        private async void SetDataToFileds()
        {
            if (_dataHelper.IsDbConnect())
            {
                suppliers = await Task.Run(() => _dataHelper.Find(id));
                txtSupplierName.Text = suppliers.Name;
                txtSupplierAddress.Text = suppliers.Address;
                txtSupplierPhone.Text = suppliers.Phone;
                txtSupplierEmail.Text = suppliers.Email;
                txtSupplierNotes.Text = suppliers.Notes;
                chkSupplierIsActive.IsOn = suppliers.IsActive;
                ImageHelper.ByteArrayToImage(suppliers.Image, PicChange);
            }
            else
            {
                MessageCollection.ShowServerMessage();

            }
            suppliers = null;
        }
        private void SetDataForAdd()
        {
            byte[] imageBytes = ImageHelper.ImageToByteArray(PicChange);
            suppliers = new Suppliers
            {
                Name = txtSupplierName.Text,
                Address = txtSupplierAddress.Text,
                Phone = txtSupplierPhone.Text,
                Email = txtSupplierEmail.Text,
                Notes = txtSupplierNotes.Text,
                Image = imageBytes,
                IsActive = chkSupplierIsActive.IsOn // Assuming new suppliers are active by default
            };


        }
        private void SetDataForEdit()
        {
            byte[] imageBytes = ImageHelper.ImageToByteArray(PicChange);
            suppliers = new Suppliers
            {
                Id = this.id,
                Name = txtSupplierName.Text,
                Address = txtSupplierAddress.Text,
                Phone = txtSupplierPhone.Text,
                Email = txtSupplierEmail.Text,
                Notes = txtSupplierNotes.Text,
                Image = imageBytes,
                IsActive = chkSupplierIsActive.IsOn // Assuming new suppliers are active by default
            };
        }
        private bool IsRequiredFiledEmpty()
        {
            if (txtSupplierName.Text == string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SupplierAddForm_MouseDown(object sender, MouseEventArgs e)
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

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

       


        public void ArabicLanguage()
            {
            // Change Language to Arabic
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            pnlContaint.RightToLeft = RightToLeft.Yes;

            // Change Texts
            lblTitle.Text = "ادارة الموردين >  اضافة مورد جديد";
            lblSupplierName.Text = "الاسم  *";
            lblSupplierAddress.Text = "العنوان";
            lblSupplierPhone.Text = "الهاتف";
            lblSupplierEmail.Text = "البريد الإلكتروني ";
            lblSupplierNotes.Text = "ملاحظات";
            lblSupplierIsActive.Text = "المورد نشط";
            btnSave.Text = "حفظ";
        }

        //Change Language to English
        public void EnglishLanguage()
        {
            this.RightToLeft = RightToLeft.No;
            this.RightToLeftLayout = false;
            pnlContaint.RightToLeft = RightToLeft.No;

            // Change Texts
            lblTitle.Text = "Supplier Management > Add a New Supplier";
            lblSupplierName.Text = "Supplier Name *";
            lblSupplierAddress.Text = "Supplier Address";
            lblSupplierPhone.Text = "Supplier Phone";
            lblSupplierEmail.Text = "Supplier Email";
            lblSupplierNotes.Text = "Notes";
            lblSupplierIsActive.Text = "Supplier Is Active";
            btnSave.Text = "Save";
        }

        }
}