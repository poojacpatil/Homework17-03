using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework17_03
{
    internal class Homewoek7
    {
        static void Main(string[] args)
        {
            //alphabet or digit or Special character
            Console.WriteLine("Enter a input");
            char c = Convert.ToChar(Console.Read());
            if (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z')
                Console.WriteLine("alphabet");
            else if (c == '!' || c == '@' || c == '#' || c == '$' || c == '%' || c == '&' || c == '*' || c == '^' || c == '_' || c == '+')
                Console.WriteLine("Special character");
            else if (c >= 0)
                Console.WriteLine("digit");
            Console.Read();

        }
    }
}
