using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework17_03
{
    internal class Switch_program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Press 1-Addition 2-Substract 3-Multiplication 4-Division");
            Console.WriteLine("Enter ur choice");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Addition :" + (a + b));
                    break;
                case 2:
                    Console.WriteLine("Substraction" + (a - b));
                    break;
                case 3:
                    Console.WriteLine("Multiplication" + (a * b));
                    break;
                case 4:
                    Console.WriteLine("Division" + (a / b));
                    break;
                default:
                    Console.WriteLine("Wrong choice");
                    break;
            }
        }
    }
}