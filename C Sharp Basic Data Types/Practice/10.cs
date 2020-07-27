using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basic_Data_Types.Practice
{
    class _10
    {

        //Write a C# Sharp program that takes two numbers as input and returns true or false when both numbers are even or odd.

           public static void Milos()
        {
            int a, b;
            Console.WriteLine("Input first number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input first number: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Test(a, b));
            Console.ReadKey();

        }

        public static bool Test(int a, int b)
        {
            if ( (a % 2==0 && b % 2==0) || (a % 2 != 0 && b % 2 != 0))
            {
                return true;
            }
            return false;
        }
    }
}
