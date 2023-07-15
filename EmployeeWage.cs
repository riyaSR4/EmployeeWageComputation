using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeWage
    {
        const int FULL_DAY_HR = 8, PART_DAY_HR = 4,
            IS_FULL_TIME = 0, IS_PART_TIME = 1;
        int totalEmpWage = 0, empHrs = 0, wagePerHr, totalWorkingDays, totalWorkingHrs;
        string companyName;
        Random Random = new Random();
        public EmployeeWage(string companyName, int wagePerHr, int totalWorkingDays, int totalWorkingHrs)
        {
            this.companyName = companyName;
            this.wagePerHr = wagePerHr;
            this.totalWorkingDays = totalWorkingDays;
            this.totalWorkingHrs = totalWorkingHrs;
        }
        public void EmployeeAttendance()
        {
            int empCheck = Random.Next(0, 2);//returns value 0, 1
            if (empCheck == 0)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");

        }
        public void CalculateEmpWage() 
        {
            for (int i = 0; i < totalWorkingDays && empHrs < totalWorkingHrs; i++)
            {
                int empCheck = Random.Next(0, 3);//0,1,2
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = FULL_DAY_HR;
                        break;
                    case IS_PART_TIME:
                        empHrs = PART_DAY_HR;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
            }
            totalEmpWage = wagePerHr * empHrs;
            Console.WriteLine(companyName + "--->" +totalEmpWage);
        }
    }
}
