using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vision_Pharmacy.Core;

namespace Vision_Pharmacy.Data.EFSqlServer
{
    public class CustomerEntity : IDataHelper<Customer>
    {
        // Fileds
        private DBContext db;
        private Customer Customer;

        // Methods
        public int Add(Customer table)
        {
            db = new DBContext();
            if (IsDbConnect())
            {
                db.Set<Customer>().Add(table);
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
                Customer = Find(Id);
                db.Customer.Remove(Customer);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int Edit(Customer table)
        {
            db = new DBContext();
            if (IsDbConnect())
            {
                db.Set<Customer>().Update(table);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public Customer Find(int id)
        {
            db = new DBContext();
            return db.Customer.Where(x => x.Id == id).First();
        }
        public List<Customer> GetData()
        {
            db = new DBContext();
            return db.Customer.ToList();
        }

        public bool IsDbConnect()
        {
            db = new DBContext();
            if (db.Database.CanConnect()) return true; return false;
        }

        public List<Customer> Search(string SearchItem)
        {
            db = new DBContext();
            return db.Customer.Where(x => x.FullName.Contains(SearchItem) 
            || x.Phone.Contains(SearchItem)
            || x.Email.Contains(SearchItem)
            || x.Phone.Contains(SearchItem)
            || x.Id.ToString() == SearchItem)
                .ToList();
        }
    }
}
