using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision_Pharmacy.Core
{
    public class Doctor
    {
        public int Id { get; set; } // Primary Key
        public string Name { get; set; } // اسم الطبيب
        public string Specialty { get; set; } // التخصص
        public string Phone { get; set; } // رقم الهاتف
    }

}
