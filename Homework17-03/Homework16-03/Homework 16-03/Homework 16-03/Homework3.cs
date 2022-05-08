using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_16_03
{
    internal class Homework3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter calculate amount to discount");
            float amount = Convert.ToSingle(Console.ReadLine());
            float discount = amount * 20 / 100;
            float net_pay = amount - discount;
            Console.Read();
        }
    }
}