using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uc1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int full_time = 1;
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == full_time)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is present");
            }
        }
    }
}
