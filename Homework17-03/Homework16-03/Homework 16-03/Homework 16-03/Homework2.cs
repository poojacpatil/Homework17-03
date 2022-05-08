using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_16_03
{
    internal class Homework2
    {
        static void Main(string[] args)
        {

            int M1, M2, M3, M4, M5;
            float Avg;
            Console.WriteLine("Enter marks of M1");
            M1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks of M2");
            M2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks of M3");
            M3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks of M4");
            M4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks of M5");
            M5 = Convert.ToInt32(Console.ReadLine());
            Avg = (M1 + M2 + M3 + M4 + M5) / 5;
            Avg = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Average of five subject=" + Avg);
        }
    }
}        




















        
        
    




    
    
    
    