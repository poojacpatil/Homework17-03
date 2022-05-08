using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework17_03
{
    internal class Homework9
    {
        static void Main(string[] args)
        {
            int n1, n2, result;
            Console.WriteLine("Enter 2 number");
             n1 = Convert.ToInt32(Console.ReadLine());
             n2 = Convert.ToInt32(Console.ReadLine());

            result = n1 + n2;
            Console.WriteLine(" Addition="+result );

            result = n1 - n2;
            Console.WriteLine(" Subtraction= "+result);

            result = n1 * n2;
            Console.WriteLine(" Multiplication="+result);

            result = n1 / n2;
            Console.WriteLine(" Division ="+result);
            
            Console.Read();
        }
    }
}
