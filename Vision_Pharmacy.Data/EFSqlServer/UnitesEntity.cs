using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vision_Pharmacy.Core;

namespace Vision_Pharmacy.Data.EFSqlServer
{
    public class UnitesEntity : IDataHelper<Unites>
    {  // Fileds
        private DBContext db;
        private Unites Unites;

        // Methods
        public int Add(Unites table)
        {
            db = new DBContext();
            if (IsDbConnect())
            {
                db.Set<Unites>().Add(table);
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
                Unites = Find(Id);
                db.Unites.Remove(Unites);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int Edit(Unites table)
        {
            db = new DBContext();
            if (IsDbConnect())
            {
                db.Set<Unites>().Update(table);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public Unites Find(int id)
        {
            db = new DBContext();
            return db.Unites.Where(x => x.Id == id).First();
        }
        public List<Unites> GetData()
        {
            db = new DBContext();
            return db.Unites.ToList();
        }

        public bool IsDbConnect()
        {
            db = new DBContext();
            if (db.Database.CanConnect()) return true; return false;
        }

        public List<Unites> Search(string SearchItem)
        {
            db = new DBContext();
            return db.Unites.Where(x => x.Name.Contains(SearchItem)
            || x.Id.ToString() == SearchItem)
                .ToList();
        }
    }
}
