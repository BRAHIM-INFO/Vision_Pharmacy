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

namespace Vision_Pharmacy.Gui.MedicationGui
{
    public partial class ExpiredUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        // Fields
        private readonly IDataHelper<Medication> _dataHelper;
        private readonly LoadingUser loading;
        private string _fullText = "قائمة الأدوية المنتهية الصلاحية";
        private int _currentIndex = 0;
        DateTime startDate;
        DateTime endDate;

        public ExpiredUserControl()
        {
            InitializeComponent();
            loading = LoadingUser.Instance();
            _dataHelper = (IDataHelper<Medication>)ContainerConfig.ObjectType("Medication");
             
        }

        private void ExpiredUserControl_Load(object sender, EventArgs e)
        {

            // نفترض عندك قائمة الأدوية المنتهية
            var expiredMeds = _dataHelper.GetData()
                .Where(m => m.ExpiryDate <= DateTime.Now)
                .ToList();

            DGListeMedication.DataSource = expiredMeds;
            SetDataGridViewColumns(); 
        }
         
        private void SetDataGridViewColumns()
        {
            try
            {
                gridView1.Columns[0].Visible = false; // Hide Column
                gridView1.Columns[1].Caption = "باركود الدواء";
                gridView1.Columns[2].Caption = "اسم الدواء";
                gridView1.Columns[3].Caption = "الاسم العلمي";
                gridView1.Columns[4].Visible = false; // Hide Column
                gridView1.Columns[5].Caption = "رقم الدفعة";
                gridView1.Columns[6].Visible = false; // Hide Column
                gridView1.Columns[7].Visible = false; // Hide Column
                gridView1.Columns[8].Visible = false; // Hide Column
                gridView1.Columns[9].Visible = false; // Hide Column
                gridView1.Columns[10].Visible = false; // Hide Column
                gridView1.Columns[11].Visible = false; // Hide Column
                gridView1.Columns[12].Caption = "الكمية";
                gridView1.Columns[13].Visible = false; // Hide Column
                gridView1.Columns[14].Visible = false; // Hide Column
                gridView1.Columns[15].Caption = "تاريخ انتهاء الصلاحية";
                gridView1.Columns[16].Visible = false; // Hide Column
                gridView1.Columns[17].Visible = false; // Hide Column
                gridView1.Columns[18].Visible = false; // Hide Column
                gridView1.Columns[19].Visible = false; // Hide Column
                gridView1.Columns[20].Visible = false; // Hide Column
                gridView1.Columns[21].Visible = false; // Hide Column
                gridView1.Columns[22].Visible = false; // Hide Column
                gridView1.Columns[23].Visible = false; // Hide Column
                gridView1.Appearance.Row.ForeColor = Color.Red;
            }
            catch
            {
                // تجاهل الخطأ (يفضل تسجيله)
            }
            // Hide Columns
        }

        private void comboBoxExpiry_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            startDate = today;
            endDate   = today;

            switch (comboBoxExpiry.SelectedItem.ToString())
            {
                case "اخر 30 يوم":
                    startDate = today.AddDays(-30);
                    endDate = today;
                    break;

                case "الشهر الماضي":
                    startDate = new DateTime(today.Year, today.Month, 1).AddMonths(-1);
                    endDate = new DateTime(today.Year, today.Month, 1).AddDays(-1);
                    break;

                case "الشهر الحالي":
                    startDate = new DateTime(today.Year, today.Month, 1);
                    endDate = startDate.AddMonths(1).AddDays(-1);
                    break;

                case "العام الماضي":
                    startDate = new DateTime(today.Year - 1, 1, 1);
                    endDate = new DateTime(today.Year - 1, 12, 31);
                    break;

                case "العام الحالي":
                    startDate = new DateTime(today.Year, 1, 1);
                    endDate = new DateTime(today.Year, 12, 31);
                    break;

                case "يوم محدد":

                    startDate = dateTimeExpired.Value;//.DateTime.Date;
                    endDate = dateTimeExpired.Value;//.DateTime.Date;  
                    break;
            }

            // 🔎 جلب الأدوية المنتهية في الفترة
            var expiredMeds = _dataHelper.GetData()
                .Where(m => m.ExpiryDate.Date >= startDate && m.ExpiryDate.Date <= endDate)
                .ToList();

            // عرض في GridControl
            DGListeMedication.DataSource = expiredMeds;
            SetDataGridViewColumns();

            if (expiredMeds.Count > 0)
                // تحديث العنوان
                labelExpired.Text = $"الأدوية المنتهية بين {startDate:dd-MM-yyyy} و {endDate:dd-MM-yyyy}   =   {expiredMeds.Count} أدوية";
            else
                labelExpired.Text = " لا يوجد أدوية منتهية الصلاحية في هذه الفترة ";
        }

        private void dateTimeExpired_ValueChanged(object sender, EventArgs e)
        {
            comboBoxExpiry.Text = "فترة محددة";
            // 🔎 جلب الأدوية المنتهية في الفترة
            var expiredMeds = _dataHelper.GetData()
                .Where(m => m.ExpiryDate.Date >= DateTime.Parse(dateTimeExpired.Value.ToString("dd-MM-yyyy")) && m.ExpiryDate.Date <= dateTimeExpired.Value.Date)
                .ToList();

            // عرض في GridControl
            DGListeMedication.DataSource = expiredMeds;
            SetDataGridViewColumns();

            if (expiredMeds.Count > 0)
                // تحديث العنوان
                labelExpired.Text = $"الأدوية المنتهية بين {dateTimeExpired.Value:dd-MM-yyyy} و {dateTimeExpired.Value:dd-MM-yyyy}   =   {expiredMeds.Count} أدوية";
            else
                labelExpired.Text = " لا يوجد أدوية منتهية الصلاحية في هذه الفترة ";
        }

        private void btnPrintMedic_Click(object sender, EventArgs e)
        {
            PrintGridControl();
        }

        private void PrintGridControl()
        {
            try
            {
                // 1️⃣ إنشاء نظام الطباعة ورابط الطباعة
                PrintingSystem printingSystem = new PrintingSystem();
                PrintableComponentLink printableLink = new PrintableComponentLink(printingSystem)
                {
                    Component = DGListeMedication
                };

                // 2️⃣ إعداد رأس الصفحة مع النصوص والصورة
                printableLink.CreateMarginalHeaderArea += (sender, e) =>
                {
                    // 🔹 تحميل الصورة (تأكد من تغيير المسار إلى مسار الصورة الصحيح)
                    Image logo = Properties.Resources.logo_2025; // ⬅️ ضع مسار الصورة الصحيح هنا

                    // 🔹 رسم الصورة في الزاوية اليسرى
                    RectangleF imageRect = new RectangleF(10, 10, 230, 150);
                    e.Graph.DrawImage(logo, imageRect);

                    // 🔹 نصوص الرأس (اسم الشركة والإدارات)
                    string headerText = Properties.Settings.Default.CompanyName + "\n" + Properties.Settings.Default.CompanyAdress + "\n" + Properties.Settings.Default.CompanyEmail + "\n" + " رقم الهاتف : " + Properties.Settings.Default.CompanyTel;
                    e.Graph.Font = new Font("Cairo Medium", 12, FontStyle.Bold); // ⬅️ استخدام خط "Cairo Medium"
                    e.Graph.StringFormat = new BrickStringFormat(DevExpress.Drawing.DXStringAlignment.Far); // ⬅️ محاذاة النص إلى اليمين
                    e.Graph.DrawString(headerText, Color.Black, new RectangleF(240, 10, 600, 120), DevExpress.XtraPrinting.BorderSide.None);

                    // 🔹 رسم مستطيل رمادي خلف العنوان باستخدام DrawRect
                    //RectangleF titleRect = new RectangleF(10, 145, 1050, 40);
                    //e.Graph.DrawRect(titleRect, BorderSide.All, Color.White, Color.White);  // ⬅️ مستطيل رمادي مع حدود سوداء

                    // 🔹 عنوان التقرير (منتصف الصفحة)
                    string title = $"قائمة الأدوية المنتهية الصلاحية بين {startDate:dd-MM-yyyy} و {endDate:dd-MM-yyyy}";
                    e.Graph.Font = new Font("Cairo Medium", 18, FontStyle.Bold);
                    e.Graph.StringFormat = new BrickStringFormat(DevExpress.Drawing.DXStringAlignment.Far); // ⬅️ محاذاة النص إلى اليمين 
                    e.Graph.DrawString(title, Color.Black, new RectangleF(350, 150, 1250, 45), DevExpress.XtraPrinting.BorderSide.None);
                    //e.Graph.DrawString(title, titleRect);

                    //// 🔹 التاريخ في الزاوية اليمنى
                    string date = "التاريخ : " + DateTime.Now.ToShortDateString();
                    e.Graph.Font = new Font("Cairo Medium", 12);
                    e.Graph.DrawString(date, Color.Black, new RectangleF(10, 170, 250, 30), DevExpress.XtraPrinting.BorderSide.None);
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
    }
}
