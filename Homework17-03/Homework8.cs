using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework17_03
{
    internal class Homework8
    {
        static void Main(string[] args)
        {
            // number of 3 digit
            Console.WriteLine("Enter 3 digit number");
            int a = Convert.ToInt32(Console.ReadLine());

            int sum = 0, rem = 0;
            if (a >= 100 && a <= 999)
            {
                rem = a % 10;
                sum = sum + rem;
                rem = a / 100;
                sum = sum + rem;
                Console.WriteLine("Enter sum of the 1st and 3rd digit is" + sum);
            }
             else
                Console.WriteLine("This is Not valid input");
        }
    }
}
