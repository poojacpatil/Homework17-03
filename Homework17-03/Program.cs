using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework17_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Leap year");
            int yy = Convert.ToInt32(Console.ReadLine());
            if (yy % 4 == 0)
                Console.WriteLine("Leap year");
            else
                Console.WriteLine("Not Leap year");
            Console.Read();
        }
    }
}
