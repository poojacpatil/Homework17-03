using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework17_03
{
    internal class Homework6
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter the character");
            ch =Convert.ToChar( Console.Read());
            if (ch == 'a' || ch == 'e' || ch == 'i'|| ch == 'o' || ch == 'u')
                Console.WriteLine("Enter the character is Vowel");
            else
                Console.WriteLine("Enter the character is consonant");
            Console.Read();
        }
    }

}