using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vision_Pharmacy.Core;

namespace Vision_Pharmacy.Data.EFSqlServer
{
    public class SaleReturnEntity : IDataHelper<SaleReturn>
    {
        // Fileds
        private DBContext db;
        private SaleReturn SaleReturn;

        // Methods
        public int Add(SaleReturn table)
        {
            db = new DBContext();
            if (IsDbConnect())
            {
                db.Set<SaleReturn>().Add(table);
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
                SaleReturn = Find(Id);
                db.SaleReturn.Remove(SaleReturn);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int Edit(SaleReturn table)
        {
            db = new DBContext();
            if (IsDbConnect())
            {
                db.Set<SaleReturn>().Update(table);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public SaleReturn Find(int id)
        {
            db = new DBContext();
            return db.SaleReturn.Where(x => x.Id == id).First();
        }
        public List<SaleReturn> GetData()
        {
            db = new DBContext();
            return db.SaleReturn.ToList();
        }

        public bool IsDbConnect()
        {
            db = new DBContext();
            if (db.Database.CanConnect()) return true; return false;
        }

        public List<SaleReturn> Search(string SearchItem)
        {
            db = new DBContext();
            return db.SaleReturn.Where(x => x.FactureNum.Contains(SearchItem) 
            || x.Id.ToString() == SearchItem)
                .ToList();
        }
    }
}
