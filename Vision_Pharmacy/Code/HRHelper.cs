using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vision_Pharmacy.Core;

namespace Vision_Pharmacy.Code
{
    public static class HRHelper
    {
        /// <summary>
        /// حساب صافي الراتب حسب عدد أيام الغياب
        /// </summary>
        public static double CalculateNetSalary(double baseSalary, int absentDays, double dailyRate)
        {
            return baseSalary - (absentDays * dailyRate);
        }

        /// <summary>
        /// التحقق إن كان الموظف في إجازة في يوم معين
        /// </summary>
        public static bool IsEmployeeOnLeave(List<Leave> leaves, DateTime date)
        {
            foreach (var leave in leaves)
            {
                if (date >= leave.StartDate && date <= leave.EndDate)
                    return true;
            }
            return false;
        }
    }

}
