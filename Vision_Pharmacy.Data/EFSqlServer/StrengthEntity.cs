using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vision_Pharmacy.Core;

namespace Vision_Pharmacy.Data.EFSqlServer
{
    public class StrengthEntity : IDataHelper<Strength>
    { 
        // Fileds
        private DBContext db;
        private Strength Strength;

        // Methods
        public int Add(Strength table)
        {
            db = new DBContext();
            if (IsDbConnect())
            {
                db.Set<Strength>().Add(table);
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
                Strength = Find(Id);
                db.Strength.Remove(Strength);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int Edit(Strength table)
        {
            db = new DBContext();
            if (IsDbConnect())
            {
                db.Set<Strength>().Update(table);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public Strength Find(int id)
        {
            db = new DBContext();
            return db.Strength.Where(x => x.Id == id).First();
        }
        public List<Strength> GetData()
        {
            db = new DBContext();
            return db.Strength.ToList();
        }

        public bool IsDbConnect()
        {
            db = new DBContext();
            if (db.Database.CanConnect()) return true; return false;
        }

        public List<Strength> Search(string SearchItem)
        {
            db = new DBContext();
            return db.Strength.Where(x => x.Name.Contains(SearchItem)
            || x.Id.ToString() == SearchItem)
                .ToList();
        }
    }
}
