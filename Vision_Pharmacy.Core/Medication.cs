using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision_Pharmacy.Core
{
    public class Medication
    {
        // المعرف الفريد للدواء (قد يكون باركود أو معرف داخلي)
        public int Id { get; set; } // أو Barcode مثلاً 

        public string Barcode { get; set; } // باركود الدواء

        public string Name { get; set; }   // اسم الدواء التجاري 
       
        public string GenericName { get; set; }  // الاسم العلمي أو المادة الفعالة 
       
        public string Manufacturer { get; set; }  // الشركة المصنعة 

        public string BatchNumber { get; set; }   // رقم الدفعة 

        public string Form { get; set; } // الشكل الصيدلي (أقراص، شراب، حقن...) 
        
        public string Strength { get; set; }  // التركيز (مثلاً 500mg أو 5mg/ml) 
        
        public string Category { get; set; }   // التصنيف (مضاد حيوي، مسكن، فيتامين...) 
        
        public string Unite { get; set; } // الوحدة (مثلاً: علبة، زجاجة، قرص)

        public decimal PurchasePrice { get; set; }  // سعر الشراء من المورد 

        public decimal SalePrice { get; set; }  // السعر للبيع للعميل 

        public int QuantityInStock { get; set; }   // كمية المخزون المتوفرة
        
        public int MinimumStockLevel { get; set; }   // الحد الأدنى للتنبيه عند اقتراب نفاد الكمية 
               
        public double Discount { get; set; } // نسبة الخصم

        public DateTime ExpiryDate { get; set; }   // تاريخ انتهاء الصلاحية 

        public DateTime DateAdded { get; set; } // تاريخ إضافة الدواء 
         
        public bool RequiresPrescription { get; set; }   // هل يتطلب وصفة طبية؟ 
          
        public string Notes { get; set; }  // ملاحظات إضافية (مثلاً طريقة الحفظ) 
      
        // الربط مع المورد
        //public int SupplierId { get; set; } // مفتاح أجنبي
        //public Suppliers Supplier { get; set; } // كائن المورد المرتبط 
        //public string SupplierName { get; set; }   // المورد الرئيسي للدواء

        public string LocationInStore { get; set; } // مكان التخزين
         
        public bool IsActive { get; set; } // مفعل/غير مفعل

        public byte[] Image { get; set; } // صورة (تُخزن كـ byte[] أو كمسار صورة لاحقًا)

       
    }

}
