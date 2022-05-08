using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework17_03
{
    internal class class_work
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter year");
            int yy =Convert.ToInt32( Console.ReadLine());
            if(yy%4==0)
                Console.WriteLine("leep year");
           else
                Console.WriteLine("not leep year");
            Console.WriteLine(yy%4==0 ? "leep year":"not leep year");
            
        }
    }
}
