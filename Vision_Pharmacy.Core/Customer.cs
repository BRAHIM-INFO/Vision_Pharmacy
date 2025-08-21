using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision_Pharmacy.Core
{
    public class Customer
    {
        public int Id { get; set; } // مفتاح أساسي

        public string FullName { get; set; } // اسم العميل

        public string Phone { get; set; } // رقم الهاتف

        public string Address { get; set; } // العنوان

        public string Email { get; set; } // البريد الإلكتروني
        
        public string Notes { get; set; } // ملاحظات

        // قائمة المشتريات المرتبطة بالعميل
        public ICollection<Purchase> Purchases { get; set; }
    }
}
