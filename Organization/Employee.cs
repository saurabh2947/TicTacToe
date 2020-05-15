using System;
using System.Collections.Generic;
using System.Text;

namespace OrganizationBLL
{
    class Employee
    {
        public int EmpID { get; set; }
        public string Name { get; set; }
        public double SalaryPerDay { get; set; }
        public double HRA { get; set; }

        public double GetSalary(int NoOfLeavesTaken)
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int NoOfWorkingDays = DateTime.DaysInMonth(year, month);
            int NoOfDaysPresent = NoOfWorkingDays - NoOfLeavesTaken;
            double BasicSalary = NoOfDaysPresent * SalaryPerDay;
            double HRASal = BasicSalary * HRA / 100;
            double GrossSalary = BasicSalary + HRASal;
            return GrossSalary;
        }
    }
}
