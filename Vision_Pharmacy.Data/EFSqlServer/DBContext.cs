using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vision_Pharmacy.Core;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace Vision_Pharmacy.Data.EFSqlServer
{
    public class DBContext : DbContext
    {
        public string _connectionString;

        // Constructores
        public DBContext() 
        { 
        }
        //Methods -- Override 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            var DevelopmentConString = @"Server=.;DataBase=DB_VisionPharmacy;Integrated Security=True;TrustServerCertificate=True;";
            //optionsBuilder.UseSqlServer( ConfigDictionary.keyValuePairs["ConString"]);
            EnsureDatabaseExists(DevelopmentConString);
            optionsBuilder.UseSqlServer(DevelopmentConString);

           
        }

        private void EnsureDatabaseExists(string connectionString)
        {
            var builder = new SqlConnectionStringBuilder(connectionString);
            string dbName = builder.InitialCatalog;

            // اتصل بـ master بدلاً من قاعدة البيانات
            builder.InitialCatalog = "master";

            using (var connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = $"IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = '{dbName}') " +
                                      $"CREATE DATABASE [{dbName}]";
                    cmd.ExecuteNonQuery();
                }
            }
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
        public DbSet<Sale> Sale { get; set; }
        public DbSet<FinancialTransactions> FinancialTransactions { get; set; }
        public DbSet<SaleReturn> SaleReturn { get; set; }
    }
}
