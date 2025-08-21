using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision_Pharmacy.Core
{
    public class Suppliers
    {
        public int Id { get; set; } // معرف فريد

        public string Name { get; set; } // اسم المورد

        public string Address { get; set; } // العنوان

        public string Phone { get; set; } // الهاتف

        public string Email { get; set; } // البريد الإلكتروني

        public bool IsActive { get; set; } // هل المورد نشط؟

        public string Notes { get; set; } // ملاحظات إضافية

        public byte[] Image { get; set; } // صورة (تُخزن كـ byte[] أو كمسار صورة لاحقًا)

        // قائمة الأدوية المرتبطة بهذا المورد (علاقة 1 إلى عدة)
        public List<Medication> Medications { get; set; } = new List<Medication>();
    }

}
