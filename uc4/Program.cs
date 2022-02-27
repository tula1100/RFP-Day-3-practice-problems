using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uc4
{
    internal class Program
    {
        public const int is_parttime = 1;
        public const int is_fullTime = 2;
        public const int emp_rate_per_hour = 20;

        static void Main(string[] args)
        {
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);

            switch (empCheck)
            {
               case is_parttime:
                    empHrs = 5;
                    break;
               case is_fullTime:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * emp_rate_per_hour;
            Console.WriteLine("empWage : " + empWage);
        }
    }
}
