using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeWage
    {
        const int WAGE_PER_HR = 20, FULL_DAY_HR = 8, PART_DAY_HR = 4,
            IS_FULL_TIME = 0, IS_PART_TIME = 1;
        int totalEmpWage = 0, empHrs = 0;
        Random Random = new Random();
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
            int empCheck = Random.Next(0, 3);//0,1,2
            if(empCheck == IS_FULL_TIME)
            {
                empHrs = FULL_DAY_HR;
            }
            if (empCheck == IS_PART_TIME) 
            {
                empHrs = PART_DAY_HR;
            }
            totalEmpWage = WAGE_PER_HR * FULL_DAY_HR;
            Console.WriteLine(totalEmpWage);
        }
    }
}
