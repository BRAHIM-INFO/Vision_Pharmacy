using DevExpress.XtraSplashScreen;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Vision_Pharmacy.Code;
using Vision_Pharmacy.Core;
using Vision_Pharmacy.Data;
using Vision_Pharmacy.Data.EFSqlServer;
using Vision_Pharmacy.Gui.UserGui;

namespace Vision_Pharmacy.Gui.OtherGui
{
    public partial class WelcomeScreen : SplashScreen
    {
        private IDataHelper<User> _dataHelper;
        private int StartState;
        public WelcomeScreen()
        {
            InitializeComponent();
            // 2. طبق الـ Migration أو أنشئ الجداول
            using (var context = new DBContext())
            {
                context.Database.Migrate(); // يعمل Apply لكل Migrations
            }
            _dataHelper = (IDataHelper<User>)ContainerConfig.ObjectType("User");
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        /// <summary>
        /// This Mehod Check connection
        /// </summary>
        /// <returns> 1 for new use , 2 for Log ing , 3 for Erorr</returns>
        private int ConState()
        {
            if (_dataHelper.IsDbConnect())
            {
                var userid = _dataHelper.GetData().Select(x => x.Id).ToList();

                if (userid.Count > 0)
                {
                    // Login
                    return 2;
                }
                else
                {
                    // New User
                    return 1;
                }
            }
            else
            {
                // Error in Connetion String
                return 3;
            }
        }

        private async void WelcomeScreen_Load(object sender, EventArgs e)
        {
            Thread.Sleep(7000);
            //labelstate.Text = "جاري الاتصال بقاعدة البيانات ...";
            StartState = await Task.Run(() => ConState());
            if (StartState == 1)
            {
                // Add New User
                UserAddForm userAddForm = new UserGui.UserAddForm(0, new UserGui.UserUserControl(), true);
                userAddForm.Show();
                this.Hide();
            }
            else if (StartState == 2)
            {
                // Login
                UserLogin userLogin = new UserLogin();
                userLogin.Show();
                this.Hide();

            }
            else
            {
                // Connection Error
                // Exit Or Setup Connection from settings form
                var Text = "هل تود ضبط الاتصال بالسيرفر ؟";
                var caption = "لا يمكن الاتصال في السيرفر";

                var result = MessageBox.Show(Text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    //Gui.SettingsForm settingsForm = new SettingsForm(true);
                    //settingsForm.Show();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        public enum SplashScreenCommand
        {
        }
    }
}