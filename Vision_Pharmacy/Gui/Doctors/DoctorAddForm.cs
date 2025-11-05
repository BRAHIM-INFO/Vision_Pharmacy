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

namespace Vision_Pharmacy.Gui.Doctors
{
    public partial class DoctorAddForm : DevExpress.XtraEditors.XtraForm
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
        private readonly DoctorUserControl DoctorUserControl;
        private readonly LoadingUser loading;
        private IDataHelper<Doctor> _dataHelper;
        private Doctor Doctor;
        private int ResultAddOrEdit;
        AllClasses AllClasses = new AllClasses();

        public DoctorAddForm(int Id, DoctorUserControl DoctorUserControl)
        {
            InitializeComponent();
            AllClasses.RoundPanelCornersForm(this, 25); // 15 مثل bunifu

            // Set Property Instance
            id = Id;
            this.DoctorUserControl = DoctorUserControl;
            loading = LoadingUser.Instance();
            _dataHelper = (IDataHelper<Doctor>)ContainerConfig.ObjectType("Doctor");
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

        //ملف ترجمة الى اللغة العربية
        private void ApplyArabicResources()
        {
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;

            lbltitle.Text = "إضافة طبيب جديد";
            lblDoctorName.Text = "اسم الطبيب *";
            lblDoctorPhone.Text = "رقم الهاتف";
            lblDoctorEmail.Text = "البريد الإلكتروني";
            lblDoctorAddress.Text = "العنوان";
            lblDoctorNotes.Text = "ملاحظات";

            txtDoctorName.PlaceholderText = "اسم الطبيب *";
            txtDoctorPhone.PlaceholderText = "رقم الهاتف";
            txtDoctorEmail.PlaceholderText = "البريد الإلكتروني";
            txtDoctorAddress.PlaceholderText = "العنوان";
            txtDoctorSpecialit.PlaceholderText = "تخصص";

            buttonSaveSup.Text = "حفظ البيانات";
        }

        //ملف ترجمة الى اللغة الانجليزية
        private void ApplyEnglishResources()
        {
            this.RightToLeft = RightToLeft.No;
            this.RightToLeftLayout = false;

            lbltitle.Text = "Add New Doctor";
            lblDoctorName.Text = "Doctor Name *";
            lblDoctorPhone.Text = "Phone";
            lblDoctorEmail.Text = "Email";
            lblDoctorAddress.Text = "Address";
            lblDoctorNotes.Text = "Notes";

            txtDoctorName.PlaceholderText = "Doctor Name *";
            txtDoctorPhone.PlaceholderText = "Phone Number";
            txtDoctorEmail.PlaceholderText = "Email";
            txtDoctorAddress.PlaceholderText = "Address";
            txtDoctorSpecialit.PlaceholderText = "Specialit";

            buttonSaveSup.Text = "Save Data";
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
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region Methods 

        private async void AddData()
        {
            // Set Data
            SetDataForAdd();
            // Send data and get result
            ResultAddOrEdit = await Task.Run(() => _dataHelper.Add(Doctor));
            // check the result of proccess
            if (ResultAddOrEdit == 1) // Seccessfuly
            {
                // Show Notifiction
                MessageCollection.ShowAddNotification();
                ClearFileds();
                // Updat View
                if (DoctorUserControl != null) DoctorUserControl.LoadData();
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
            ResultAddOrEdit = await Task.Run(() => _dataHelper.Edit(Doctor));
            // check the result of proccess
            if (ResultAddOrEdit == 1) // Seccessfuly
            {
                // Show Notification
                MessageCollection.ShowEditNotification();
                // Updat View
                DoctorUserControl.LoadData();
            }
            else // End with database error
            {
                MessageCollection.ShowServerMessage();
            }
        }

        private void ClearFileds()
        {
            txtDoctorName.Text = string.Empty;
            txtDoctorAddress.Text = string.Empty;
            txtDoctorPhone.Text = string.Empty;
            txtDoctorEmail.Text = string.Empty;
            txtDoctorSpecialit.Text = string.Empty;
        }

        private async void SetDataToFileds()
        {
            if (_dataHelper.IsDbConnect())
            {
                Doctor = await Task.Run(() => _dataHelper.Find(id));
                txtDoctorName.Text = Doctor.FullName;
                txtDoctorAddress.Text = Doctor.Address;
                txtDoctorPhone.Text = Doctor.Phone;
                txtDoctorEmail.Text = Doctor.Email;
                txtDoctorSpecialit.Text = Doctor.Specialty;
                //ImageHelper.ByteArrayToImage(Doctor.Image, PicChange);
            }
            else
            {
                MessageCollection.ShowServerMessage();
            }
            Doctor = null;
        }
        private void SetDataForAdd()
        {
            Doctor = new Doctor
            {
                FullName = txtDoctorName.Text,
                Address = txtDoctorAddress.Text,
                Phone = txtDoctorPhone.Text,
                Email = txtDoctorEmail.Text,
                Specialty = txtDoctorSpecialit.Text
            };
        }
        private void SetDataForEdit()
        {
            Doctor = new Doctor
            {
                Id = this.id,
                FullName = txtDoctorName.Text,
                Address = txtDoctorAddress.Text,
                Phone = txtDoctorPhone.Text,
                Email = txtDoctorEmail.Text,
                Specialty = txtDoctorSpecialit.Text
            };
        }
        private bool IsRequiredFiledEmpty()
        {
            if (txtDoctorName.Text == string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void tableLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
    }
}
