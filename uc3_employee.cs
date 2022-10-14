using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeewage
{
    public static class uc3_employee
    {
        public static void ToCalculateEmpWage()
        {
            int Is_FullTime = 1;
            int Is_PartTime = 2;
            int EmpWage_PerHr = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int emplCheck = random.Next(0,3);
            if (emplCheck == Is_FullTime)
            {
                empHrs = 8;
            }
            else if (emplCheck == Is_PartTime)
            {
                empHrs = 4;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EmpWage_PerHr;
            Console.WriteLine("employee wage : " + empWage);
        }
    }
}
