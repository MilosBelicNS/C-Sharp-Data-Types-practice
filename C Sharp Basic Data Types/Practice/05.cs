using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basic_Data_Types.Practice
{
    class _05
    {
        //Write a C# Sharp program that takes the radius of a circle as input and calculate the perimeter and area of the circle.

        //JavaScript: Area and circumference of a circle

        //  In geometry, the area enclosed by a circle of radius r is πr2.Here the Greek letter π represents a constant, approximately equal to 3.14159, which is equal to the ratio of the circumference of any circle to its diameter.

        //     The circumference of a circle is the linear distance around its edge.

        public static void Main()
        {

            double r, per_cir;
            double PI = 3.14;
            Console.WriteLine("Input the radius of the circle : ");
            r = Convert.ToDouble(Console.ReadLine());
            per_cir = 2 * PI * r;
            Console.WriteLine("Perimeter of Circle : {0}", per_cir);
            Console.ReadKey();
        }
    }
}
