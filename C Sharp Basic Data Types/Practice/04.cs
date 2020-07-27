using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basic_Data_Types.Practice
{
    class _04
    {
        //Write a C# Sharp program that takes two numbers as input and perform an operation (+,-,*,x,/) on them and displays the result of that operation.
        public static void Main()
        { 
            char operation;
            int a, b;

            Console.WriteLine("Input first number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input first number: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input your operation: ");
            operation = Convert.ToChar(Console.ReadLine());


            if (operation == '+')
            {
                Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            }
            else if (operation == '-')
            {
                Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            }
            else if (operation == '*' || operation == 'x')
            {
                Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            }
            else if (operation == '/')
            {
                Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            }
            else
                Console.WriteLine("Wrong character!");
            Console.ReadKey();

        }

    }
}
