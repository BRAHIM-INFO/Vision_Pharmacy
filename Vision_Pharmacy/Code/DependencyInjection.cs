using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vision_Pharmacy.Core;
using Vision_Pharmacy.Data.EFSqlServer;

namespace Vision_Pharmacy.Code
{
    public class DependencyInjection
    {

        // Construcotores
        public DependencyInjection()
        {
            // Inject the objets
            ContainerConfig.Register("Supplier", new SuppliersEntity());
            ContainerConfig.Register("User", new UserEntity());
            ContainerConfig.Register("Employees", new EmployeeEntity());
            ContainerConfig.Register("Attendance", new AttendanceEntity());
            ContainerConfig.Register("Leave", new LeaveEntity());
            ContainerConfig.Register("Medication", new MedicationEntity());
            ContainerConfig.Register("Payroll", new PayrollEntity());
            ContainerConfig.Register("MedicineType", new MedicineTypeEntity());
            ContainerConfig.Register("Strength", new StrengthEntity());
            ContainerConfig.Register("Unites", new UnitesEntity());
            ContainerConfig.Register("Category", new CategoryEntity());
            ContainerConfig.Register("Customer", new CustomerEntity());
            ContainerConfig.Register("Purchase", new PurchaseEntity()); 
            ContainerConfig.Register("Doctor", new DoctorEntity());
            ContainerConfig.Register("Sale", new SaleEntity());
            ContainerConfig.Register("SaleReturn", new SaleReturnEntity());
            ContainerConfig.Register("FinancialTransactions", new FinancialTransactionsEntity());
        }
    }
}
