using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uc3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int isparttime = 1;
            int isfulltime = 2;
            int emprateperhour = 20;
            int emphrs = 0;
            int empwage = 0;
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == isfulltime)
            {
                emphrs = 4;
            }
            else if (empcheck == isfulltime)
            {
                emphrs = 8;
            }
            else
            {
                emphrs = 0;
            }
            empwage = emphrs * emprateperhour;
            Console.WriteLine("empwage : " + empwage);
        }
    }
}
