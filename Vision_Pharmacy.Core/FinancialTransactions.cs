using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision_Pharmacy.Core
{
    public class FinancialTransactions
    {
        public int Id { get; set; }
        public string TransactionNum { get; set; } // 'E' أو 'I'
        public string TransactionType { get; set; } // 'E' أو 'I'
        public string TransactionName { get; set; }
        public string TransactionDescription { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; } 
    }
}
