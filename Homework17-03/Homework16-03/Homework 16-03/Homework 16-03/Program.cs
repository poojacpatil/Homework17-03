using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_16_03
{
    internal class square
    {
        static void Main(string[] args)
        {
            float area, perimeter;
            Console.WriteLine("Enter side of square");
            float side = Convert.ToSingle(Console.ReadLine());
            area = side * side;
            perimeter = 4 * area;
            Console.WriteLine("Enter araa of square="+area);
            Console.WriteLine("Enter perimeter of square="+perimeter);
        }
    }
}
