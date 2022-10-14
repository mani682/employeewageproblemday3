using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeewage
{
    public static class uc6_employee
    {
        public static void TotalEmpWage()
        {
           const int Is_Full_time = 1;
           const int Is_Part_time = 2;
           const int Emp_Rate_Per_Hour = 20;
            int Num_Of_Working_Days = 100;
            int totalWorkingDays = 0;
            int totalWorkingHrs = 0;
            int totalHrs = 0;
            int empHrs = 0;
            int empWages = 0;
            while (totalHrs < totalWorkingHrs && totalWorkingDays < Num_Of_Working_Days)
            {
                totalWorkingDays++;
                Random random = new Random();
                int emplCheck = random.Next(3);
                switch (emplCheck)
                {
                    case Is_Full_time:
                        empHrs = 8;
                        break;
                    case Is_Part_time:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalHrs += empHrs;
            }
            Console.WriteLine("total working hours: {0}", totalHrs);
            Console.WriteLine("total working days {0}",totalWorkingDays);
            empWages = Emp_Rate_Per_Hour * totalHrs;
            Console.WriteLine("total employee wage is: " + empWages);
        }
    }
}
