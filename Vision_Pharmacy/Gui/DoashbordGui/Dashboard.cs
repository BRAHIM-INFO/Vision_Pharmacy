using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Design;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using Vision_Pharmacy.Code;
using Vision_Pharmacy.Core;
using Vision_Pharmacy.Data;
using Vision_Pharmacy.Data.EFSqlServer;
using Vision_Pharmacy.Gui.OtherGui;

namespace Vision_Pharmacy.Gui.DoashbordGui
{
    public partial class Dashboard : DevExpress.XtraEditors.XtraUserControl
    {
        // Fields
        private IDataHelper<Purchase> _dataHelperPurchase;
        private IDataHelper<Employees> _dataHelperEmployees;
        private AttendanceEntity AttendanceEntity;
        AllClasses AllClasses = new AllClasses();
        private readonly LoadingUser loading;
        private Label labelEmptyData;


        public Dashboard()
        {
            InitializeComponent();
            loading = LoadingUser.Instance();
            AttendanceEntity = new AttendanceEntity();
            _dataHelperPurchase = (IDataHelper<Purchase>)ContainerConfig.ObjectType("Purchase");
            _dataHelperEmployees = (IDataHelper<Employees>)ContainerConfig.ObjectType("Employees");
            labelEmptyData = ComponentsObject.Instance().LabelEmptyData();
            // إعدادات أولية للنموذج
            AllClasses.RoundPanelCorners(PnlClients, 25); // 15 مثل bunifu
            AllClasses.RoundPanelCorners(pnl_Session, 25); // 15 مثل bunifu
            AllClasses.RoundPanelCorners(pnl_Cases, 25); // 15 مثل bunifu
            AllClasses.RoundPanelCorners(pnl_RH, 25); // 15 مثل bunifu
        }

        //كثر 5 موظفين غيابًا
        private void LoadTopAbsentees(DateTime startDate, DateTime endDate)
        {
            var employees = _dataHelperEmployees.GetData();
            var attendanceList = AttendanceEntity.GetData();

            var filteredAttendance = attendanceList
                .Where(a => a.Date >= startDate && a.Date <= endDate)
                .ToList();

            var absences = filteredAttendance
                .Where(a => !a.IsPresent)
                .GroupBy(a => a.EmployeeId)
                .Select(g => new
                {
                    EmployeeId = g.Key,
                    AbsenceCount = g.Count()
                })
                .OrderByDescending(x => x.AbsenceCount)
                .Take(5)
                .ToList();

            var topAbsentees = absences
                .Join(employees,
                      a => a.EmployeeId,
                      e => e.Id,
                      (a, e) => new { e.FullName, a.AbsenceCount })
                .ToList();

            chartControl6.Series.Clear();
            Series series = new Series("أكثر الموظفين غيابًا", ViewType.Bar);

            foreach (var item in topAbsentees)
                series.Points.Add(new SeriesPoint(item.FullName, item.AbsenceCount));

            chartControl6.Series.Add(series);

            BarSeriesLabel label = (BarSeriesLabel)series.Label;
            label.Visible = true;
            label.TextPattern = "{V}";

            XYDiagram diagram = (XYDiagram)chartControl6.Diagram;
            diagram.Rotated = true;

            //chartControl6.Titles.Clear();
            //chartControl6.Titles.Add(new ChartTitle()
            //{
            //    Text = $"أكثر 5 موظفين غيابًا - {startDate:dd/MM/yyyy} → {endDate:dd/MM/yyyy}",
            //    Font = new System.Drawing.Font("Tahoma", 11, System.Drawing.FontStyle.Bold)
            //});
        }

        //كثر 5 موظفين حظورا
        private void LoadTopPresent(DateTime startDate, DateTime endDate)
        {
            var employees = _dataHelperEmployees.GetData();
            var attendanceList = AttendanceEntity.GetData();

            if (employees == null || employees.Count == 0 || attendanceList == null || attendanceList.Count == 0)
                return;

            // فلترة الحضور ضمن الفترة
            var filtered = attendanceList
                .Where(a => a.Date >= startDate && a.Date <= endDate)
                .ToList();

            if (!filtered.Any())
                return;

            // حساب عدد أيام الحضور لكل موظف
            var presentCounts = filtered
                .Where(a => a.IsPresent)
                .GroupBy(a => a.EmployeeId)
                .Select(g => new
                {
                    EmployeeId = g.Key,
                    PresentCount = g.Count()
                })
                .OrderByDescending(x => x.PresentCount)
                .Take(5)
                .ToList();

            // ربط الأسماء
            var topPresent = presentCounts
                .Join(employees,
                      p => p.EmployeeId,
                      e => e.Id,
                      (p, e) => new { e.FullName, p.PresentCount })
                .ToList();

            // رسم الـ Bar Chart أفقي على chartControl7
            chartControl7.Series.Clear();
            var series = new Series("أكثر الموظفين حضورًا", ViewType.Bar);

            // ألوان مخصصة اختيارية
            Color[] colors = { Color.SeaGreen, Color.SteelBlue, Color.Goldenrod, Color.MediumOrchid, Color.Tomato };
            int i = 0;

            foreach (var item in topPresent)
            {
                var point = new SeriesPoint(item.FullName, item.PresentCount);
                point.Color = colors[i % colors.Length];
                series.Points.Add(point);
                i++;
            }

            // إظهار القيم فوق الأعمدة
            series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            var lbl = (BarSeriesLabel)series.Label;
            lbl.TextPattern = "{V}"; // عدد أيام الحضور

            chartControl7.Series.Add(series);

            // أفقي + تنسيق المحاور
            var diagram = (XYDiagram)chartControl7.Diagram;
            diagram.Rotated = true;
            diagram.AxisX.Title.Text = "عدد أيام الحضور";
            diagram.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            diagram.AxisY.Title.Text = "الموظفون";
            diagram.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;

            // عنوان يوضح الفترة
            chartControl7.Titles.Clear();
            chartControl7.Titles.Add(new ChartTitle
            {
                Text = $"أكثر 5 موظفين حضورًا - {startDate:dd/MM/yyyy} → {endDate:dd/MM/yyyy}",
                Font = new Font("Tahoma", 11, FontStyle.Bold)
            });
        }

        //إحصائيات الحضور والغياب نسبة الحضور العامة
        private void LoadAttendanceStats()
        {
            // 1. جلب كل سجلات الحضور
            var attendanceList = AttendanceEntity.GetData();// GetAll<Attendance>();

            if (attendanceList == null || attendanceList.Count == 0)
                return;

            // 2. حساب عدد الحضور والغياب
            int totalPresent = attendanceList.Count(a => a.IsPresent);
            int totalAbsent = attendanceList.Count(a => !a.IsPresent);

            int totalDays = totalPresent + totalAbsent;

            double attendanceRate = totalDays > 0 ? (totalPresent * 100.0 / totalDays) : 0;

            // 3. تجهيز بيانات Pie Chart
            chartControl5.Series.Clear();
            Series series = new Series("إحصائيات الحضور", ViewType.Pie);

            series.Points.Add(new SeriesPoint("حضور", totalPresent));
            series.Points.Add(new SeriesPoint("غياب", totalAbsent));

            chartControl5.Series.Add(series);

            // 4. تنسيقات العرض
            PieSeriesLabel label = (PieSeriesLabel)series.Label;
            label.TextPattern = "{A}: {VP:p0}"; // A = اسم, VP = نسبة مئوية

            PieSeriesView view = (PieSeriesView)series.View;
            view.ExplodeMode = PieExplodeMode.All; // يبرز القطع
            view.RuntimeExploding = true;

            // 5. إضافة عنوان للنسبة العامة
            chartControl5.Titles.Clear();
            chartControl5.Titles.Add(new ChartTitle()
            {
                Text = $"نسبة  حضور الموظفين العامة: \n {attendanceRate:F2} %",
                Font = new System.Drawing.Font("Cairo Medium", 12, System.Drawing.FontStyle.Bold)
            });
        }

        //عدد الفواتير لكل مورد
        private void NumberInvoicesSupplier()
        {
            // جلب البيانات
            var purchases = _dataHelperPurchase.GetData();

            // تجميع حسب اسم المورد
            var supplierFactures = purchases
                .GroupBy(p => p.SupplierName)
                .Select(g => new
                {
                    SupplierName = g.Key,
                    CountFactures = g.Select(x => x.FactureNum).Distinct().Count()
                })
                .ToList();

            // مسح أي بيانات سابقة
            chartControl1.Series.Clear();

            // إنشاء سلسلة (أعمدة Bar)
            Series series = new Series("عدد الفواتير لكل مورد", ViewType.Bar);

            int colorIndex = 0;
            Color[] palette = { Color.DodgerBlue, Color.Firebrick, Color.Green, Color.Orange, Color.Purple, Color.Teal };


            // إضافة النقاط (اسم المورد = المحور X ، عدد الفواتير = المحور Y)
            foreach (var stat in supplierFactures)
            {
                var point = new SeriesPoint(stat.SupplierName, stat.CountFactures);
                series.Points.Add(point);

                //series.Points.Add(new SeriesPoint(stat.SupplierName, stat.CountFactures));
                // إعطاء لون مختلف لكل عمود
                point.Color = palette[colorIndex % palette.Length];
                colorIndex++;
            }

            // كل مورد يظهر بلون مختلف
            series.LegendTextPattern = "{A}"; // يظهر اسم المورد في الليجند
            series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True; // عرض القيم فوق الأعمدة

            // إضافة السلسلة للرسم البياني
            chartControl1.Series.Add(series);

            // إعدادات إضافية للرسم
            XYDiagram diagram = chartControl1.Diagram as XYDiagram;
            if (diagram != null)
            {
                diagram.AxisX.Label.Angle = -45; // ميل الكتابة
                diagram.AxisX.Title.Text = "الموردين";
                diagram.AxisY.Title.Text = "عدد الفواتير";
            }

            // تعيين العنوان العام للرسم
            chartControl1.Titles.Clear();
            chartControl1.Titles.Add(new ChartTitle()
            {
                Text = "عدد الفواتير لكل مورد",
                Font = new Font("Cairo Medium", 12, FontStyle.Bold)
            });
        }

        //مبالغ كل مورد
        private void AmountInvoicesSupplier()
        {
            // جلب البيانات
            var purchases = _dataHelperPurchase.GetData();

            // تجميع حسب اسم المورد
            var supplierStats = purchases
                .GroupBy(p => p.SupplierName)
                .Select(g => new
                {
                    SupplierName = g.Key,
                    TotalAmount = g.Sum(x => x.TotalAmount)
                })
                .ToList();

            // مسح أي بيانات سابقة
            chartControl2.Series.Clear();

            // إنشاء سلسلة Pie
            Series series = new Series("مبالغ الموردين", ViewType.Pie);

            // إضافة النقاط (المورد + المبلغ)
            foreach (var stat in supplierStats)
            {
                series.Points.Add(new SeriesPoint(stat.SupplierName, stat.TotalAmount));
            }

            // تفعيل عرض النسبة والمبلغ
            PieSeriesLabel label = (PieSeriesLabel)series.Label;
            label.TextPattern = "{A}  \n {V:N2} \n ({VP:P0})";
            // {A}=اسم المورد, {V}=القيمة, {VP}=النسبة %

            series.LegendTextPattern = "{A}";

            // إضافة السلسلة للرسم
            chartControl2.Series.Add(series);

            // تنسيق العنوان
            chartControl2.Titles.Clear();
            chartControl2.Titles.Add(new ChartTitle()
            {
                Text = "توزيع مبالغ الموردين",
                Font = new Font("Cairo Medium", 12, FontStyle.Bold)
            });
        }

        //أفضل الأدوية مبيعًا (Top 10)
        private void TopSellingMedicines()
        {
            try
            {
                // 1) جلب كل المبيعات من قاعدة البيانات
                var purchases = _dataHelperPurchase.GetData();

                // 2) حساب أفضل 10 أدوية حسب إجمالي الكمية المباعة
                var topProducts = purchases
                    .GroupBy(p => p.Barcode) // تجميع حسب الباركود
                    .Select(g => new
                    {
                        Product = g.First().SupplierName + " - " + g.Key, // اسم الدواء (أو استعمل حقل Name إذا عندك)
                        TotalQuantity = g.Sum(x => x.Quantity)
                    })
                    .OrderByDescending(x => x.TotalQuantity)
                    .Take(10) // فقط أفضل 10
                    .ToList();

                // 3) تنظيف الرسم السابق
                chartControl3.Series.Clear();

                // 4) إنشاء Series
                Series series = new Series("Top 10 Medications", ViewType.Bar);

                var customColors = new System.Drawing.Color[]
                {
                  System.Drawing.Color.Red,
                  System.Drawing.Color.Green,
                  System.Drawing.Color.Blue,
                  System.Drawing.Color.Orange,
                  System.Drawing.Color.Purple,
                  System.Drawing.Color.Teal,
                  System.Drawing.Color.Brown,
                  System.Drawing.Color.Magenta,
                  System.Drawing.Color.DarkCyan,
                  System.Drawing.Color.Gold
                };

                int i = 0;
                foreach (var item in topProducts)
                {
                    var point = new SeriesPoint(item.Product, item.TotalQuantity);
                    point.Color = customColors[i % customColors.Length]; // ⬅️ يختار اللون حسب الترتيب
                    series.Points.Add(point);
                    i++;
                }

                foreach (var item in topProducts)
                {
                    series.Points.Add(new SeriesPoint(item.Product, item.TotalQuantity));
                }

                chartControl3.Series.Add(series);

                // 5) جعل المخطط أفقي (Bar Chart أفقي)
                XYDiagram diagram = (XYDiagram)chartControl3.Diagram;
                diagram.Rotated = true;

                // 6) تخصيص عرض الأعمدة
                BarSeriesView view = (BarSeriesView)series.View;
                view.BarWidth = 0.6; // كلما كبرت القيمة، كلما صار العمود أعرض

                // 7) تحسين عرض النصوص على المحور
                diagram.AxisX.Label.Angle = -45; // لف الأسماء قليلاً
                diagram.AxisX.Label.ResolveOverlappingOptions.AllowRotate = true;
                diagram.AxisX.Label.ResolveOverlappingOptions.AllowStagger = true;

                // 8) عنوان الرسم
                chartControl3.Titles.Clear();
                chartControl3.Titles.Add(new ChartTitle()
                {
                    Text = "أفضل 10 أدوية مبيعًا",
                    Font = new System.Drawing.Font("Cairo Medium", 12, System.Drawing.FontStyle.Bold)
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ أثناء تحميل الإحصائيات: " + ex.Message);
            }
        }

        //إحصائية المبيعات الشهرية
        private void LoadMonthlySales()
        {
            // 1) جلب البيانات من قاعدة البيانات
            var purchases = _dataHelperPurchase.GetData();

            // 2) تجميع المبيعات حسب الشهر
            var monthlySales = purchases
                .GroupBy(p => new { p.FactureDate.Year, p.FactureDate.Month })
                .Select(g => new
                {
                    Year = g.Key.Year,
                    Month = g.Key.Month,
                    TotalSales = g.Sum(p => p.TotalAmount)
                })
                .OrderBy(x => x.Year).ThenBy(x => x.Month)
                .ToList();

            // 3) تنظيف المخطط
            chartControl4.Series.Clear();

            // 4) إنشاء Series (عمودي)
            Series series = new Series("المبيعات الشهرية", ViewType.Bar);

            foreach (var item in monthlySales)
            {
                string monthName = new DateTime(item.Year, item.Month, 1).ToString("MMM yyyy");
                series.Points.Add(new SeriesPoint(monthName, item.TotalSales));
            }

            // 5) إعداد العرض
            series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            ((BarSeriesLabel)series.Label).TextPattern = "{V:n0}"; // عرض القيمة بصيغة رقمية مع الفواصل

            // 6) إضافة Series للمخطط
            chartControl4.Series.Add(series);

            // 7) تخصيص المحاور
            XYDiagram diagram = (XYDiagram)chartControl4.Diagram;
            diagram.AxisX.Title.Text = "الشهور";
            diagram.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            diagram.AxisY.Title.Text = "إجمالي المبيعات";
            diagram.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            diagram.AxisY.Label.TextPattern = "{V:n0}"; // أرقام منسقة
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "أهلاً " + Properties.Settings.Default.User + "، مرحباً بعودتك!";
            timer1.Interval = 1000; // كل ثانية
            timer1.Tick += timer1_Tick;
            timer1.Start();
            NumberInvoicesSupplier();
            AmountInvoicesSupplier();
            TopSellingMedicines();
            LoadMonthlySales();
            LoadAttendanceStats();


            // ربطه بالـ Popup
            popupEdit.Properties.PopupControl = popup;

            // عند تغيير الاختيار
            calendarControl1.SelectionChanged += (s, e) =>
            {
                if (calendarControl1.SelectedRanges.Count > 0)
                {
                    var range = calendarControl1.SelectedRanges[0];
                    popupEdit.EditValue = $"{range.StartDate.ToShortDateString()} → {range.EndDate.ToShortDateString()}";
                    LoadTopAbsentees(range.StartDate, range.EndDate);
                    LoadTopPresent(range.StartDate, range.EndDate);
                    comboPeriod05Low.Text = "فترة محددة"; // لتوضيح أنه تم اختيار فترة مخصصة
                }
            };

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTimerClock.Text = DateTime.Now.ToString("HH:mm:ss");
            // صيغة 24 ساعة - إذا تحب 12 ساعة مع AM/PM استعمل "hh:mm:ss tt"
            txtdate.Text = DateTime.Now.ToString("yyyy-MM-dd"); //"dddd, dd MMMM yyyy HH:mm:ss",
                                                                //new System.Globalization.CultureInfo("ar-DZ"));
                                                                // مثال: الاثنين، 18 أغسطس 2025 14:35:12
        }

        private void comboPeriod05Low_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime startDate = DateTime.MinValue;
            DateTime endDate = DateTime.MaxValue;

            switch (comboPeriod05Low.SelectedItem.ToString())
            {
                case "اخر 30 يوم":
                    endDate = DateTime.Today;
                    startDate = endDate.AddDays(-30);
                    popupEdit.Text = string.Empty; // مسح النص في حالة اختيار فترة جاهزة
                    break;

                case "الشهر الماضي":
                    var prevMonth = DateTime.Today.AddMonths(-1);
                    startDate = new DateTime(prevMonth.Year, prevMonth.Month, 1);
                    endDate = startDate.AddMonths(1).AddDays(-1);
                    popupEdit.Text = string.Empty; // مسح النص في حالة اختيار فترة جاهزة
                    break;

                case "الشهر الحالي":
                    var currentMonth = DateTime.Today;
                    startDate = new DateTime(currentMonth.Year, currentMonth.Month, 1);
                    endDate = startDate.AddMonths(1).AddDays(-1);
                    popupEdit.Text = string.Empty; // مسح النص في حالة اختيار فترة جاهزة
                    break;

                case "العام الماضي":
                    int lastYear = DateTime.Today.Year - 1;
                    startDate = new DateTime(lastYear, 1, 1);
                    endDate = new DateTime(lastYear, 12, 31);
                    popupEdit.Text = string.Empty; // مسح النص في حالة اختيار فترة جاهزة
                    break;

                case "العام الحاالي":
                    int thisYear = DateTime.Today.Year;
                    startDate = new DateTime(thisYear, 1, 1);
                    endDate = new DateTime(thisYear, 12, 31);
                    popupEdit.Text = string.Empty; // مسح النص في حالة اختيار فترة جاهزة
                    break;

                //case "فترة محددة":
                //    using (var frm = new DateRangeForm()) // ⬅️ لازم تعمل فورم فيه DateEdit من–إلى
                //    {
                //        if (frm.ShowDialog() == DialogResult.OK)
                //        {
                //            startDate = frm.StartDate;
                //            endDate = frm.EndDate;
                //        }
                //        else
                //        {
                //            return; // ما اختارش فترة
                //        }
                //    }
                //    break;
            }
            LoadTopPresent(startDate, endDate);
            LoadTopAbsentees(startDate, endDate);
        }
    }
}
