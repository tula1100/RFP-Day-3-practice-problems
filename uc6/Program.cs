using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uc6
{
    internal class Program
    {
        public const int is_parttime = 1;
        public const int is_fulltime = 2;
        public const int emp_rate_per_hour = 20;
        public const int num_of_working_days  = 20;
        public const int max_Hrs_in_month = 100;
        static void Main(string[] args)
        {
            int empHrs =0;
            int totalempHrs = 0;
            int totalworkingDays = 0;
            while(totalempHrs  <= max_Hrs_in_month && totalworkingDays < num_of_working_days)
            {
                totalworkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch(empCheck)
                {
                    case is_parttime:
                        empHrs = 4;
                        break;
                        case is_fulltime:
                        empHrs = 8;
                        break;
                        default:
                        empHrs = 0;
                        break;
                }
                totalempHrs += empHrs;
                Console.WriteLine("Days :" + totalworkingDays + " empHrs: " + empHrs);            }
        }
        int totalempWage = totalempHrs * emp_rate_per_hour;
        Console.WriteLine("totalempWage : " + totalempWage);
    } 
}
