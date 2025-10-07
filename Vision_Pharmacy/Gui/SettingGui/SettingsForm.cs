using Vision_Pharmacy.Code; 
using Vision_Pharmacy.Data.EFSqlServer;
using Vision_Pharmacy.Gui.OtherGui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vision_Pharmacy.Gui.SettingGui
{
    public partial class SettingsForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly bool isOpenFromStart;
        LoadingUser Loading;
        DBContext db;
        DataBaseBackUpAndRestor BackUpAndRestor;

        public SettingsForm(bool IsOpenFromStart)
        {
            InitializeComponent();

            db = new DBContext();
            Loading = LoadingUser.Instance();
            LoadSettings();
            isOpenFromStart = IsOpenFromStart;
            BackUpAndRestor = new DataBaseBackUpAndRestor();

            if (Properties.Settings.Default.ChangeLang == "Ar")
            {
                ApplyArabicResources();
            }
            else
            {
                ApplyEnglishResources();
            }

        }

        private void buttonSaveGeneralSettings_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void buttonSaveServerSettings_Click(object sender, EventArgs e)
        {
            SaveConString();

        }

        private async void buttonBackUp_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            var rs = fbd.ShowDialog();
            if (rs == DialogResult.OK)
            {
                Loading.Show();
                var SelectPath = fbd.SelectedPath;
                var dbName = textBoxDataBase.Text;
                var state = await Task.Run(() => BackUpAndRestor.BackUp(SelectPath, dbName));

                if (state == "1")
                {
                    Properties.Settings.Default.LastBackUpDate = DateTime.Now.ToShortDateString();
                    Properties.Settings.Default.Save();
                    MessageBox.Show("تمت عملية النسخ الاحتياطي بنجاح");
                }
                else
                {
                    MessageBox.Show(state + " خطأ في عملية اجراء النسخ الاحتياطي, تأكد من تشغيل البرنامج كمسؤول لاجراء العملية");
                }

                Loading.Hide();
            }
        }

        private async void buttonRestore_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Bak File|*.bak";
            var result = fileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                Loading.Show();
                var FileName = fileDialog.FileName;
                var dbName = textBoxDataBase.Text;
                var state = await Task.Run(() => BackUpAndRestor.RestoreDataBase(FileName, dbName));

                if (state == "1")
                {
                    MessageBox.Show("تمت عملية استعادة النسخة الاحتياطية بنجاح");
                }
                else
                {
                    MessageBox.Show(state + " خطأ في عملية اجراء النسخ الاحتياطي, تأكد من تشغيل البرنامج كمسؤول لاجراء العملية");
                }

                Loading.Hide();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            LoadImage();
        }

        private void LoadSettings()
        {
            try
            {
                // Get And Set Excit Settings
                textBoxCompanyName.Text = Properties.Settings.Default.CompanyName;
                textBoxCompanyAdress.Text = Properties.Settings.Default.CompanyAdress;
                textBoxCompanyEmail.Text = Properties.Settings.Default.CompanyEmail;
                textBoxCompanyTel.Text = " رقم الهاتف : " + Properties.Settings.Default.CompanyTel;
                comboBoxCurrency.SelectedItem = Properties.Settings.Default.Currency;
                numericUpDownDamageDuration.Value = Properties.Settings.Default.NotificationDamagDuration;
                tabPageGeneral.Text = "اخر نسخ احتاطي:" + "(" + Properties.Settings.Default.LastBackUpDate + ")";
                var Logo = Convert.FromBase64String(Properties.Settings.Default.CompanyLogo);
                if (Logo != null)
                {
                    using (MemoryStream ma = new MemoryStream(Logo))
                    {
                        pictureBoxCompanyLogo.Image = Image.FromStream(ma);
                    }
                }
            }
            catch
            {
            }
        }

        private void SaveSettings()
        {
            try
            {
                // Submit Settings
                Properties.Settings.Default.CompanyName = textBoxCompanyName.Text;
                Properties.Settings.Default.CompanyAdress = textBoxCompanyAdress.Text;
                Properties.Settings.Default.CompanyEmail = textBoxCompanyEmail.Text;
                Properties.Settings.Default.CompanyTel = textBoxCompanyTel.Text;
                Properties.Settings.Default.Currency = comboBoxCurrency.SelectedItem.ToString();
                Properties.Settings.Default.NotificationDamagDuration = Convert.ToInt32(numericUpDownDamageDuration.Value);
                numericUpDownDamageDuration.Text = Properties.Settings.Default.NotificationDamagDuration.ToString();

                using (MemoryStream ma = new MemoryStream())
                {
                    pictureBoxCompanyLogo.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Png);
                    Properties.Settings.Default.CompanyLogo = Convert.ToBase64String(ma.ToArray());
                }
                Properties.Settings.Default.Save();
                //MessageBox.Show("تمت عملية الحفظ", "تم حفظ الاعدادات بنجاح");
                // Show Notifiction
                MessageCollection.ShowAddNotification();
            }
            catch
            {
                MessageBox.Show("خطأ غير متوقع", "تعذر حفظ الاعدادات");
            }
        }

        private void LoadImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "اختر شعار الشركة";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Filter = "Image (.png,jpg)|*.png;*.jpg";
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBoxCompanyLogo.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void SetConType()
        {
            if (radioButtonLocalConnect.IsOn == true)
            {
                textBoxPort.Enabled = true;
                textBoxUser.Enabled = true;
                textBoxPassword.Enabled = true;
            }
            else
            {
                textBoxPort.Enabled = false;
                textBoxUser.Enabled = false;
                textBoxPassword.Enabled = false;
            }
        }


        private void SaveConString()
        {
            var reslut = MessageBox.Show(
                  "انتبة انت على وشك تغيير اعدادات الاتصال,. هل انت متأكد من هذا الاجراء؟. تذكر لانسمح بعرض البيانات الاتصال السابقة", "تحديث نص الاتصال",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reslut == DialogResult.Yes)
            {
                // Get input
                var server = textBoxServer.Text;
                var dbname = textBoxDataBase.Text;
                var port = "," + textBoxPort.Text;
                var user = textBoxUser.Text;
                var password = textBoxPassword.Text;

                if (radioButtonLocalConnect.IsOn == false)
                {
                    // Local Con
                    var ConString = @"data source=" + server + " ;initial catalog=" + dbname + ";integrated security=true";

                    Properties.Settings.Default.SQLServerConString = ConString;
                    Properties.Settings.Default.Save();
                    System.Threading.Thread.Sleep(3000);
                    MessageBox.Show("تم تحديث الاتصال بنجاح , اعد تشغيل البرنامج لتطبيق الاعدادات ");
                }
                else
                {
                    // Local Con
                    var ConString = @"data source=" + server + port + ";initial catalog=" + dbname + ";user id=" + user + ";password=" + password + ";connect Timeout=60";

                    Properties.Settings.Default.SQLServerConString = ConString;
                    Properties.Settings.Default.Save();
                    System.Threading.Thread.Sleep(3000);
                    MessageBox.Show("تم تحديث الاتصال بنجاح , اعد تشغيل البرنامج لتطبيق الاعدادات ");
                }
                Application.Restart();
            }


        }

        private void radioButtonLocalConnect_Toggled(object sender, EventArgs e)
        {
            SetConType();
        }

        // // تغيير اللغة إلى العربية
        private void ApplyArabicResources()
        {
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;

            // General Settings
            tabPageGeneral.Text = "الاعدادات العامة";
            labelCompanyName.Text = "اسم الشركة";
            labelCompanyAdress.Text = "عنوان الشركة";
            labelCompanyEmail.Text = "البريد الالكتروني";
            labelCompanyTel.Text = "رقم الهاتف";
            labelCurrency.Text = "العملة الافتراضية";
            labelDamageDuration.Text = "مدة اشعار انتهاء الصلاحية (بالأيام)";
            buttonSaveGeneralSettings.Text = "حفظ الاعدادات";
            // Server Settings
            tabPageServer.Text = "اعدادات السيرفر";
            labelServer.Text = "اسم السيرفر";
            labelDataBase.Text = "اسم قاعدة البيانات";
            labelPort.Text = "المنفذ (Port)";
            labelUser.Text = "اسم المستخدم";
            labelPassword.Text = "كلمة المرور";
            buttonSaveServerSettings.Text = "حفظ اعدادات الاتصال";
            tabPageGeneral.Text = "اخر نسخ احتاطي:" + "(" + Properties.Settings.Default.LastBackUpDate + ")";
            buttonBackUp.Text = "اخذ نسخة احتياطية";
            buttonRestore.Text = "استعادة النسخة";
            radioButtonLocalConnect.Properties.OffText = "محلي";
            radioButtonLocalConnect.Properties.OnText = "شبكة";
            // Form Settings
            this.Text = "الاعدادات";
        }

        // تغيير اللغة إلى الانجليزية
        private void ApplyEnglishResources()
        {
            this.RightToLeft = RightToLeft.No;
            this.RightToLeftLayout = false;
            // General Settings
            tabPageGeneral.Text = "General Settings";
            labelCompanyName.Text = "Company Name";
            labelCompanyAdress.Text = "Company Adress";
            labelCompanyEmail.Text = "Company Email";
            labelCompanyTel.Text = "Company Tel";
            labelCurrency.Text = "Default Currency";
            labelDamageDuration.Text = "Notification Duration (Days)";
            buttonSaveGeneralSettings.Text = "Save Settings";
            // Server Settings
            tabPageServer.Text = "Server Settings";
            labelServer.Text = "Server Name";
            labelDataBase.Text = "Database Name";
            labelPort.Text = "Port";
            labelUser.Text = "User Name";
            labelPassword.Text = "Password";
            buttonSaveServerSettings.Text = "Save Connection Settings";
            tabPageGeneral.Text = "Last BackUp:" + "(" + Properties.Settings.Default.LastBackUpDate + ")";
            buttonBackUp.Text = "Back Up";
            buttonRestore.Text = "Restore BackUp";
            // Form Settings
            this.Text = "Settings";
            radioButtonLocalConnect.Properties.OffText = "Local";
            radioButtonLocalConnect.Properties.OnText = "Network";

        }

        private void SwitchLang_Toggled(object sender, EventArgs e)
        { 
            if (SwitchLang.IsOn == true)
            {
                PicLang.Image = null;
                PicLang.Image = Properties.Resources.Eng;
                Properties.Settings.Default.ChangeLang = "En";
                Properties.Settings.Default.Save();
                ApplyEnglishResources();

            }
            else
            {
                PicLang.Image = null;
                PicLang.Image = Properties.Resources.Arab;
                Properties.Settings.Default.ChangeLang = "Ar";
                Properties.Settings.Default.Save();
                ApplyArabicResources();
            }
        }
    }
}