using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision_Pharmacy.Core
{
    public class Sale
    {
        public int Id { get; set; }                // معرف الفاتورة
        public DateTime FactureDate { get; set; }         // تاريخ البيع 
        public string FactureNum { get; set; } // رقم الفاتورة    
        public int? CustomerId { get; set; }       // العميل (اختياري)
        public string CustomerName { get; set; } // اسم العميل
        public string DoctorName { get; set; }     // اسم الطبيب (اختياري)
        public decimal TotalAmount { get; set; }   // المبلغ الكلي
        public decimal Discount { get; set; }      // الخصم
        public decimal PaidAmount { get; set; }    // المبلغ المدفوع
        public string TypePaimt { get; set; }  // طريقة الدفع (نقد/بطاقة/تأمين)
        public int UserId { get; set; }            // الصيدلي الذي قام بالبيع 
        public string Notes { get; set; }   // ملاحظات إضافية (مثلاً طريقة الدفع أو تفاصيل أخرى)
        public List<SaleItem> Items { get; set; } = new List<SaleItem>(); // تفاصيل الفاتورة
    }

}
