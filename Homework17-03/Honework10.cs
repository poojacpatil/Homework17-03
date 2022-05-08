using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework17_03
{
    internal class Honework10
    {
        static void Main(string[] args)
        {
            float GS;
            Console.WriteLine("Enter basic salary");
            int bs = Convert.ToInt32(Console.ReadLine());

            if (bs > 0 && bs <= 1000)
            {
                //hra = bs * 0.02f;
                //da = bs * 0.08f;
                GS = bs + (bs * 0.02f) + (bs * 0.08f);
                Console.WriteLine("Gross Salary is=" + GS);
            }

            else if (bs > 1000 && bs <= 2000)
            {
                GS = bs + (bs * 0.025f) + (bs * 0.085f);
                Console.WriteLine("Gross Salary is = " + GS);
            }


            else if (bs > 2000)
            {
                GS = bs + (bs * 0.03f) + (bs * 0.09f);
                Console.WriteLine("Gross Salary is =" + GS);
            }
            else
                Console.WriteLine("Enter valid amount");
                Console.Read();
        }

    }

}     
    

