using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework17_03
{
    internal class switch_program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a 5 number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Press 1-One 2-Two 3-Three 4-Four 5-Five");
            Console.WriteLine("Enter ur chioce");
            int chioce = Convert.ToInt32(Console.ReadLine());

            switch (chioce)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2: Console.WriteLine("Two");
                    break;
                case 3: Console.WriteLine("Three");
                    break;
                case 4: Console.WriteLine("Four");
                    break;
                case 5: Console.WriteLine("Five");
                    break;
                default: Console.WriteLine("Wrong number");
                    break;

            }
        }
    }
}   

