using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basic_Data_Types.Practice
{
    class _08
    {

        //Write a C# Sharp program that takes the radius of a sphere as input and calculate and display the surface and volume of the sphere.

        public static void Main()
        {
            float r;
            float pi = 3.1415926535f;

            Console.Write("Radius: ");
            r = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine(4 * pi * (r * r));

            Console.WriteLine(4f / 3f * pi * (r * r * r));
            //Console.WriteLine ((Math.PI * (r*r*r) * 4) / 3);
            //Console.WriteLine(4 * Math.PI * r * r);
            Console.ReadKey();
        }
    }
}
