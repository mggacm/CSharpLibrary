using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOn = true;
            bool isHot = false;

            if (isOn)
            {
                Console.WriteLine("The light is on. It is bright.");
            }

            //2
            if (isOn == true)
            {
                Console.WriteLine("The light is on");
            }

            if (isOn && isHot)
            {
                Console.WriteLine("Lights on and it is hot");
            }
            if (isOn || isHot)
            {
                Console.WriteLine("lights on or it is hot");
            }
            if (!isHot)
            {
                Console.WriteLine("It is not hot");
            }


            Console.WriteLine("------");





            bool isAdmin = false;
            bool isLoggedIn = false;
            string user;
            if (isAdmin)
            {
                Console.WriteLine("Welcome to the site.");
            }
            if (!isAdmin)
            {
                Console.WriteLine("Please try again.");
            }
            if (isAdmin && isLoggedIn)
            {
                Console.WriteLine("Welcome to Admin");
            }

            Console.ReadLine();
        }
    }
}
