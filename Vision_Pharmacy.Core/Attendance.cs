using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision_Pharmacy.Core
{
    // الحضور والانصراف
    public class Attendance
    {
        public int Id { get; set; }

        [DisplayName("رقم الموظف")]
        public int EmployeeId { get; set; }

        [DisplayName("تاريخ")]
        public DateTime Date { get; set; }

        [DisplayName("حالة العمل")]
        public bool IsPresent { get; set; } 
    }
}
