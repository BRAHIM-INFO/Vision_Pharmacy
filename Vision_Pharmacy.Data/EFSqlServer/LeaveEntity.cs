using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vision_Pharmacy.Core;

namespace Vision_Pharmacy.Data.EFSqlServer
{
    public class LeaveEntity : IDataHelper<Leave>
    {
        // Fileds
        private DBContext db;
        private Leave Leave;

        // Methods
        public int Add(Leave table)
        {
            db = new DBContext();
            if (IsDbConnect())
            {
                db.Set<Leave>().Add(table);
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
                Leave = Find(Id);
                db.Leave.Remove(Leave);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int Edit(Leave table)
        {
            db = new DBContext();
            if (IsDbConnect())
            {
                db.Set<Leave>().Update(table);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public Leave Find(int id)
        {
            db = new DBContext();
            return db.Leave.Where(x => x.Id == id).First();
        }
        public List<Leave> GetData()
        {
            db = new DBContext();
            return db.Leave.ToList();
        }

        public bool IsDbConnect()
        {
            db = new DBContext();
            if (db.Database.CanConnect()) return true; return false;
        }

        public List<Leave> Search(string SearchItem)
        {
            db = new DBContext();
            return db.Leave.Where(x => x.EmployeeId.ToString() == (SearchItem)
            || x.Id.ToString() == SearchItem)
                .ToList();
        }
    }
}
