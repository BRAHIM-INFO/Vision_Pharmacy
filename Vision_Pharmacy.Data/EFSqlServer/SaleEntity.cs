using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vision_Pharmacy.Core;

namespace Vision_Pharmacy.Data.EFSqlServer
{ 
    public class SaleEntity : IDataHelper<Sale>
    {
        // Fileds
        private DBContext db;
        private Sale Sale;

        // Methods
        public int Add(Sale table)
        {
            db = new DBContext();
            if (IsDbConnect())
            {
                db.Set<Sale>().Add(table);
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
                Sale = Find(Id);
                db.Sale.Remove(Sale);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int Edit(Sale table)
        {
            db = new DBContext();
            if (IsDbConnect())
            {
                db.Set<Sale>().Update(table);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public Sale Find(int id)
        {
            db = new DBContext();
            return db.Sale.Where(x => x.Id == id).First();
        }
        public List<Sale> GetData()
        {
            db = new DBContext();
            return db.Sale.ToList();
        }

        public bool IsDbConnect()
        {
            db = new DBContext();
            if (db.Database.CanConnect()) return true; return false;
        }

        public List<Sale> Search(string SearchItem)
        {
            db = new DBContext();
            return db.Sale.Where(x => x.DoctorName.Contains(SearchItem)
            || x.Id.ToString() == SearchItem)
                .ToList();
        }
    }
}
