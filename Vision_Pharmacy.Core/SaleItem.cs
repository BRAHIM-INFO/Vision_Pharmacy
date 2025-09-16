using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision_Pharmacy.Core
{
    public class SaleItem
    {
        public int Id { get; set; }
        public string Barcode { get; set; }  
        public string Name { get; set; } // لتخزين الاسم أيضًا 
        public string GenericName { get; set; }
        public int Quantity { get; set; }  // الكمية المباعة
        public decimal UnitPrice { get; set; }  // سعر الوحدة وقت البيع
        public decimal Discount { get; set; }
        public decimal Total => (UnitPrice * Quantity) - Discount;  // المجموع
    }  
}
