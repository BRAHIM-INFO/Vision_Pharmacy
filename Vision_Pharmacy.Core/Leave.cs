using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision_Pharmacy.Core
{
    //الإجازات
    public class Leave
    {
        public int Id { get; set; }

        [DisplayName("رقم الموظف")]
        public int EmployeeId { get; set; }

        [DisplayName("تاريخ بداية الإجازة")]
        public DateTime StartDate { get; set; }

        [DisplayName("تاريخ نهاية الإجازة")]
        public DateTime EndDate { get; set; }

        [DisplayName("سبب الإجازة")]
        public string Reason { get; set; }

        [DisplayName("عدد الأيام")]
        public int LeaveDays => (EndDate - StartDate).Days + 1;
    }

}
