using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vision_Pharmacy.Core;

namespace Vision_Pharmacy.Data.EFSqlServer
{
    public class PayrollEntity : IDataHelper<Payroll>
    {
        // Fileds
        private DBContext db;
        private Payroll Payroll;

        // Methods
        public int Add(Payroll table)
        {
            db = new DBContext();
            if (IsDbConnect())
            {
                db.Set<Payroll>().Add(table);
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
                Payroll = Find(Id);
                db.Payroll.Remove(Payroll);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int Edit(Payroll table)
        {
            db = new DBContext();
            if (IsDbConnect())
            {
                db.Set<Payroll>().Update(table);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public Payroll Find(int id)
        {
            db = new DBContext();
            return db.Payroll.Where(x => x.EmployeeId == id).First();
        }
        public List<Payroll> GetData()
        {
            db = new DBContext();
            return db.Payroll.ToList();
        }

        public bool IsDbConnect()
        {
            db = new DBContext();
            if (db.Database.CanConnect()) return true; return false;
        }

        public List<Payroll> Search(string SearchItem)
        {
            db = new DBContext();
            return db.Payroll.Where(x => x.EmployeeId.ToString() == (SearchItem)
            || x.Month.ToString() == SearchItem)
                .ToList();
        }
    }
}
