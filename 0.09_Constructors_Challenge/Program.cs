using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            MobilePhone friend1 = new MobilePhone("iPhone", "6s+", "Mikeale");
            MobilePhone friend2 = new MobilePhone("Galexy", "s", "John");
            MobilePhone friend3 = new MobilePhone("iPhone", "7", "Fin");
            MobilePhone friend4 = new MobilePhone("LG", "razor", "Zanado");
            MobilePhone friend5 = new MobilePhone("iPhone", "6", "James");

            friend1.PrintToScreen();
            friend2.PrintToScreen();
            friend3.PrintToScreen();
            friend4.PrintToScreen();
            friend5.PrintToScreen();

            Console.ReadLine();
        }
    }
}
