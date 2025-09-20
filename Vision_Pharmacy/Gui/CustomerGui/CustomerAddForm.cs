using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vision_Pharmacy.Code;
using Vision_Pharmacy.Core;
using Vision_Pharmacy.Data;
using Vision_Pharmacy.Gui.OtherGui;
using Vision_Pharmacy.Gui.CustomerGui;

namespace Vision_Pharmacy.Gui.CustomerGui
{
    public partial class CustomerAddForm : DevExpress.XtraEditors.XtraForm
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
        private readonly CustomerUserControl CustomerUserControl;
        private readonly LoadingUser loading;
        private IDataHelper<Customer> _dataHelper;
        private Customer Customer;
        private int ResultAddOrEdit;
        AllClasses AllClasses = new AllClasses();

        // Constructores
        public CustomerAddForm(int Id, CustomerUserControl CustomerUserControl)
        {
            InitializeComponent();
            AllClasses.RoundPanelCornersForm(this, 25); // 15 مثل bunifu

            // Set Property Instance
            id = Id;
            this.CustomerUserControl = CustomerUserControl;
            loading = LoadingUser.Instance();
            _dataHelper = (IDataHelper<Customer>)ContainerConfig.ObjectType("Customer");
            // Set DataFileds for Edit void
            if (id > 0)
            {
                SetDataToFileds();
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
            if (Properties.Settings.Default.ChangeLang == "Ar")  openFileDialog.Title = "اختر صورة المورد";
            else  openFileDialog.Title = "Select Supplier Image";
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
            ResultAddOrEdit = await Task.Run(() => _dataHelper.Add(Customer));
            // check the result of proccess
            if (ResultAddOrEdit == 1) // Seccessfuly
            {
                // Show Notifiction
                MessageCollection.ShowAddNotification();
                ClearFileds();
                // Updat View
                if (CustomerUserControl != null)  CustomerUserControl.LoadData();
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
            ResultAddOrEdit = await Task.Run(() => _dataHelper.Edit(Customer));
            // check the result of proccess
            if (ResultAddOrEdit == 1) // Seccessfuly
            {
                // Show Notification
                MessageCollection.ShowEditNotification();
                // Updat View
                CustomerUserControl.LoadData();
            }
            else // End with database error
            {
                MessageCollection.ShowServerMessage();
            }
        }

        private void ClearFileds()
        {
            txtCustomerName.Text = string.Empty; 
            txtCustomerAddress.Text = string.Empty; 
            txtCustomerPhone.Text =   string.Empty; 
            txtCustomerEmail.Text =   string.Empty; 
            txtCustomerNotes.Text = string.Empty;

        }

        private async void SetDataToFileds()
        {
            if (_dataHelper.IsDbConnect())
            {
                Customer = await Task.Run(() => _dataHelper.Find(id));
                txtCustomerName.Text = Customer.FullName;
                txtCustomerAddress.Text = Customer.Address;
                txtCustomerPhone.Text = Customer.Phone;
                txtCustomerEmail.Text = Customer.Email;
                txtCustomerNotes.Text = Customer.Notes; 
                //ImageHelper.ByteArrayToImage(Customer.Image, PicChange);
            }
            else
            {
                MessageCollection.ShowServerMessage();

            }
            Customer = null;
        }
        private void SetDataForAdd()
        {
            byte[] imageBytes = ImageHelper.ImageToByteArray(PicChange);
            Customer = new Customer
            {
                FullName = txtCustomerName.Text,
                Address = txtCustomerAddress.Text,
                Phone = txtCustomerPhone.Text,
                Email = txtCustomerEmail.Text,
                Notes = txtCustomerNotes.Text 
            };


        }
        private void SetDataForEdit()
        {
            byte[] imageBytes = ImageHelper.ImageToByteArray(PicChange);
            Customer = new Customer
            {
                Id = this.id,
                FullName = txtCustomerName.Text,
                Address = txtCustomerAddress.Text,
                Phone = txtCustomerPhone.Text,
                Email = txtCustomerEmail.Text,
                Notes = txtCustomerNotes.Text 
            };
        }
        private bool IsRequiredFiledEmpty()
        {
            if (txtCustomerName.Text == string.Empty)
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

        private void CustomerAddForm_MouseDown(object sender, MouseEventArgs e)
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

        //ملف ترجمة الى اللغة العربية
        private void ApplyArabicResources()
        {
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;

            lbltitle.Text = "إضافة عميل جديد"; 
            lblCustomerName.Text = "اسم العميل *";
            lblCustomerPhone.Text = "رقم الهاتف";
            lblCustomerEmail.Text = "البريد الإلكتروني";
            lblCustomerAddress.Text = "العنوان";
            lblCustomerNotes.Text = "ملاحظات";

            txtCustomerName.PlaceholderText = "اسم العميل *";
            txtCustomerPhone.PlaceholderText = "رقم الهاتف";
            txtCustomerEmail.PlaceholderText = "البريد الإلكتروني";
            txtCustomerAddress.PlaceholderText = "العنوان";
            txtCustomerNotes.PlaceholderText = "ملاحظات"; 

            buttonSaveSup.Text = "حفظ البيانات";
        }

        //ملف ترجمة الى اللغة الانجليزية
        private void ApplyEnglishResources()
        {
            this.RightToLeft = RightToLeft.No;
            this.RightToLeftLayout = false;

            lbltitle.Text = "Add New Customer";
            lblCustomerName.Text = "Customer Name *";
            lblCustomerPhone.Text = "Phone";
            lblCustomerEmail.Text = "Email";
            lblCustomerAddress.Text = "Address";
            lblCustomerNotes.Text = "Notes";

            txtCustomerName.PlaceholderText = "Customer Name *";
            txtCustomerPhone.PlaceholderText = "Phone Number";
            txtCustomerEmail.PlaceholderText = "Email";
            txtCustomerAddress.PlaceholderText = "Address";
            txtCustomerNotes.PlaceholderText = "Notes";

            buttonSaveSup.Text = "Save Data";
        }

    }
}