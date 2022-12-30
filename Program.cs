using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Day number (1-7): ");
           int Day = Convert.ToInt32(Console.ReadLine());

            if (Day == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (Day == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (Day == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (Day == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (Day == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (Day == 6)
            {
                Console.WriteLine("Saturday");
            }
            else if (Day == 7)
            {
                Console.WriteLine("Sunday");
            }
            else
            {
                Console.WriteLine("invalid i/p");
            }
        }
    }
}
