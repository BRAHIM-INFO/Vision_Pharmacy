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
using Vision_Pharmacy.Gui.EmployeeGui;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Vision_Pharmacy.Gui.EmployeeGui
{
    public partial class EmployeeAddForm : DevExpress.XtraEditors.XtraForm
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
        private readonly EmployeeUserControl employeeUserControl;
        private readonly LoadingUser loading;
        private IDataHelper<Employees> _dataHelper;
        private Employees Employeess;
        private int ResultAddOrEdit;
        AllClasses AllClasses = new AllClasses();

        // Constructores
        public EmployeeAddForm()
        {
            InitializeComponent();
        }
        public EmployeeAddForm(int Id, EmployeeUserControl EmployeeUserControl)
        {
            InitializeComponent();
            AllClasses.RoundPanelCornersForm(this, 25); // 15 مثل bunifu
            AllClasses.RoundPanelCorners(panel1, 25); // 15 مثل bunifu
            AllClasses.RoundPanelCorners(panel2, 25); // 15 مثل bunifu

            // Set Property Instance
            id = Id;
            this.employeeUserControl = EmployeeUserControl;
            loading = LoadingUser.Instance();
            _dataHelper = (IDataHelper<Employees>)ContainerConfig.ObjectType("Employees");
            // Set DataFileds for Edit void
            if (id > 0)
            {
                SetDataToFileds();
            }
        }

        private void PicChange_Click(object sender, EventArgs e)
        {
            LoadImage();
        }

        private void buttonSaveEmp_Click(object sender, EventArgs e)
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
            ResultAddOrEdit = await Task.Run(() => _dataHelper.Add(Employeess));
            // check the result of proccess
            if (ResultAddOrEdit == 1) // Seccessfuly
            {
                // Show Notifiction
                MessageCollection.ShowAddNotification();
                ClearFileds();
                // Updat View
                employeeUserControl.LoadData();
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
            ResultAddOrEdit = await Task.Run(() => _dataHelper.Edit(Employeess));
            // check the result of proccess
            if (ResultAddOrEdit == 1) // Seccessfuly
            {
                // Show Notification
                MessageCollection.ShowEditNotification();
                // Updat View
                employeeUserControl.LoadData();
            }
            else // End with database error
            {
                MessageCollection.ShowServerMessage();
            }
        }

        private void ClearFileds()
        {
            txtEmpName.Text = string.Empty;
            txtEmpName.Text = Employeess.FullName;
            txtEmpRole.Text = Employeess.Role;
            txtEmpPhone.Text = Employeess.Phone;
            txtEmpDate.Text = Employeess.HireDate.ToString();
            txtEmpSalaire.Text = Employeess.Salary.ToString();

        }

        private async void SetDataToFileds()
        {
            if (_dataHelper.IsDbConnect())
            {
                Employeess = await Task.Run(() => _dataHelper.Find(id));
                txtEmpName.Text = Employeess.FullName.ToString();
                txtEmpRole.Text = Employeess.Role.ToString();
                txtEmpPhone.Text = Employeess.Phone;
                txtEmpDate.Text = Employeess.HireDate.ToString();
                txtEmpSalaire.Text = Employeess.Salary.ToString();
                chkEmpActive.IsOn = Employeess.IsActive;
                ImageHelper.ByteArrayToImage(Employeess.Image, PicChange);
            }
            else
            {
                MessageCollection.ShowServerMessage();

            }
            Employeess = null;
        }
        private void SetDataForAdd()
        {
            byte[] imageBytes = ImageHelper.ImageToByteArray(PicChange);
            Employeess = new Employees
            {
                FullName = txtEmpName.Text,
                Role = txtEmpRole.Text,
                Phone = txtEmpPhone.Text,
                HireDate =DateTime.Parse(txtEmpDate.Text),
                Salary = double.Parse(txtEmpSalaire.Text),
                Image = imageBytes,
                IsActive = chkEmpActive.IsOn // Assuming new Employeess are active by default
            };


        }
        private void SetDataForEdit()
        {
            byte[] imageBytes = ImageHelper.ImageToByteArray(PicChange);
            Employeess = new Employees
            {
                Id = this.id,
                FullName = txtEmpName.Text,
                Role = txtEmpRole.Text,
                Phone = txtEmpPhone.Text,
                HireDate = DateTime.Parse(txtEmpDate.Text),
                Salary = double.Parse(txtEmpSalaire.Text),
                Image = imageBytes,
                IsActive = chkEmpActive.IsOn // Assuming new Employeess are active by default
            };
        }
        private bool IsRequiredFiledEmpty()
        {
            if (txtEmpName.Text == string.Empty)
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

        private void EmployeeAddForm_MouseDown(object sender, MouseEventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEmpSalaire_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != '.' && ch != ',')
                e.Handled = true;

            if ((ch == '.' || ch == ',') && (txtEmpSalaire.Text.Contains('.') || txtEmpSalaire.Text.Contains(',')))
                e.Handled = true;
        }
    }
}