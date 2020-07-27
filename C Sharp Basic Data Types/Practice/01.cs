using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basic_Data_Types.Practice
{
    class _01
    {
        //Write a C# Sharp program that takes three letters as input and display them in reverse order.

        public static void Main(string[] args)
        {
            char a, b, c;

            Console.Write("Input letter: ");
            a = Convert.ToChar(Console.ReadLine());

            Console.Write("Input letter: ");
            b = Convert.ToChar(Console.ReadLine());

            Console.Write("Input letter: ");
            c = Convert.ToChar(Console.ReadLine());


            Console.WriteLine("Letters: {0}, {1}, {2}", c, b, a);
            Console.ReadKey();

        }
    }
}
