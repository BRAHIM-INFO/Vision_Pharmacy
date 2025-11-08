using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vision_Pharmacy.Core;

namespace Vision_Pharmacy.Data.EFSqlServer
{
    public class FinancialTransactionsEntity : IDataHelper<FinancialTransactions>
    {
        // Fileds
        private DBContext db;
        private FinancialTransactions FinancialTransactions;

        // Methods
        public int Add(FinancialTransactions table)
        {
            db = new DBContext();
            if (IsDbConnect())
            {
                db.Set<FinancialTransactions>().Add(table);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int Delete(int Id)
        {
            db = new DBContext();
            if (IsDbConnect())
            {
                FinancialTransactions = Find(Id);
                db.FinancialTransactions.Remove(FinancialTransactions);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int Edit(FinancialTransactions table)
        {
            db = new DBContext();
            if (IsDbConnect())
            {
                db.Set<FinancialTransactions>().Update(table);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public FinancialTransactions Find(int id)
        {
            db = new DBContext();
            return db.FinancialTransactions.Where(x => x.Id == id).First();
        }
        public List<FinancialTransactions> GetData()
        {
            db = new DBContext();
            return db.FinancialTransactions.ToList();
        }

        public bool IsDbConnect()
        {
            db = new DBContext();
            if (db.Database.CanConnect()) return true; return false;
        }

        public List<FinancialTransactions> Search(string SearchItem)
        {
            db = new DBContext();
            return db.FinancialTransactions.Where(x => x.TransactionType.Contains(SearchItem) 
            || x.Id.ToString() == SearchItem)
                .ToList();
        }
    }
}
