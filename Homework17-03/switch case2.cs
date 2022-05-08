using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework17_03
{
    internal class switch_case2
    {
        static void Main(string[] args)
        {
            int result = Convert.ToInt32(Console.ReadLine());
            switch (result)
            {

                case 1: Console.WriteLine("Enter radius");
                    int radius = Convert.ToInt32(Console.ReadLine());
                    float circle = 3.14f * radius;
                    Console.WriteLine("area of circle=" + circle);
                    break;

                case 2: Console.WriteLine("Enter side");
                    int side = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("area of square=" + (side * side));
                    break;

                case 3: Console.WriteLine("Enter side");
                    int side1 = Convert.ToInt32(Console.ReadLine());
                    int side2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("area of right angled triangle=" + ( side1 * side2) / 2);
                    break;

                case 4: Console.WriteLine("Enter side");
                    int breadth = Convert.ToInt32(Console.ReadLine());
                    int depth = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("area of rectangle=" + (breadth * depth));
                    break;

                case 5: Console.WriteLine("Enter side");
                    int area = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("perimeter of square=" + (4 * area));
                    break;

                default:
                    Console.WriteLine("wrong result");
                    break;

            }
        }
    }
}
