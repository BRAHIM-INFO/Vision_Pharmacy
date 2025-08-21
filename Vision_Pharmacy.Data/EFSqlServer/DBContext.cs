using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vision_Pharmacy.Core;

namespace Vision_Pharmacy.Data.EFSqlServer
{
    public class DBContext : DbContext
    {

        // Constructores
        public DBContext()
        {
        }
        //Methods -- Override
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var DevelopmentConString = @"Server=.\SQLEXPRESS;DataBase=DB_VisionPharmacy;Integrated Security=True;TrustServerCertificate=True;";
            //optionsBuilder.UseSqlServer(ConfigDictionary.keyValuePairs["ConString"]);
            optionsBuilder.UseSqlServer(DevelopmentConString);
        }
        // Tables 
        public DbSet<User> User { get; set; } 
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Attendance> Attendance { get; set; }
        public DbSet<Leave> Leave { get; set; }
        public DbSet<Medication> Medication { get; set; }
        public DbSet<Payroll> Payroll { get; set; }
        public DbSet<MedicineType> MedicineType { get; set; }
        public DbSet<Strength> Strength { get; set; }
        public DbSet<Unites> Unites { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
    }
}
