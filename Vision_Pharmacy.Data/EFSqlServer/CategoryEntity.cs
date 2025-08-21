using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vision_Pharmacy.Core;

namespace Vision_Pharmacy.Data.EFSqlServer
{
    public class CategoryEntity : IDataHelper<Category>
    { 
        // Fileds
        private DBContext db;
        private Category Category;

        // Methods
        public int Add(Category table)
        {
            db = new DBContext();
            if (IsDbConnect())
            {
                db.Set<Category>().Add(table);
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
                Category = Find(Id);
                db.Category.Remove(Category);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int Edit(Category table)
        {
            db = new DBContext();
            if (IsDbConnect())
            {
                db.Set<Category>().Update(table);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public Category Find(int id)
        {
            db = new DBContext();
            return db.Category.Where(x => x.Id == id).First();
        }
        public List<Category> GetData()
        {
            db = new DBContext();
            return db.Category.ToList();
        }

        public bool IsDbConnect()
        {
            db = new DBContext();
            if (db.Database.CanConnect()) return true; return false;
        }

        public List<Category> Search(string SearchItem)
        {
            db = new DBContext();
            return db.Category.Where(x => x.Name.Contains(SearchItem) 
            || x.Id.ToString() == SearchItem)
                .ToList();
        }
    }
}
