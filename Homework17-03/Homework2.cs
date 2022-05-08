using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework17_03
{
    internal class Homework2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 5 == 0 && a % 11 == 0)
                Console.WriteLine(" divisible by 5 & 11");
            else
                Console.WriteLine("Not divisible by 5 & 11");
            Console.Read();
        }
    }
}
