using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vision_Pharmacy.Core;

namespace Vision_Pharmacy.Data.EFSqlServer
{
    public class SuppliersEntity : IDataHelper<Suppliers>
    {
        // Fileds
        private DBContext db;
        private Suppliers suppliers;

        // Methods
        public int Add(Suppliers table)
        {
            db = new DBContext();
            if (IsDbConnect())
            {
                db.Set<Suppliers>().Add(table);
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
                suppliers = Find(Id);
                db.Suppliers.Remove(suppliers);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int Edit(Suppliers table)
        {
            db = new DBContext();
            if (IsDbConnect())
            {
                db.Set<Suppliers>().Update(table);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public Suppliers Find(int id)
        {
            db = new DBContext();
            return db.Suppliers.Where(x => x.Id == id).First();
        }
        public List<Suppliers> GetData()
        {
            db = new DBContext();
            return db.Suppliers.ToList();
        }

        public bool IsDbConnect()
        {
            db = new DBContext();
            if (db.Database.CanConnect()) return true; return false;
        }

        public List<Suppliers> Search(string SearchItem)
        {
            db = new DBContext();
            return db.Suppliers.Where(x => x.Name.Contains(SearchItem)
             || x.Name.Contains(SearchItem)
            || x.Phone.Contains(SearchItem) 
            || x.Email.Contains(SearchItem)
            || x.Phone.Contains(SearchItem)
            || x.Id.ToString() == SearchItem)
                .ToList();
        }
    }
}
