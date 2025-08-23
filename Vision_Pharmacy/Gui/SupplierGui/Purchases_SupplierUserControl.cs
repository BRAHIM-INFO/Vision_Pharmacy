using DevExpress.XtraCharts.Design;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vision_Pharmacy.Code;
using Vision_Pharmacy.Core;
using Vision_Pharmacy.Data;
using Vision_Pharmacy.Gui.OtherGui;

namespace Vision_Pharmacy.Gui.SupplierGui
{
    public partial class Purchases_SupplierUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        // Fields
        private readonly IDataHelper<Suppliers> _dataHelper;
        private readonly IDataHelper<Purchase> _dataHelperPurchase;
        private readonly LoadingUser loading;
        private Label labelEmptyData;
        private List<Purchase> purchasesList;
        AllClasses AllClasses = new AllClasses();
        public Purchases_SupplierUserControl()
        {
            InitializeComponent();
            loading = LoadingUser.Instance();
            labelEmptyData = ComponentsObject.Instance().LabelEmptyData();
            _dataHelper = (IDataHelper<Suppliers>)ContainerConfig.ObjectType("Supplier");
            _dataHelperPurchase = (IDataHelper<Purchase>)ContainerConfig.ObjectType("Purchase");
            LoadDataSupplier();
            AllClasses.RoundButtonCorners(btnPrintSup, 15);
        }

        //Methods
        #region

        // Set DataGridView Columns
        private void SetDataGridViewColumns()
        {
            try
            {
                gridView1.Columns[0].Visible = false; // Hide Column
                gridView1.Columns[1].Caption = "تاريخ الفاتورة";
                gridView1.Columns[2].Caption = "رقم الفاتورة";
                gridView1.Columns[3].Caption = "نوع الدفع";
                gridView1.Columns[4].Caption = "باركود الدواء";
                gridView1.Columns[5].Visible = false; // Hide Column 
                gridView1.Columns[6].Caption = "الكمية";
                gridView1.Columns[7].Caption = "سعر الشراء";
                gridView1.Columns[8].Caption = "سعر البيع";
                gridView1.Columns[9].Caption = "مجموع";
                gridView1.Columns[10].Visible = false; // Hide Column 
                gridView1.Columns[11].Caption = "مبلغ الفاتورة";
                gridView1.Columns[12].Visible = false; // Hide Column 
            }
            catch
            {
                // تجاهل الخطأ (يفضل تسجيله)
            }
            // Hide Columns
        }

        //Add and Show Empty Label   
        private void ShowLabelIfEmptyData()
        {
            DGListeSupplier.Controls.Add(labelEmptyData);

            if (gridView1.RowCount > 0)
            {
                labelEmptyData.Visible = false;
            }
            else
            {
                labelEmptyData.Visible = true;
            }

        }

        // جلب بيانات الموردين
        public async void LoadDataSupplier()
        {
            loading.Show();
            // Check if connection is available
            if (_dataHelper.IsDbConnect())
            {
                txtSupplier.Items.Clear();
                foreach (var item in await Task.Run(() => _dataHelper.GetData()))
                {
                    txtSupplier.Items.Add(item.Name);
                }
            }
            else
            {
                MessageCollection.ShowServerMessage();
            }
            loading.Hide();
        }

        // جلب بيانات المشتريات حسب المورد والتاريخ
        public List<Purchase> GetPurchasesBySupplierAndDate(int supplierId, DateTime startDate, DateTime endDate)
        {
            if (startDate > endDate)
            {
                MessageBox.Show("⚠️ التاريخ الأول يجب أن يكون قبل التاريخ الثاني");
                return new List<Purchase>();
            }


            purchasesList = _dataHelperPurchase.GetData()
                .Where(p => p.SupplierId == supplierId
                            && p.FactureDate >= startDate
                            && p.FactureDate <= endDate)
                .OrderBy(p => p.FactureDate)
                .ToList();
            return purchasesList;
        }

        //طباعة قائمة المشتريات
        private void PrintGridControl()
        {
            try
            {
                // 1️⃣ إنشاء نظام الطباعة ورابط الطباعة
                PrintingSystem printingSystem = new PrintingSystem();
                PrintableComponentLink printableLink = new PrintableComponentLink(printingSystem)
                {
                    Component = DGListeSupplier
                };

                // 2️⃣ إعداد رأس الصفحة مع النصوص والصورة
                printableLink.CreateMarginalHeaderArea += (sender, e) =>
                {
                    // 🔹 تحميل الصورة (تأكد من تغيير المسار إلى مسار الصورة الصحيح)
                    Image logo = Properties.Resources.logo_2025; //Properties.Resources.logo_2025; // ⬅️ ضع مسار الصورة الصحيح هنا

                    // 🔹 رسم الصورة في الزاوية اليسرى
                    RectangleF imageRect = new RectangleF(10, 10, 230, 150);
                    e.Graph.DrawImage(logo, imageRect);

                    // 🔹 نصوص الرأس (اسم الشركة والإدارات)
                    string headerText = Properties.Settings.Default.CompanyName + "\n" + Properties.Settings.Default.CompanyAdress + "\n" + Properties.Settings.Default.CompanyEmail + "\n" + " رقم الهاتف : " +   Properties.Settings.Default.CompanyTel;
                    e.Graph.Font = new Font("Cairo Medium", 12, FontStyle.Bold); // ⬅️ استخدام خط "Cairo Medium"
                    e.Graph.StringFormat = new BrickStringFormat(DevExpress.Drawing.DXStringAlignment.Far); // ⬅️ محاذاة النص إلى اليمين
                    e.Graph.DrawString(headerText, Color.Black, new RectangleF(240, 10, 600, 200), BorderSide.None);

                    // 🔹 رسم مستطيل رمادي خلف العنوان باستخدام DrawRect
                    //RectangleF titleRect = new RectangleF(10, 145, 1050, 40);
                    //e.Graph.DrawRect(titleRect, BorderSide.All, Color.White, Color.White);  // ⬅️ مستطيل رمادي مع حدود سوداء

                    // 🔹 عنوان التقرير (منتصف الصفحة)
                    string title = "قائمة عرض المشتريات من المورد :  " + txtSupplier.Text;
                    e.Graph.Font = new Font("Cairo Medium", 18, FontStyle.Bold);
                    e.Graph.StringFormat = new BrickStringFormat(DevExpress.Drawing.DXStringAlignment.Far); // ⬅️ محاذاة النص إلى اليمين 
                    e.Graph.DrawString(title, Color.Black, new RectangleF(350, 150, 1250, 45), BorderSide.None);
                    //e.Graph.DrawString(title, titleRect);

                    //// 🔹 التاريخ في الزاوية اليمنى
                    string date = "التاريخ : " + DateTime.Now.ToShortDateString();
                    e.Graph.Font = new Font("Cairo Medium", 12);
                    e.Graph.DrawString(date, Color.Black, new RectangleF(10, 170, 250, 30), BorderSide.None);
                };

                // 4️⃣ تعيين إعدادات الورق (A4 - أفقي) مع هوامش إضافية
                printableLink.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4;
                printableLink.Landscape = true;
                printableLink.Margins = new System.Drawing.Printing.Margins(20, 20, 230, 80); // ⬅️ زيادة الهامش العلوي لمنع التداخل
                printableLink.RightToLeftLayout = true; // ⬅️ تفعيل RTL
                // 5️⃣ عرض معاينة الطباعة
                printableLink.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ خطأ أثناء الطباعة: " + ex.Message);
            }
        }

        #endregion

        // Event Load UserControl
        #region
        private void Purchases_SupplierUserControl_Load(object sender, EventArgs e)
        {
            loading.Show();
            // Check if connection is available
            if (_dataHelper.IsDbConnect())
            {
                DateDu.EditValue = new DateTime(DateTime.Now.Year, 1, 1);
                DateAu.EditValue = new DateTime(DateTime.Now.Year, 12, 31);
                // Show Empty Label Data
                ShowLabelIfEmptyData();
            }
            else
            {
                MessageCollection.ShowServerMessage();
            }
            loading.Hide();


        }

        // عند تغير المورد او التاريخ
        private void txtSupplier_SelectedValueChanged(object sender, EventArgs e)
        {
            if (DateDu.Text == string.Empty || DateAu.Text == string.Empty)
            {
                MessageBox.Show("⚠️ الرجاء تحديد التاريخين");
                return;
            }

            int index = _dataHelper.Search(txtSupplier.Text).FirstOrDefault().Id;
            DGListeSupplier.DataSource = GetPurchasesBySupplierAndDate(index, DateTime.Parse(DateDu.Text), DateTime.Parse(DateAu.Text));

            // Set DataGridView Columns
            SetDataGridViewColumns();

            // Show Empty Label Data
            ShowLabelIfEmptyData();


        }
        #endregion

        private void btnPrintSup_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount == 0)
            {
                MessageCollection.ShowEmptyDataMessage();
                return;
            }
            PrintGridControl();
        }
    }
}
