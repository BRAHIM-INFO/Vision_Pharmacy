using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vision_Pharmacy.Core;

namespace Vision_Pharmacy.Data.EFSqlServer
{
    public class AttendanceEntity //: IDataHelper<Attendance>
    {
        //// Fileds
        //private DBContext db;
        //private Attendance Attendance;

        //// Methods
        //public int Add(Attendance table)
        //{
        //    db = new DBContext();
        //    if (IsDbConnect())
        //    {
        //        db.Set<Attendance>().Add(table);
        //        db.SaveChanges();
        //        return 1;
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}

        //public int Delete(int Id)
        //{
        //    db = new DBContext();
        //    if (IsDbConnect())
        //    {
        //        Attendance = Find(Id);
        //        db.Attendance.Remove(Attendance);
        //        db.SaveChanges();
        //        return 1;
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}

        //public int Edit(Attendance table)
        //{
        //    db = new DBContext();
        //    if (IsDbConnect())
        //    {
        //        db.Set<Attendance>().Update(table);
        //        db.SaveChanges();
        //        return 1;
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}

        //public Attendance Find(int id)
        //{
        //    db = new DBContext();
        //    return db.Attendance.Where(x => x.Id == id).First();
        //}
        public List<Attendance> GetData()
        {
            db = new DBContext();
            return db.Attendance.ToList();
        }

        //public bool IsDbConnect()
        //{
        //    db = new DBContext();
        //    if (db.Database.CanConnect()) return true; return false;
        //}

        //public List<Attendance> Search(string SearchItem)
        //{
        //    db = new DBContext();
        //    return db.Attendance.Where(x => x.EmployeeId.ToString() == (SearchItem) 
        //    || x.Id.ToString() == SearchItem)
        //        .ToList();
        //}

        private DBContext db;

        public void SaveOrUpdate(int employeeId, DateTime date, bool isPresent)
        {
            db = new DBContext();

            var record = db.Attendance
                .FirstOrDefault(x => x.EmployeeId == employeeId && x.Date.Date == date.Date);

            if (record == null)
            {
                db.Attendance.Add(new Attendance
                {
                    EmployeeId = employeeId,
                    Date = date,
                    IsPresent = isPresent
                });
            }
            else
            {
                record.IsPresent = isPresent;
                db.Attendance.Update(record);
            }

            db.SaveChanges();
        }

        public List<Attendance> GetByMonth(int month, int year)
        {
            db = new DBContext();
            return db.Attendance
                     .Where(x => x.Date.Month == month && x.Date.Year == year)
                     .ToList();
        }
    }
}
