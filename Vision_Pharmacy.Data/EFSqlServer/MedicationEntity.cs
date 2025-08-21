using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vision_Pharmacy.Core;

namespace Vision_Pharmacy.Data.EFSqlServer
{
    public class MedicationEntity : IDataHelper<Medication>
    {
        // Fileds
        private DBContext db;
        private Medication Medication;

        // Methods
        public int Add(Medication table)
        {
            db = new DBContext();
            if (IsDbConnect())
            { 
                db.Set<Medication>().Add(table);
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
                Medication = Find(Id);
                db.Medication.Remove(Medication);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int Edit(Medication table)
        {
            db = new DBContext();
            if (IsDbConnect())
            {
                db.Set<Medication>().Update(table);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public Medication Find(int id)
        {
            db = new DBContext();
            return db.Medication.Where(x => x.Id == id).First();
        }
        public List<Medication> GetData()
        {
            db = new DBContext();
            return db.Medication.ToList();
        }

        public bool IsDbConnect()
        {
            db = new DBContext();
            if (db.Database.CanConnect()) return true; return false;
        }

        public List<Medication> Search(string SearchItem)
        {
            db = new DBContext();
            return db.Medication.Where(x => x.Name.ToString() == (SearchItem)
            || x.Id.ToString() == SearchItem)
                .ToList();
        }
    }
}
