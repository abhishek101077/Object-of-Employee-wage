using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectofEmployeewage
{
    internal class Objectof_UC4
    {
        public void Solution()
        {
            Console.WriteLine("Welcome to EmployeeWage Computation");
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            int EMP_RATE_PER_HOUR = 20;

            switch (empCheck)
            {
                case 1:
                    Console.WriteLine("Full Time Employee is Present");
                    empHrs = 8;
                    break;
                case 2:
                    Console.WriteLine("Part Time Employee is Present");
                    empHrs = 4;
                    break;
                default:
                    Console.WriteLine("Employee is Absent");
                    empHrs = 0;
                    break;
            }
            empWage = EMP_RATE_PER_HOUR * empHrs;
            Console.WriteLine("Employee Wage : " + empWage);

            Console.ReadLine();

        }
    }
}
