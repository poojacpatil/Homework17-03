using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework17_03
{
    internal class switch_program_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a 7 days");
            string a = Console.ReadLine();
            Console.WriteLine("Press 1-Monday 2-Tuesday 3-Wednesday 4-Thursday 5-Friday 6-Saturday 7-Sunday");
            Console.WriteLine("Enter ur choice");
            int chioce = Convert.ToInt32(Console.ReadLine());

            switch (chioce)
            {
                case 1: Console.WriteLine("Monday");
                    break;

                case 2: Console.WriteLine("Tuesday");
                    break;
                case 3: Console.WriteLine("Wednesday");
                    break;
                case 4: Console.WriteLine("Thursday");
                    break;
                case 5: Console.WriteLine("Friday");
                    break;
                case 6: Console.WriteLine("Saturday");
                    break;
                case 7: Console.WriteLine("Sunday");
                    break;
                default: Console.WriteLine("Wrong day");
                    break;

            }
        }
    }
}