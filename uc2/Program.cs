using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uc2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int is_fulltime = 1;
            int emp_rate_per_hour = 20;
            int emphrs = 0;
            int empwage = 0;
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == is_fulltime)
            {
                emphrs = 8;
            }
            else
            {
                emphrs = 0;
            }
            empwage = emphrs * emp_rate_per_hour;
            Console.WriteLine("emp wage : " + empwage);

        }
    }
}
