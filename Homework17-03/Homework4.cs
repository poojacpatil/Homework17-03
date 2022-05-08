using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework17_03
{
    internal class Homework4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine("Enter number is Even");
            else
                Console.WriteLine("Enter number is odd");
            Console.ReadLine();    
        }
    }
}
