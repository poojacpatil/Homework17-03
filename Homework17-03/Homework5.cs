using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework17_03
{
    internal class Homework5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            float a = Convert.ToSingle(Console.ReadLine());
            if (a > 0)
                Console.WriteLine("positive=" + a);
            else if (a < 0)
                Console.WriteLine("negative="+ a);
            else
                Console.WriteLine("zero=" + a);
            Console.Read();
        }
    }
}