using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework17_03
{
    internal class Homework3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if(a>b && a>c)
                Console.WriteLine("max="+a);
            else if(b>a && b>c)
                Console.WriteLine("max="+b);
             else if(c>a && c>b)
                Console.WriteLine("max="+c);
            else
                Console.WriteLine("Not max");
        }
    }
}
