using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeewage
{
    public static class uc5_employee
    {
        public static void EmployeeWage()
        {
            int Is_Full_time = 1;
            int Is_Part_time = 2;
            int EmpWage_PerHr = 20;
            int Num_Of_Working_Days = 20;
            int totalHrs = 0;
            int empHrs = 0;
            int empWages = 0;
            for (int i = 0; i < Num_Of_Working_Days; i++)
            {
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
            Console.WriteLine("total working hours: {0}",totalHrs);
            empWages = EmpWage_PerHr * totalHrs;
            Console.WriteLine("total employee wage is: " + empWages);
        }
    }
}
