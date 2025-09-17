using DevExpress.XtraEditors;
using DevExpress.XtraExport.Helpers;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Vision_Pharmacy.Code;
using Vision_Pharmacy.Gui.DoashbordGui;
using Vision_Pharmacy.Gui.EmployeeGui;
using Vision_Pharmacy.Gui.MedicationGui;
using Vision_Pharmacy.Gui.PurchaseGui;
using Vision_Pharmacy.Gui.SaleGui;
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
        PanelSlider pnlbtnSession;
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
            pnlbtnSession = new PanelSlider(pnl_06, btnSession.Height + 2, 180, 15, false); // حركة طولية

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

            if (Properties.Settings.Default.ChangeLang == "Ar")
            {
                ApplyArabicResources();
            }
            else
            {
                ApplyEnglishResources();
            }
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
                    LinkColor = System.Drawing.Color.Navy,
                    Font = new System.Drawing.Font("Cairo Medium", 10, FontStyle.Bold),
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
                        ForeColor = System.Drawing.Color.Gray,
                        Font = new System.Drawing.Font("Cairo Medium", 10, FontStyle.Regular),
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
            UpdateBreadcrumb("إدارة المبيعات");
        }

        private void btnSession_Click(object sender, EventArgs e)
        {
            pnlbtnSession.Toggle();
            UpdateBreadcrumb("إدارة الموردين");
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
            //PnlSetting.Location = new Point(Location.X + flowLayoutPanel1.Size.Width - 20, 10);
            //= new Location(flowLayoutPanel1.Size.Width-20, 10);  
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
            SaleUserControl SaleUserControl = new SaleUserControl();
            SaleUserControl.Dock = DockStyle.Fill; // لملء الـ panel
            panelContainer.Controls.Add(SaleUserControl);
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

        private void MovSuppliers_Click(object sender, EventArgs e)
        {
           
        }

        private void btnExpired_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear(); // إزالة المحتوى السابق إن وُجد
            ExpiredUserControl ExpiredUserControl = new ExpiredUserControl();
            ExpiredUserControl.Dock = DockStyle.Fill; // لملء الـ panel
            panelContainer.Controls.Add(ExpiredUserControl);
        }

        //ملف ترجمة الى اللغة العربية
        private void ApplyArabicResources()
        {
            // تغيير اتجاه النموذج إلى اليمين لليسار
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            bunifuShadowPanel1.RightToLeft = RightToLeft.Yes;
            //flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            //flowLayoutPanel1.RightToLeft = RightToLeft.Yes;

            // تغيير نصوص الأزرار والعناصر الأخرى إلى العربية 
            label1.Text = Resources_Ar.label2;
            btnUser.Text = "المستخدمين";
            btnSett.Text = "الإعدادات";
            btnExit.Text = "تسجيل الخروج";

            btnHome.Text = "لوحة التحكم";
            btnGDS.Text = "إدارة المخزون";
            btnProduct.Text = "قائمة الأدوية";
            btnExpired.Text = "المنتجات منتهية الصلاحية";
            btnPurchases.Text = "إدارة المشتريات";
            btnAddFact.Text = "إضافة فاتورة شراء";
            simpleButton4.Text = "قائمة المشتريات";
            btnCases.Text = "إدارة المبيعات"; 
            btnSession.Text = "إدارة الموردين";
            btnSupplier.Text = "قائمة الموردين";
            MovSuppliers.Text = "حركات الموردين";
            btnSession.Text = "نقطة البيع (POS)";
            btnRH.Text = "الموارد البشرية";
            btnListEmp.Text = "قائمة الموظفين";
            btnAttendEmp.Text = "تسجيل الحضور و الغياب";
            btnPayEmp.Text = "الرواتب الشهرية";
            btnFinance.Text = "الإدارة المالية";
            btnCalander.Text = "قسم التقارير";
            btnRepports.Text = "المستخدمون والصلاحيات";
            btnSetings.Text = "الاعدادات";
            simpleButton11.Text = "القضايا";
            simpleButton12.Text = "أنواع القضايا";
            simpleButton21.Text = "أنواع القضايا";
            simpleButton19.Text = "صلاحيات المستخدمين";
            btnUsers.Text = "المستخدمون";
            btnListUsers.Text = "قائمة المستخدمين";
            btnStngs.Text = "الإعدادات";
        }

        //ملف ترجمة الى اللغة الانجليزية
        private void ApplyEnglishResources()
        {
            // Change the form orientation to right-to-left
            this.RightToLeft = RightToLeft.No;
            this.RightToLeftLayout = false;
            bunifuShadowPanel1.RightToLeft = RightToLeft.No;
            //flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            //flowLayoutPanel1.RightToLeft = RightToLeft.No;



            // Change the text of buttons and other elements to Arabic
            label1.Text = Resources_En.label2;
            btnUser.Text = "Users";
            btnSett.Text = "Settings";
            btnExit.Text = "Log Out";

            btnHome.Text = "Control Panel";
            btnGDS.Text = "Inventory Management";
            btnProduct.Text = "Medication List";
            btnExpired.Text = "Expired Products";
            btnPurchases.Text = "Purchase Management";
            btnAddFact.Text = "Add a Purchase Invoice";
            simpleButton4.Text = "Purchase List";
            btnCases.Text = "Sales Management";
            btnSession.Text = "Manage Suppliers";
            btnSupplier.Text = "Supplier List";
            MovSuppliers.Text = "Supplier Transactions"; 
            btnRH.Text = "Human Resources";
            btnListEmp.Text = "Employee List";
            btnAttendEmp.Text = "Attendance and Absence Recording";
            btnPayEmp.Text = "Monthly Payroll";
            btnFinance.Text = "Financial Management";
            btnCalander.Text = "Reports Section";
            btnRepports.Text = "Users and Permissions";
            btnSetings.Text = "Settings";
            simpleButton11.Text = "Issues";
            simpleButton12.Text = "Issues Types";
            simpleButton21.Text = "Issues Types";
            simpleButton19.Text = "User Permissions";
            btnUsers.Text = "Users";
            btnListUsers.Text = "User List";
            btnStngs.Text = "Settings";
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear(); // إزالة المحتوى السابق إن وُجد
            SupplierUserControl supplierUserControl = new SupplierUserControl();
            supplierUserControl.Dock = DockStyle.Fill; // لملء الـ panel
            panelContainer.Controls.Add(supplierUserControl);
        }

        private void MovSupplierss_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear(); // إزالة المحتوى السابق إن وُجد
            Purchases_SupplierUserControl Purchases_SupplierUserControl = new Purchases_SupplierUserControl();
            Purchases_SupplierUserControl.Dock = DockStyle.Fill; // لملء الـ panel
            panelContainer.Controls.Add(Purchases_SupplierUserControl);
        }
    }

}
