using DevExpress.CodeParser;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vision_Pharmacy.Code;
using Vision_Pharmacy.Core;
using Vision_Pharmacy.Data.EFSqlServer;
using Vision_Pharmacy.Gui.OtherGui;
namespace Vision_Pharmacy.Gui.EmployeeGui
{
    public partial class FormAttendance : UserControl
    {
        private int selectedMonth = DateTime.Now.Month;
        private int selectedYear = DateTime.Now.Year;
        private DataTable attendanceTable;
        public AllClasses AllClasses = new AllClasses();
        private readonly LoadingUser loading;
        public FormAttendance()
        {
            InitializeComponent(); 
            loading = LoadingUser.Instance();
            LoadMonthYearSelectors(); 
            LoadAttendanceData(AllClasses.GetEnglishMonthName(DateTime.Now.Month), selectedYear); 
        }

        //Method
        #region
        private void LoadMonthYearSelectors()
        {
            comboBoxMonth.Items.AddRange(System.Globalization.DateTimeFormatInfo.InvariantInfo.MonthNames.ToArray());//.Take(12).ToArray());
            // comboBoxMonth.SelectedIndex = selectedMonth - 1;
            comboBoxMonth.Text = AllClasses.GetEnglishMonthName(selectedMonth - 1);

            for (int year = 2020; year <= DateTime.Now.Year + 1; year++)
                comboBoxYear.Items.Add(year);
            comboBoxYear.SelectedItem = selectedYear;
        }

        private async void LoadAttendanceData(string _Month, int _Year)
        { 
            selectedMonth = AllClasses.GetMonthNumber(_Month);// comboBoxMonth.SelectedIndex + 1;
            selectedYear = _Year; // Convert.ToInt32(comboBoxYear.SelectedItem);
           
            attendanceTable = new DataTable();
            attendanceTable.Columns.Add("Id_Emp", typeof(int));
            attendanceTable.Columns.Add("Name_Emp", typeof(string));

            int daysInMonth = DateTime.DaysInMonth(selectedYear, selectedMonth);
            for (int day = 1; day <= daysInMonth; day++)
            {
                attendanceTable.Columns.Add(day.ToString("00"), typeof(bool));
            }

            attendanceTable.Columns.Add("Presents", typeof(int));
            attendanceTable.Columns.Add("TotalDays", typeof(int));
            attendanceTable.Columns.Add("Attendance%", typeof(string));
            var employees = new EmployeeEntity().GetData().Where(e => e.IsActive).ToList();
            var records = new AttendanceEntity().GetByMonth(selectedMonth, selectedYear);

            foreach (var emp in employees)
            {
                DataRow row = attendanceTable.NewRow();
                row["Id_Emp"] = emp.Id;
                row["Name_Emp"] = emp.FullName;

                int presentCount = 0;

                for (int day = 1; day <= daysInMonth; day++)
                {
                    DateTime date = new DateTime(selectedYear, selectedMonth, day);
                    bool present = records.Any(r => r.EmployeeId == emp.Id && r.Date.Date == date && r.IsPresent);
                    row[day.ToString("00")] = present;
                    if (present) presentCount++;
                }

                row["Presents"] = presentCount;
                row["TotalDays"] = daysInMonth;
                row["Attendance%"] = $"{(presentCount * 100) / daysInMonth}%";

                attendanceTable.Rows.Add(row);
            }

            DGListeEmployee.DataSource = attendanceTable;

            // Apply CheckEdit to day columns
            ApplyCheckboxColumns(daysInMonth);
             
        }

        private void ApplyCheckboxColumns(int daysInMonth)
        {
            GridView view = gridView2;

            int visibleIndex = 0;

            for (int day = 1; day <= 31; day++)
            {
                string colName = day.ToString("00");

                if (view.Columns[colName] == null)
                {
                    // أضف العمود إلى GridView إن لم يكن موجودًا
                    GridColumn col = new GridColumn();
                    col.FieldName = colName;
                    col.Caption = colName;
                    col.Visible = true;

                    RepositoryItemCheckEdit checkEdit = new RepositoryItemCheckEdit();
                    DGListeEmployee.RepositoryItems.Add(checkEdit);
                    col.ColumnEdit = checkEdit;

                    view.Columns.Add(col);
                }

                if (view.Columns[colName] != null)
                {
                    if (day <= daysInMonth)
                    {
                        view.Columns[colName].Visible = true;
                        view.Columns[colName].Width = 20;
                        view.Columns[colName].VisibleIndex = visibleIndex++;
                    }
                    else
                    {
                        view.Columns[colName].Visible = false;
                    }
                }
            }

            // بعد الأيام، نضع أعمدة المعلومات الأخرى بترتيب واضح
            if (view.Columns["Presents"] != null)
            {
                view.Columns["Presents"].Caption = "عدد الحضور";
                view.Columns["Presents"].VisibleIndex = visibleIndex++;
            }
            if (view.Columns["TotalDays"] != null)
            {
                view.Columns["TotalDays"].Caption = "أيام الشهر";
                view.Columns["TotalDays"].VisibleIndex = visibleIndex++;
            }
            if (view.Columns["Attendance%"] != null)
            {
                view.Columns["Attendance%"].Caption = "نسبة الحضور";
                view.Columns["Attendance%"].VisibleIndex = visibleIndex++;
            }
            if (view.Columns["Id_Emp"] != null)
            {
                view.Columns["Id_Emp"].Caption = "المعرف";
                view.Columns["Id_Emp"].VisibleIndex = 0; // دائمًا أول عمود
            }
            if (view.Columns["Name_Emp"] != null)
            {
                view.Columns["Name_Emp"].Caption = "اسم الموظف";
                view.Columns["Name_Emp"].VisibleIndex = 1;
            }
        }


        //private void ApplyCheckboxColumns(int daysInMonth)
        //{
        //    GridView view = gridView2;

        //    إنشاء أو تحديث أعمدة الأيام من 01 إلى 31
        //    for (int day = 1; day <= 31; day++)
        //    {
        //        string colName = day.ToString("00");

        //        محاولة جلب العمود
        //       GridColumn col = view.Columns.ColumnByFieldName(colName);
        //        if (col != null) col.Width = 25;
        //        if (col == null)
        //        {
        //            col = new GridColumn
        //            {
        //                FieldName = colName,
        //                Caption = colName,
        //                Width = 20,
        //                OptionsColumn = { AllowEdit = true }
        //            };

        //            تحقق من وجود محرر CheckEdit، أضفه إن لم يكن موجودًا
        //           var checkEdit = DGListeEmployee.RepositoryItems
        //               .OfType<RepositoryItemCheckEdit>()
        //               .FirstOrDefault();

        //            if (checkEdit == null)
        //            {
        //                checkEdit = new RepositoryItemCheckEdit();
        //                DGListeEmployee.RepositoryItems.Add(checkEdit);
        //            }

        //            col.ColumnEdit = checkEdit;
        //            view.Columns.Add(col);
        //        }

        //        إظهار أو إخفاء العمود حسب عدد أيام الشهر
        //        col.Visible = day <= daysInMonth;
        //    }

        //    // تعريب الأعمدة الأساسية الأخرى
        //    view.Columns["Id_Emp"].Caption = "المعرف";
        //    view.Columns["Name_Emp"].Caption = "اسم الموظف";
        //    view.Columns["Presents"].Caption = "عدد الحضور";
        //    view.Columns["TotalDays"].Caption = "أيام الشهر";
        //    view.Columns["Attendance%"].Caption = "نسبة الحضور";
        //}

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
                    string title = "قائمة  الحضور و غيابات الموظفين ";
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
        #endregion

        //Event Handlers
        #region
        private void btnSaveAttend_Click(object sender, EventArgs e)
        {
            loading.Show();
            AttendanceEntity entity = new AttendanceEntity();
            foreach (DataRow row in attendanceTable.Rows)
            {
                int empId = Convert.ToInt32(row["Id_Emp"]);
                for (int day = 1; day <= DateTime.DaysInMonth(selectedYear, selectedMonth); day++)
                {
                    string colName = day.ToString("00");
                    DateTime date = new DateTime(selectedYear, selectedMonth, day);
                    bool present = row[colName] != DBNull.Value && Convert.ToBoolean(row[colName]);

                    entity.SaveOrUpdate(empId, date, present);
                }
            }
            loading.Hide();
            MessageBox.Show("تم حفظ الحضور بنجاح.");
        }

        private   void comboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            loading.Show();
            if (comboBoxMonth.Text != string.Empty & comboBoxYear.Text != string.Empty)
                LoadAttendanceData(comboBoxMonth.Text, int.Parse(comboBoxYear.Text));
            loading.Hide();
        }


        private async void comboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            loading.Show();
            if (comboBoxMonth.SelectedItem == null || comboBoxYear.SelectedItem == null)
                return;
            LoadAttendanceData(comboBoxMonth.Text, int.Parse(comboBoxYear.Text));

            loading.Hide();
        }

        private void btnPrintEmp_Click(object sender, EventArgs e)
        {
            PrintGridControl();
        }
        #endregion

        private void FormAttendance_Load(object sender, EventArgs e)
        {

        }
    }
}
