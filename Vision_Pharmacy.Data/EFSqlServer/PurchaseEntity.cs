using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vision_Pharmacy.Core;

namespace Vision_Pharmacy.Data.EFSqlServer
{
    public class PurchaseEntity : IDataHelper<Purchase>
    {
        // Fileds
        private DBContext db;
        private Purchase Purchase;

        // Methods
        public int Add(Purchase table)
        {
            db = new DBContext();
            if (IsDbConnect())
            {
                db.Set<Purchase>().Add(table);
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
                Purchase = Find(Id);
                db.Purchase.Remove(Purchase);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int Edit(Purchase table)
        {
            db = new DBContext();
            if (IsDbConnect())
            {
                db.Set<Purchase>().Update(table);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public Purchase Find(int id)
        {
            db = new DBContext();
            return db.Purchase.Where(x => x.Id == id).First();
        }
        public List<Purchase> GetData()
        {
            db = new DBContext();
            return db.Purchase.ToList();
        }

        public bool IsDbConnect()
        {
            db = new DBContext();
            if (db.Database.CanConnect()) return true; return false;
        }

        public List<Purchase> Search(string SearchItem)
        {
            db = new DBContext();
            return db.Purchase.Where(x => x.FactureNum.ToString() == (SearchItem)
            || x.Id.ToString() == SearchItem)
                .ToList();
        }
    }
}
