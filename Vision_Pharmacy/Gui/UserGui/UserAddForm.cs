using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vision_Pharmacy.Code;
using Vision_Pharmacy.Core;
using Vision_Pharmacy.Data;
using Vision_Pharmacy.Data.EFSqlServer;
using Vision_Pharmacy.Gui.OtherGui;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Vision_Pharmacy.Gui.UserGui
{
    public partial class UserAddForm : DevExpress.XtraEditors.XtraForm
    {
        AllClasses AllClasses = new AllClasses();

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
        private readonly UserUserControl userUserControl;
        private readonly LoadingUser loading;
        private IDataHelper<User> _dataHelper;
        private User user;
        private int ResultAddOrEdit;

        public bool IsUsersEmpty { get; }

        // Constructores
        public UserAddForm(int Id, UserUserControl userUserControl, bool IsUsersEmpty)
        {
            InitializeComponent();
            AllClasses.RoundPanelCornersForm(this, 25); // 15 مثل bunifu


            // Set Property Instance
            id = Id;
            this.userUserControl = userUserControl;
            this.IsUsersEmpty = IsUsersEmpty;
            loading = LoadingUser.Instance();
            _dataHelper = (IDataHelper<User>)ContainerConfig.ObjectType("User");
            // Set DataFileds for Edit void
            if (id > 0)
            {
                SetDataToFileds();
            }

        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pnl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        // Events
        private void buttonSave_Click(object sender, EventArgs e)
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
        private async void AddData()
        {
            // Set Data
            SetDataForAdd();
            // Send data and get result
            ResultAddOrEdit = await Task.Run(() => _dataHelper.Add(user));
            // check the result of proccess
            if (ResultAddOrEdit == 1) // Seccessfuly
            {
                // Show Notifiction
                MessageCollection.ShowAddNotification();
                ClearFileds();
                // Updat View
                userUserControl.LoadData();
                Close();
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
            ResultAddOrEdit = await Task.Run(() => _dataHelper.Edit(user));
            // check the result of proccess
            if (ResultAddOrEdit == 1) // Seccessfuly
            {
                // Show Notification
                MessageCollection.ShowEditNotification();
                // Updat View
                userUserControl.LoadData();
                Close();
            }
            else // End with database error
            {
                MessageCollection.ShowServerMessage();
            }
        }

        private void ClearFileds()
        {
        }

        private async void SetDataToFileds()
        {
            if (_dataHelper.IsDbConnect())
            {
                user = await Task.Run(() => _dataHelper.Find(id));
                textBoxName.Text = user.FullName;
                textBoxPassword.Text = user.Password;
                textBoxUserName.Text = user.UserName;
                textBoxPassword.Text = user.Password;
                comboBoxRole.SelectedItem = user.Role;
            }
            else
            {
                MessageCollection.ShowServerMessage();

            }
            user = null;
        }
        private void SetDataForAdd()
        {
            user = new User
            {
                FullName = textBoxName.Text,
                UserName = textBoxUserName.Text,
                Password = textBoxPassword.Text,
                Role = comboBoxRole.SelectedItem.ToString(),
            };
        }
        private void SetDataForEdit()
        {
            user = new User
            {
                Id = this.id,
                FullName = textBoxName.Text,
                UserName = textBoxUserName.Text,
                Password = textBoxPassword.Text,
                Role = comboBoxRole.SelectedItem.ToString()
            };
        }
        private bool IsRequiredFiledEmpty()
        {
            if (textBoxName.Text == string.Empty
                || textBoxPassword.Text == string.Empty
                || textBoxUserName.Text == string.Empty
                || comboBoxRole.SelectedItem == null
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        private void UserAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsUsersEmpty)
            {
                Application.Exit();
                MessageBox.Show("اعد تشغيل البرنامج لطفا");
            }
        }

        private void UserAddForm_MouseDown(object sender, MouseEventArgs e)
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
    }
}