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
        public DateTime FactureDate { get; set; } // تاريخ الفاتورة 
        public string FactureNum { get; set; }   // رقم الفاتورة   
        public string Barcode { get; set; }  // باركود الدواء
        public decimal Discount { get; set; }      // الخصم
        public string DoctorName { get; set; }     // اسم الطبيب (اختياري) 
          
        // نوع الدفع (نقدي، بطاقة ائتمان، شيك، إلخ)
        public string TypePaimt { get; set; } 
       
        // FK إلى Supplier (في حالة المشتريات)
        public int? CustomerId { get; set; } 
        // العميل الرئيسي للدواء
        public string CustomerName { get; set; }

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
