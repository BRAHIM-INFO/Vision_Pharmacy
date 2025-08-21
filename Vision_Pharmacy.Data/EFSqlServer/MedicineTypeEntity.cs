using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vision_Pharmacy.Core;

namespace Vision_Pharmacy.Data.EFSqlServer
{
    public class MedicineTypeEntity : IDataHelper<MedicineType>
    { 
        // Fileds
        private DBContext db;
        private MedicineType MedicineType;

        // Methods
        public int Add(MedicineType table)
        {
            db = new DBContext();
            if (IsDbConnect())
            {
                db.Set<MedicineType>().Add(table);
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
                MedicineType = Find(Id);
                db.MedicineType.Remove(MedicineType);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int Edit(MedicineType table)
        {
            db = new DBContext();
            if (IsDbConnect())
            {
                db.Set<MedicineType>().Update(table);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public MedicineType Find(int id)
        {
            db = new DBContext();
            return db.MedicineType.Where(x => x.Id == id).First();
        }
        public List<MedicineType> GetData()
        {
            db = new DBContext();
            return db.MedicineType.ToList();
        }

        public bool IsDbConnect()
        {
            db = new DBContext();
            if (db.Database.CanConnect()) return true; return false;
        }

        public List<MedicineType> Search(string SearchItem)
        {
            db = new DBContext();
            return db.MedicineType.Where(x => x.Name.Contains(SearchItem)
            || x.Id.ToString() == SearchItem)
                .ToList();
        }
    }
}
