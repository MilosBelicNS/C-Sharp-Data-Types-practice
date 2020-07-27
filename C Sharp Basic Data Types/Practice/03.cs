using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basic_Data_Types.Practice
{
    class _03
    {
        //Write a C# Sharp program that takes userid and password as input (type string).
        //After 3 wrong attempts, user will be rejected.

        public static void Main()
        {
            string username, password;
            int ctr = 0; int succeeded = 0;
            Console.Write("\n\nCheck username and password :\n");
            Console.Write("N.B. : Defaule username and password is : username and password\n");
            Console.Write("---------------------------------\n");
            do
            {
                Console.Write("Input a username: ");
                username = Console.ReadLine();

                Console.Write("Input a password: ");
                password = Console.ReadLine();
                if (username == "username" && password == "password") 
                    //ako je username i pass jednak unetim podacima
                {
                    succeeded = 1;//povecaj broj uspesnog logovanja
                    ctr = 3;// stavi da je brojac dosao do tri jer je uspesno logovanje
                }

                else
                {// u slucaju da nije uspelo succeeded ostaje na nuli
                    succeeded = 0;
                    ctr++;//dok se brojac logovanja uvecava
                    Console.WriteLine("Try again!");
                }
            }
            while ((username != "username" || password != "password")
                    && (ctr != 3));// ako podaci nisu jednaki kao sto se trazi i brojac nije jednak 3
            if (succeeded == 0)//i ukoliko nema nijednog uspesnog logovanja
            {
                Console.Write("\nLogin attemp more than three times. Try later!\n\n");
            }
            else
            if (succeeded == 1) //dok u slucaju uspesnog logovanja zavrsava se nasa operacija
            {
                Console.Write("\nPassword entered successfull!\n\n");
            }
        }

    }
}
