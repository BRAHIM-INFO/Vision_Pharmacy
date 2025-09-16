using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision_Pharmacy.Core
{
    public class PurchaseItem
    {
        public string Barcode { get; set; }
        public string Name { get; set; }
        public string GenericName { get; set; }
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public decimal TotalItem { get; set; }
    }
}
