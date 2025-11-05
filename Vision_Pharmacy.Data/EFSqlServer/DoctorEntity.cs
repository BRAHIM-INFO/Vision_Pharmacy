using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vision_Pharmacy.Core;

namespace Vision_Pharmacy.Data.EFSqlServer
{
    public class DoctorEntity : IDataHelper<Doctor>
    {
        // Fileds
        private DBContext db;
        private Doctor Doctor;

        // Methods
        public int Add(Doctor table)
        {
            db = new DBContext();
            if (IsDbConnect())
            {
                db.Set<Doctor>().Add(table);
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
                Doctor = Find(Id);
                db.Doctor.Remove(Doctor);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int Edit(Doctor table)
        {
            db = new DBContext();
            if (IsDbConnect())
            {
                db.Set<Doctor>().Update(table);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public Doctor Find(int id)
        {
            db = new DBContext();
            return db.Doctor.Where(x => x.Id == id).First();
        }
        public List<Doctor> GetData()
        {
            db = new DBContext();
            return db.Doctor.ToList();
        }

        public bool IsDbConnect()
        {
            db = new DBContext();
            if (db.Database.CanConnect()) return true; return false;
        }

        public List<Doctor> Search(string SearchItem)
        {
            db = new DBContext();
            return db.Doctor.Where(x => x.FullName.Contains(SearchItem)
             || x.Specialty.Contains(SearchItem)
            || x.Id.ToString() == SearchItem)
                .ToList();
        }
    } 
}
