using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vision_Pharmacy.Code;
using Vision_Pharmacy.Core;
using Vision_Pharmacy.Data;
using Vision_Pharmacy.Data.EFSqlServer;
using Vision_Pharmacy.Gui.OtherGui;

namespace Vision_Pharmacy.Gui.EmployeeGui
{
    public partial class FormPayroll : UserControl
    {
        private List<Employees> employees; // قائمة الموظفين
        private List<Attendance> attendance; // قائمة الحضور  
        private List<Payroll> payrollList = new List<Payroll>();
        private readonly IDataHelper<Payroll> _dataHelper;
        private int selectedMonth = DateTime.Now.Month;
        private int selectedYear = DateTime.Now.Year;
        public AllClasses AllClasses = new AllClasses();
        private readonly LoadingUser loading;

        public FormPayroll()
        {
            InitializeComponent();
            loading = LoadingUser.Instance();
            _dataHelper = (IDataHelper<Payroll>)ContainerConfig.ObjectType("Payroll");
        }

        private void FormPayroll_Load(object sender, EventArgs e)
        {
            loading.Show();
            // تعبئة ComboBox بالأشهر (1 إلى 12)
            comboBoxMonth.Items.AddRange(System.Globalization.DateTimeFormatInfo.InvariantInfo.MonthNames.ToArray());//.Take(12).ToArray());
            comboBoxMonth.SelectedIndex =  selectedMonth - 1;
         
            // تعبئة ComboBox بالسنوات (مثلاً: من 2020 إلى السنة الحالية +1)
            for (int year = 2020; year <= DateTime.Now.Year + 1; year++)
                comboBoxYear.Items.Add(year);

            comboBoxYear.SelectedItem = selectedYear;

            // تحميل الموظفين النشطين من قاعدة البيانات
            using (var db = new DBContext())
            {
                employees = db.Employees
                              .Where(e => e.IsActive)
                              .ToList();
            }

            // تهيئة DataSource للـ GridControl إن لزم
            DGListeEmployee.DataSource = null;
            loading.Hide();
        }

        private List<Employees> LoadEmployees()
        {
            using (var db = new DBContext())
            {
                return db.Employees.Where(e => e.IsActive).ToList();
            }
        }

        private void PrintGridControl()
        {
            try
            {
                loading.Show();
                // 1️⃣ إنشاء نظام الطباعة ورابط الطباعة
                PrintingSystem printingSystem = new PrintingSystem();
                PrintableComponentLink printableLink = new PrintableComponentLink(printingSystem)
                {
                    Component = DGListeEmployee
                };

                // 2️⃣ إعداد رأس الصفحة مع النصوص والصورة
                printableLink.CreateMarginalHeaderArea += (sender, e) =>
                {
                    // 🔹 تحميل الصورة (تأكد من تغيير المسار إلى مسار الصورة الصحيح)
                    Image logo = Image.FromFile("LOGO.jpg"); // ⬅️ ضع مسار الصورة الصحيح هنا

                    // 🔹 رسم الصورة في الزاوية اليسرى
                    RectangleF imageRect = new RectangleF(10, 10, 230, 100);
                    e.Graph.DrawImage(logo, imageRect);

                    // 🔹 نصوص الرأس (اسم الشركة والإدارات)
                    string headerText = "صيدلية الشفاء" + "\n" + "العنوان : بغداد - العراق" + "\n" + "الهاتف : 05632135215313\nMAGASIN CENTRAL DU PDR";
                    e.Graph.Font = new Font("Cairo Medium", 12, FontStyle.Bold); // ⬅️ استخدام خط "Cairo Medium"
                    e.Graph.StringFormat = new BrickStringFormat(DevExpress.Drawing.DXStringAlignment.Far); // ⬅️ محاذاة النص إلى اليمين
                    e.Graph.DrawString(headerText, Color.Black, new RectangleF(240, 10, 600, 120), BorderSide.None);

                    // 🔹 رسم مستطيل رمادي خلف العنوان باستخدام DrawRect
                    //RectangleF titleRect = new RectangleF(10, 145, 1050, 40);
                    //e.Graph.DrawRect(titleRect, BorderSide.All, Color.White, Color.White);  // ⬅️ مستطيل رمادي مع حدود سوداء

                    // 🔹 عنوان التقرير (منتصف الصفحة)
                    string title = "قائمة رواتب الموظفين ";
                    e.Graph.Font = new Font("Cairo Medium", 18, FontStyle.Bold);
                    e.Graph.StringFormat = new BrickStringFormat(DevExpress.Drawing.DXStringAlignment.Far); // ⬅️ محاذاة النص إلى اليمين 
                    e.Graph.DrawString(title, Color.Black, new RectangleF(350, 150, 1250, 45), BorderSide.None);
                    //e.Graph.DrawString(title, titleRect);

                    //// 🔹 التاريخ في الزاوية اليمنى
                    string date = "التاريخ : " + DateTime.Now.ToShortDateString();
                    e.Graph.Font = new Font("Cairo Medium", 12);
                    e.Graph.DrawString(date, Color.Black, new RectangleF(750, 150, 200, 30), BorderSide.None);
                };

                // 4️⃣ تعيين إعدادات الورق (A4 - أفقي) مع هوامش إضافية
                printableLink.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4;
                printableLink.Landscape = true;
                printableLink.Margins = new System.Drawing.Printing.Margins(20, 20, 230, 80); // ⬅️ زيادة الهامش العلوي لمنع التداخل
                printableLink.RightToLeftLayout = true; // ⬅️ تفعيل RTL
                loading.Hide();
                // 5️⃣ عرض معاينة الطباعة
                printableLink.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ خطأ أثناء الطباعة: " + ex.Message);
            }
        }

        private List<Attendance> LoadAttendance(int month, int year)
        {
            using (var db = new DBContext())
            {
                return db.Attendance
                         .Where(a => a.Date.Month == month && a.Date.Year == year)
                         .ToList();
            }
        }

        //private void LoadData()
        //{
        //    int month = Convert.ToInt32(comboBoxMonth.SelectedItem);
        //    int year = Convert.ToInt32(comboBoxYear.SelectedItem);

        //    employees = LoadEmployees();
        //    attendance = LoadAttendance(month, year);
        //}

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "ملف PDF|*.pdf";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                DGListeEmployee.ExportToPdf(saveFile.FileName);
                MessageBox.Show("تم تصدير الرواتب إلى PDF", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "BaseSalary" ||
                e.Column.FieldName == "Deductions" ||
                e.Column.FieldName == "NetSalary")
            {
                if (e.Value != null && double.TryParse(e.Value.ToString(), out double val))
                {
                    // فرض تنسيق ثابت مع نقطة عشرية
                    e.DisplayText = val.ToString("#,0.00", System.Globalization.CultureInfo.InvariantCulture);
                }
            }
        }

        private void btnSavePayroll_Click(object sender, EventArgs e)
        {
            using (var db = new DBContext())
            {
                try
                {
                    if (gridView1.RowCount == 0)
                    {
                        MessageBox.Show("لا توجد بيانات لحفظها.", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    loading.Show();
                    // التحقق من وجود رواتب مسجلة مسبقًا
                    foreach (var payroll in payrollList)
                    {
                        // تحقق من وجود راتب سابق لنفس الموظف في نفس الشهر
                        var existingPayroll = db.Payroll.FirstOrDefault(p =>
                            p.EmployeeId == payroll.EmployeeId &&
                            p.Month == payroll.Month &&
                            p.Year == payroll.Year);

                        if (existingPayroll != null)
                        {
                            // عرض رسالة تنبيه للمستخدم
                            var result = MessageBox.Show(
                                $"تم تسجيل راتب سابق للموظف  (ID: {payroll.EmployeeName}) \nلشهر {payroll.Month}/{payroll.Year}.\nهل تريد تعديله؟",
                                "راتب مسجل مسبقًا",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                // تعديل البيانات القديمة
                                existingPayroll.BaseSalary = payroll.BaseSalary;
                                existingPayroll.Deductions = payroll.Deductions;
                                // يمكنك تحديث أي حقول إضافية هنا
                            }
                            else
                            {
                                // تجاهل هذا السطر
                                continue;
                            }
                        }
                        else
                        {
                            // لا يوجد راتب مسجل، نضيفه
                            db.Payroll.Add(payroll);
                        }
                    }
                    loading.Hide();
                    db.SaveChanges();
                    MessageBox.Show("تم حفظ الرواتب في قاعدة البيانات بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show($"حدث خطأ أثناء الحفظ:\n{ex.InnerException?.Message ?? ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCalculatee_Click(object sender, EventArgs e)
        { 
            loading.Show();
            int month = AllClasses.GetMonthNumber(comboBoxMonth.Text);// Convert.ToInt32(comboBoxMonth.SelectedItem);
            int year = Convert.ToInt32(comboBoxYear.SelectedItem);
            int daysInMonth = DateTime.DaysInMonth(year, month);

            DGListeEmployee.DataSource = null;
            DGListeEmployee.Refresh(); // تأكد من تحديث العرض

            using (var db = new DBContext())
            {

                // التحقق هل توجد بيانات حضور لذلك الشهر
                bool hasAttendance = db.Attendance.Any(a => a.Date.Month == month && a.Date.Year == year);

                if (!hasAttendance)
                {
                    MessageBox.Show("لم يتم تسجيل الحضور لهذا الشهر، يرجى تسجيل الحضور أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DGListeEmployee.DataSource = null;
                    DGListeEmployee.Refresh(); // تأكد من تحديث العرض
                    return; // إيقاف المعالجة
                }


                // التحقق من وجود رواتب مسجلة مسبقًا
                bool payrollExists = db.Payroll.Any(p => p.Month == month && p.Year == year);
                if (payrollExists)
                {
                    var result = MessageBox.Show(
                        $"تم حساب رواتب شهر {month}/{year} مسبقًا.\nهل تريد إعادة الحساب؟",
                        "تنبيه",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.No)
                    {
                        payrollList.Clear();
                        DGListeEmployee.DataSource = _dataHelper.GetData();

                        return; // الخروج بدون حساب جديد
                    }
                }

                // إفراغ القائمة الحالية
                payrollList.Clear();

                // تحميل الموظفين النشطين والحضور من قاعدة البيانات
                var employees = db.Employees.Where(e => e.IsActive).ToList();
                var attendance = db.Attendance
                    .Where(a => a.Date.Month == month && a.Date.Year == year)
                    .ToList();


                foreach (var emp in employees)
                {
                    int daysPresent = attendance.Count(a =>
                        a.EmployeeId == emp.Id && a.IsPresent);

                    int daysAbsent = daysInMonth - daysPresent;

                    double dailyRate = emp.Salary / daysInMonth;
                    double deductions = daysAbsent * dailyRate;

                    var payroll = new Payroll
                    {
                        EmployeeId = emp.Id,
                        EmployeeName = emp.FullName,
                        Month = month,
                        Year = year,
                        DaysPresent = daysPresent,
                        DaysAbsent = daysAbsent,
                        BaseSalary = Math.Round(emp.Salary, 2),
                        Deductions = Math.Round(deductions, 2)
                        // NetSalary محسوب تلقائي من الخاصية
                    };

                    payrollList.Add(payroll);
                }
                loading.Hide();
                DGListeEmployee.DataSource = payrollList;
            }
        }

        private void btnPrintPayroll_Click(object sender, EventArgs e)
        {
            PrintGridControl();
        }
    }
}
