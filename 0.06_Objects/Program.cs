using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Classes and Objects
            Donuts appleCinn = new Donuts();
            appleCinn.Filling = "Apple Pie";
            appleCinn.isSpecial = false;
            appleCinn.price = 0.99m;
            appleCinn.Type = "Filled";

            Console.WriteLine(appleCinn.Filling);

            Donuts longJone = new Donuts();
            longJone.Filling = "Bavarian Creme";
            longJone.isSpecial = true;
            longJone.price = 1.25m;
            longJone.Type = "Filled";

            Console.WriteLine("A Longjohn cost about {0:C}", longJone.price);
            //Challenge
            


            Console.ReadLine();




        }
    }
}
