using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basic_Data_Types.Practice
{
    class _09
    {
        //Write a C# Sharp program that takes a character as input and check the input (lowercase) is a vowel, a digit, or any other symbol.

        public static void Main()
        {
            char symbol;
            Console.Write("Input your symbol: ");
            symbol = Convert.ToChar(Console.ReadLine());

            if (symbol == 'a' || symbol == 'e' || symbol == 'i' || symbol == 'o' || symbol == 'u')
            {
                Console.WriteLine("This char is a vowel");
            }
            else if (symbol >= '0' && symbol <= '9')
            {
                Console.WriteLine("This char is a digit");
            }
            else
                Console.WriteLine("This char isnt vowel or digit, this char is other");
            Console.ReadKey();
        }
    }
}
