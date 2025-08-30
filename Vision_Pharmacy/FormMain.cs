using DevExpress.XtraExport.Helpers;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using Vision_Pharmacy.Code;
using Vision_Pharmacy.Gui.DoashbordGui;
using Vision_Pharmacy.Gui.EmployeeGui;
using Vision_Pharmacy.Gui.MedicationGui;
using Vision_Pharmacy.Gui.PurchaseGui;
using Vision_Pharmacy.Gui.SettingGui;
using Vision_Pharmacy.Gui.SupplierGui;
using Vision_Pharmacy.Gui.UserGui;

namespace Vision_Pharmacy
{

    public partial class FormMain : DevExpress.XtraEditors.XtraForm
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

        AllClasses AllClasses = new AllClasses();
        PanelSlider sliderUsers;
        PanelSlider sliderlateral;
        PanelSlider pnlCases;
        PanelSlider pnlFincance;
        PanelSlider pnlRH;
        PanelSlider pnlRepports;
        PanelSlider pnlParametres;
        PanelSlider pnlGDS;
        PanelSlider pnlPurchase;
        bool isMaximized = false;

        UserUserControl myControl;
        System.Windows.Forms.Timer slideTimers;
        int targetX = 0; // الموضع النهائي داخل الـ panel

        //private bool panelVisible = false;
        //private int panelTargetHeight = 190; // الارتفاع النهائي المطلوب عند الإظهار
        //private int slideStep = 10; // سرعة الحركة


        public FormMain()
        {
            InitializeComponent();
            UpdateBreadcrumb("لوحة التحكم");

            // إعداد التايمر للحركة
            slideTimer.Interval = 15;

            pnlPurchase = new PanelSlider(pnl_04, btnPurchases.Height + 2, 200, 15, false); // حركة طولية
            sliderlateral = new PanelSlider(PnlSetting, 0, 190, 40, false);
            sliderUsers = new PanelSlider(pnlSlideHome, 55, 270, 40, true);      // حركة عرضية 
            pnlCases = new PanelSlider(pnl_05, btnCases.Height + 2, 180, 15, false); // حركة طولية
            pnlFincance = new PanelSlider(pnl_08, btnFinance.Height + 2, 175, 15, false); // حركة طولية
            pnlRH = new PanelSlider(pnl_07, btnRH.Height + 2, 230, 15, false); // حركة طولية
            pnlRepports = new PanelSlider(pnl_10, btnRepports.Height + 2, 235, 15, false); // حركة طولية
            pnlParametres = new PanelSlider(pnl_11, btnSetings.Height + 2, 150, 15, false); // حركة طولية
            pnlGDS = new PanelSlider(pnl_03, btnGDS.Height + 2, 180, 15, false); // حركة طولية

            // نكبير الشاشة تلقائياً عند فتح النموذج
            if (!isMaximized)
            {
                MaximizeWithoutCoveringTaskbar();
                isMaximized = true;
            }
            else
            {
                this.Size = new Size(1500, 1000); // الحجم العادي الذي تريده
                this.StartPosition = FormStartPosition.CenterScreen;
                isMaximized = false;
            }
            MessageBox.Show(Properties.Settings.Default.ChangeLang);
        }

        private void MaximizeWithoutCoveringTaskbar()
        {
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = workingArea.Location;
            this.Size = workingArea.Size;
        }

        private void UpdateBreadcrumb(params string[] levels)
        {
            breadcrumbPanel.Controls.Clear();
            for (int i = levels.Length - 1; i >= 0; i--)
            {
                var link = new LinkLabel
                {
                    Text = levels[i],
                    AutoSize = true,
                    LinkColor = Color.Navy,
                    Font = new Font("Cairo Medium", 10, FontStyle.Bold),
                    Margin = new Padding(0, 0, 5, 0),
                    Tag = i  // يمكنك استخدامه لمعرفة أي مرحلة تم الضغط عليها
                };

                // الحدث عند الضغط
                link.Click += (s, e) =>
                {
                    LinkLabel clicked = (LinkLabel)s;
                    int index = (int)clicked.Tag;
                    MessageBox.Show($"تم الضغط على: {levels[index]}");
                    // يمكنك هنا تنفيذ التنقل المناسب
                };

                breadcrumbPanel.Controls.Add(link);
                // أضف فاصل (>) بين الخطوات
                if (i > 0)
                {
                    var separator = new Label
                    {
                        Text = " > ",
                        AutoSize = true,
                        ForeColor = Color.Gray,
                        Font = new Font("Cairo Medium", 10, FontStyle.Regular),
                        Margin = new Padding(0, 0, 5, 0)
                    };
                    breadcrumbPanel.Controls.Add(separator);

                }
            }
        }

        private async void btnHome_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear(); // إزالة المحتوى السابق إن وُجد
            Dashboard uc = new Dashboard();
            uc.Dock = DockStyle.Fill; // لملء الـ panel
            panelContainer.Controls.Add(uc);
        }

        private void LoadUserControl()
        {
            panelContainer.Controls.Clear(); // إزالة المحتوى السابق إن وُجد
            //ClientUserControl uc = new ClientUserControl();
            //uc.Dock = DockStyle.Fill; // لملء الـ panel
            //panelMain.Controls.Add(uc);
        }



        private void btnCases_Click(object sender, EventArgs e)
        {
            pnlCases.Toggle();
            UpdateBreadcrumb("القضايا");
        }

        private void btnSession_Click(object sender, EventArgs e)
        {
            UpdateBreadcrumb("الجلسات");
        }

        private void btnCalander_Click(object sender, EventArgs e)
        {
            UpdateBreadcrumb("التقويم");
        }

        private void btnFinance_Click(object sender, EventArgs e)
        {
            pnlFincance.Toggle();
        }

        private void btnRH_Click(object sender, EventArgs e)
        {
            pnlRH.Toggle();

        }

        private void btnRepports_Click(object sender, EventArgs e)
        {
            pnlRepports.Toggle();

        }

        private void btnSetings_Click(object sender, EventArgs e)
        {
            pnlParametres.Toggle();

        }

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void pnlSlideHome_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnMaximizeRestore_Click(object sender, EventArgs e)
        {
            if (!isMaximized)
            {
                MaximizeWithoutCoveringTaskbar();
                isMaximized = true;
            }
            else
            {
                this.Size = new Size(1500, 1000); // الحجم العادي الذي تريده
                this.StartPosition = FormStartPosition.CenterScreen;
                isMaximized = false;
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            sliderlateral.Toggle();
            PnlSetting.Visible = true;
            //timer2.Start();
        }

        private void BtnSlider_Click(object sender, EventArgs e)
        {
            sliderUsers.Toggle();
        }

        private void btnListUsers_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear(); // إزالة المحتوى السابق إن وُجد
            UserUserControl uc = new UserUserControl();
            uc.Dock = DockStyle.Fill; // لملء الـ panel
            panelContainer.Controls.Add(uc);
        }

        private void btnStngs_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(false);
            settingsForm.ShowDialog(); // عرض النموذج كحوار
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear(); // إزالة المحتوى السابق إن وُجد
            Dashboard dashboard = new Dashboard();
            dashboard.Dock = DockStyle.Fill; // لملء الـ panel
            panelContainer.Controls.Add(dashboard);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // إنهاء التطبيق
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear(); // إزالة المحتوى السابق إن وُجد
            UserUserControl uc = new UserUserControl();
            uc.Dock = DockStyle.Fill; // لملء الـ panel
            panelContainer.Controls.Add(uc);
        }

        private void btnSett_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(false);
            settingsForm.ShowDialog(); // عرض النموذج كحوار
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear(); // إزالة المحتوى السابق إن وُجد
            SupplierUserControl supplierUserControl = new SupplierUserControl();
            supplierUserControl.Dock = DockStyle.Fill; // لملء الـ panel
            panelContainer.Controls.Add(supplierUserControl);

        }

        private void btnListEmp_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear(); // إزالة المحتوى السابق إن وُجد
            EmployeeUserControl EmployeeUserControl = new EmployeeUserControl();
            EmployeeUserControl.Dock = DockStyle.Fill; // لملء الـ panel
            panelContainer.Controls.Add(EmployeeUserControl);
        }

        private void btnAttendEmp_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear(); // إزالة المحتوى السابق إن وُجد
            FormAttendance FormAttendance = new FormAttendance();
            FormAttendance.Dock = DockStyle.Fill; // لملء الـ panel
            panelContainer.Controls.Add(FormAttendance);
        }

        private void btnPayEmp_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear(); // إزالة المحتوى السابق إن وُجد
            FormPayroll FormPayroll = new FormPayroll();
            FormPayroll.Dock = DockStyle.Fill; // لملء الـ panel
            panelContainer.Controls.Add(FormPayroll);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear(); // إزالة المحتوى السابق إن وُجد
            MedicationUserControl MedicationUserControl = new MedicationUserControl();
            MedicationUserControl.Dock = DockStyle.Fill; // لملء الـ panel
            panelContainer.Controls.Add(MedicationUserControl);
        }

        private void btnGDS_Click(object sender, EventArgs e)
        {
            pnlGDS.Toggle();
            UpdateBreadcrumb("إدارة المخزون");

        }

        private void btnAddFact_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear(); // إزالة المحتوى السابق إن وُجد
            PurchaseUserControl PurchaseUserControl = new PurchaseUserControl();
            PurchaseUserControl.Dock = DockStyle.Fill; // لملء الـ panel
            panelContainer.Controls.Add(PurchaseUserControl);
        }

        private void btnPurchases_Click(object sender, EventArgs e)
        {
            pnlPurchase.Toggle();
            UpdateBreadcrumb("إدارة المشتريات");
        }

        private void MovSupplier_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear(); // إزالة المحتوى السابق إن وُجد
            Purchases_SupplierUserControl Purchases_SupplierUserControl = new Purchases_SupplierUserControl();
            Purchases_SupplierUserControl.Dock = DockStyle.Fill; // لملء الـ panel
            panelContainer.Controls.Add(Purchases_SupplierUserControl);
        }

        private void btnExpired_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear(); // إزالة المحتوى السابق إن وُجد
            ExpiredUserControl ExpiredUserControl = new ExpiredUserControl();
            ExpiredUserControl.Dock = DockStyle.Fill; // لملء الـ panel
            panelContainer.Controls.Add(ExpiredUserControl);
        }
    }

}
