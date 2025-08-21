using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision_Pharmacy.Core
{

    public class Payroll
    {
        public int Id { get; set; }

        [DisplayName("رقم الموظف")]
        public int EmployeeId { get; set; }

        [DisplayName("اسم الموظف")]
        public string EmployeeName { get; set; }

        [DisplayName("الشهر")]
        public int Month { get; set; }

        [DisplayName("السنة")]
        public int Year { get; set; }

        [DisplayName("أيام الحضور")]
        public int DaysPresent { get; set; }

        [DisplayName("أيام الغياب")]
        public int DaysAbsent { get; set; }

        [DisplayName("الراتب الأساسي")]
        public double BaseSalary { get; set; }

        [DisplayName("الخصومات")]
        public double Deductions { get; set; }

        [DisplayName("الراتب الصافي")]
        public double NetSalary => BaseSalary - Deductions;
    }



    //public class Payroll
    //{
    //    public int Id { get; set; }

    //    [DisplayName("رقم الموظف")]
    //    public int EmployeeId { get; set; }

    //    [NotMapped]
    //    [DisplayName("الموظف")]
    //    public string EmployeeName { get; set; } // 👈 هذا هو المطلوب


    //    [DisplayName("الشهر")]
    //    public int Month { get; set; }

    //    [DisplayName("السنة")]
    //    public int Year { get; set; }

    //    [DisplayName("الراتب الأساسي")]
    //    public double BaseSalary { get; set; }

    //    [DisplayName("الخصومات")]
    //    public double Deductions { get; set; }

    //    [DisplayName("صافي الراتب")]
    //    public double NetSalary => BaseSalary - Deductions;


    //}

}
