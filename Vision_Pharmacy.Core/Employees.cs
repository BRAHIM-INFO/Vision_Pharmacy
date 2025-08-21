
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision_Pharmacy.Core
{
    /// <summary>
    /// يمثل معلومات الموظف الأساسية.
    /// </summary>
    public class Employees
    {
        public int Id { get; set; }

        [DisplayName("الاسم الكامل")]
        public string FullName { get; set; }

        [DisplayName("الوظيفة")]
        public string Role { get; set; }

        [DisplayName("الهاتف")]
        public string Phone { get; set; }

        [DisplayName("تاريخ التوظيف")]
        public DateTime HireDate { get; set; }

        [DisplayName("الراتب")]
        public double Salary { get; set; }

        [DisplayName("الحالة")]
        public bool IsActive { get; set; }

        [DisplayName("الصورة")]
        public byte[] Image { get; set; } // صورة (تُخزن كـ byte[] أو كمسار صورة لاحقًا)
    }
}
