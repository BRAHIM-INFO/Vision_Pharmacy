using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vision_Pharmacy.Core;

namespace Vision_Pharmacy.Data.EFSqlServer
{
    public class EmployeeEntity : IDataHelper<Employees>
    {
        // Fileds
        private DBContext db;
        private Employees Employees;

        // Methods
        public int Add(Employees table)
        {
            db = new DBContext();
            if (IsDbConnect())
            {
                db.Set<Employees>().Add(table);
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
                Employees = Find(Id);
                db.Employees.Remove(Employees);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int Edit(Employees table)
        {
            db = new DBContext();
            if (IsDbConnect())
            {
                db.Set<Employees>().Update(table);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public Employees Find(int id)
        {
            db = new DBContext();
            return db.Employees.Where(x => x.Id == id).First();
        }
        public List<Employees> GetData()
        {
            db = new DBContext();
            return db.Employees.ToList();
        }

        public bool IsDbConnect()
        {
            db = new DBContext();
            if (db.Database.CanConnect()) return true; return false;
        }

        public List<Employees> Search(string SearchItem)
        {
            db = new DBContext();
            return db.Employees.Where(x => x.FullName.Contains(SearchItem)
             || x.Role.Contains(SearchItem) 
            || x.Id.ToString() == SearchItem)
                .ToList();
        }
    }
}
