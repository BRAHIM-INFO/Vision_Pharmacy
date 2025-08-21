using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision_Pharmacy.Code
{
    public class AttendanceView
    {
        public int EmployeeId { get; set; }

        // days 1 to 31, True = حاضر، False = غائب
        public Dictionary<int, bool> DailyAttendance { get; set; } = new Dictionary<int, bool>();
    }

}
