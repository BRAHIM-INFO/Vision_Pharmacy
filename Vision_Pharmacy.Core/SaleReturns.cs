using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision_Pharmacy.Core
{
    public class SaleReturn
    {
        public int Id { get; set; }                // معرف الفاتورة
        public DateTime ReturnFactureDate { get; set; } // تاريخ الفاتورة  الارجاع
        public string ReturnFactureNum { get; set; }   // رقم الفاتورة الارجاع   
        public string FactureNum { get; set; }   // رقم الفاتورة   
        public string Barcode { get; set; }  // باركود الدواء
        public decimal Discount { get; set; }      // الخصم
         
        // كمية المخزون المتوفرة
        public int Quantity { get; set; }

        public decimal SalePrice { get; set; }
        // السعر للبيع للعميل (اختياري في المشتريات)

        public decimal TotalItem => SalePrice * Quantity; // خاصية محسوبة

        // المبلغ الإجمالي
        public decimal TotalAmount { get; set; }
        // ملاحظات إضافية (مثلاً طريقة الدفع أو تفاصيل أخرى)
        public string Notes { get; set; }
    }

}
