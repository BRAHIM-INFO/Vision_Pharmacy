using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision_Pharmacy.Core
{
    public class Purchase
    {
        public int Id { get; set; }

        public DateTime FactureDate { get; set; }

        // رقم الفاتورة 
        public string FactureNum { get; set; } 

        // نوع الدفع (نقدي، بطاقة ائتمان، شيك، إلخ)
        public string TypePaimt { get; set; }

        // باركود الدواء
        public string Barcode { get; set; } 


        // FK إلى Supplier (في حالة المشتريات)
        public int? SupplierId { get; set; }

        // كمية المخزون المتوفرة
        public int Quantity { get; set; }

        // سعر الشراء من المورد 
        public decimal PurchasePrice { get; set; }

        public decimal SalePrice { get; set; }
        // السعر للبيع للعميل (اختياري في المشتريات)

        public decimal TotalItem => PurchasePrice * Quantity; // خاصية محسوبة

        // المورد الرئيسي للدواء
        public string SupplierName { get; set; }

        // المبلغ الإجمالي
        public decimal TotalAmount { get; set; }
        // ملاحظات إضافية (مثلاً طريقة الدفع أو تفاصيل أخرى)
        public string Notes { get; set; }


        // نوع العملية: Purchase = شراء من المورد, Sale = بيع للعميل
        //public string Type { get; set; } // "Purchase" أو "Sale"

        // FK إلى Customer (في حالة المبيعات)
        //public int? CustomerId { get; set; }
        //public Customer Customer { get; set; }

        // اسم الطبيب (اختياري في المبيعات)
        //public string DoctorName { get; set; } 
    }
}
