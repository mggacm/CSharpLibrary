using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string friend = "Fred";

            switch (friend)
            {
                case "Fred":
                    Console.WriteLine("hey Fred, let's go golfing.");
                    break;
                case "karl":
                    Console.WriteLine("Let's hang.");
                    break;
                case "Jone":
                    Console.WriteLine("Sorry, I'm busy right now.");
                    break;
                default:
                    Console.WriteLine("Hey " + friend + "can I tell you back in a minute?");
                    break;

            }


            Console.ReadLine();
        }
    }
}
