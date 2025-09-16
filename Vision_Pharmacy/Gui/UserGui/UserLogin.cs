using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using Vision_Pharmacy.Code; 
using Vision_Pharmacy.Core;
using Vision_Pharmacy.Data;
using Vision_Pharmacy.Gui.OtherGui; 

namespace Vision_Pharmacy.Gui.UserGui
{
    public partial class UserLogin : DevExpress.XtraEditors.XtraForm
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
        private readonly LoadingUser loading;
        private IDataHelper<User> _dataHelper;
        private User user;
        private int ResultAddOrEdit;
        private bool IsLogin;

        public bool IsUsersEmpty { get; }

        // Constructores
        public UserLogin()
        {
            InitializeComponent();
            // Set Property Instance
            loading = LoadingUser.Instance();
            _dataHelper = (IDataHelper<User>)ContainerConfig.ObjectType("User");
            LoadData();
            allClasses.RoundPictCorners(pictureBox2, 40); // 15 مثل bunifu
            allClasses.RoundPanelCornersForm(this, 50); // 15 مثل bunifu
            Properties.Settings.Default.ChangeLang = "Ar";
            Properties.Settings.Default.Save();

        }

        // Events
        #region
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
         
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            // check requirments of fileds
            if (IsRequiredFiledEmpty())
            {
                MessageCollection.ShowEmptyFields();
            }
            else
            {
                loading.Show();

                // Login
                var userName = textBoxUserName.Text;
                var Password = textBoxPassword.Text;
                var LoginState = await Task.Run(() => LogIn(userName, Password));
                if (LoginState == 1)
                {
                    // Log in
                    FormMain main = new FormMain();
                    Properties.Settings.Default.User = user.FullName;
                    Properties.Settings.Default.Role = user.Role;
                    if (SwitchLang.IsOn == true)
                    {
                        Properties.Settings.Default.ChangeLang = "En";  
                    }
                    else
                    {
                        Properties.Settings.Default.ChangeLang = "Ar"; 
                    }

                    Properties.Settings.Default.Save();
                    main.Show();
                    IsLogin = true;
                    this.Close();
                }
                else if (LoginState == 2)
                {
                    // Show Login Invalid User
                    MessageBox.Show("معلومات المستخدم التي ادخلتها غير صحيحة. اتصل بمدير النظام لتزويدك بمعلومات تسجيل الدخول", "خطأ في معلومات المستخدم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Server Conncetion Error
                    MessageCollection.ShowServerMessage();

                }
                loading.Hide();
            }
            //new ToastNotificationForm("تمت عملية الدخول بنجاح!").Show();
        }

        private void UserLogin_MouseDown(object sender, MouseEventArgs e)
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

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        #endregion

        #region Methods

        public async void LoadData()
        {
            loading.Show();
            // Check if connection is available
            if (_dataHelper.IsDbConnect())
            {
                // Loading Data
                foreach (var item in _dataHelper.GetData())
                {
                    textBoxUserName.Properties.Items.Add(item.UserName);
                }
            }
            else
            {
                MessageCollection.ShowServerMessage();
            }
            loading.Hide();


        }

        private bool IsRequiredFiledEmpty()
        {
            if (
                 textBoxPassword.Text == string.Empty
                || textBoxUserName.Text == string.Empty
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// This Method Check Login State 
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="Password"></param>
        /// <returns>1 if login, 2 if invalid user login data, 3 server error</returns>
        private int LogIn(string UserName, string Password)
        {
            if (_dataHelper.IsDbConnect())
            {
                try
                {
                    user = _dataHelper.GetData().Where(x => x.UserName == UserName && x.Password == Password).First();
                    if (user.Id > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
                catch
                {
                    return 2;

                }

            }
            else
            {
                return 3;
            }

        }
        #endregion

        //ملف الموارد العربي
        private void ApplyArabicResources()
        {

            // إعادة تحميل النصوص من ملف الموارد حسب اللغة الحالية
            this.Text = Resources_Ar.FormTitle;
            labelControl3.Text = Resources_Ar.labelControl3;
            lblTitle.Text = Resources_Ar.lblTitle;
            labelControl2.Text = Resources_Ar.labelControl2;
            labelControl1.Text = Resources_Ar.labelControl1;
            btnLogin.Text = Resources_Ar.btnLogin;
            label2.Text = Resources_Ar.label2;
            SwitchLang.Properties.OnText = Resources_En.SwitchLang;
        }

        //ملف الموارد انجليزي
        private void ApplyEnglishResources()
        {
            // إعادة تحميل النصوص من ملف الموارد حسب اللغة الحالية
            this.Text = Resources_En.FormTitle;
            labelControl3.Text = Resources_En.labelControl3;
            lblTitle.Text = Resources_En.lblTitle;
            labelControl2.Text = Resources_En.labelControl2;
            labelControl1.Text = Resources_En.labelControl1;
            btnLogin.Text = Resources_En.btnLogin;
            label2.Text = Resources_En.label2;
            SwitchLang.Properties.OffText = Resources_En.SwitchLang;
        }

        //private void ChangeLanguage(string langCode)
        //{
        //    Thread.CurrentThread.CurrentUICulture = new CultureInfo(langCode);
        //    Thread.CurrentThread.CurrentCulture = new CultureInfo(langCode);
        //    //Controls.Clear();
        //    //InitializeComponent();
        //    if (langCode == "ar")
        //    {
        //        ApplyArabicResources();
        //    }
        //    else if (langCode == "en")
        //    {
        //        ApplyEnglishResources();
        //    }
        //}

        private void SwitchLang_Toggled(object sender, EventArgs e)
        {
            if (SwitchLang.IsOn == true)
            {
                Properties.Settings.Default.ChangeLang = "En";
                Properties.Settings.Default.Save();
                ApplyEnglishResources();

            }
            else
            {
                Properties.Settings.Default.ChangeLang = "Ar";
                Properties.Settings.Default.Save();
                ApplyArabicResources();
            }
        }

        private async void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                // check requirments of fileds
                if (IsRequiredFiledEmpty())
                {
                    MessageCollection.ShowEmptyFields();
                }
                else
                {
                    loading.Show();

                    // Login
                    var userName = textBoxUserName.Text;
                    var Password = textBoxPassword.Text;
                    var LoginState = await Task.Run(() => LogIn(userName, Password));
                    if (LoginState == 1)
                    {
                        // Log in
                        FormMain main = new FormMain();
                        Properties.Settings.Default.User = user.FullName;
                        Properties.Settings.Default.Role = user.Role;
                        Properties.Settings.Default.Save();
                        main.Show();
                        IsLogin = true;
                        this.Close();
                    }
                    else if (LoginState == 2)
                    {
                        // Show Login Invalid User
                        MessageBox.Show("معلومات المستخدم التي ادخلتها غير صحيحة. اتصل بمدير النظام لتزويدك بمعلومات تسجيل الدخول", "خطأ في معلومات المستخدم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Server Conncetion Error
                        MessageCollection.ShowServerMessage();

                    }
                    loading.Hide();
                }
            }
        }
    }
}