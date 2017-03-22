using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            bool elevatorUp = true;
            bool elevatorDown = true;
            bool elevatorBroken = true;
            bool elevatorStuckWithUsInIt = true;
            int elevator = 13;

            if (elevatorUp == true)
            {
                Console.WriteLine("Going up");
            }
            else
            {
                Console.WriteLine("Going down");
            }

            //Write for elevator being broken:
            if (elevatorBroken)
            {
                Console.WriteLine("Bummer. Let's take the stairs.");
            }
            else
            {
                Console.WriteLine("Which floor?");
            }

            if (elevatorStuckWithUsInIt)
            {
                Console.WriteLine("Oh no! we're stuck!'");
            }
            else
            {
                Console.WriteLine("This elevator is fast.");
            }

            if (elevatorBroken && elevatorDown)
            {
                Console.WriteLine("I hope this thing doesn't start flying down!");
            }
            else
            {
                Console.WriteLine("How long are you in town for?");
            }

            if (elevatorBroken || elevatorStuckWithUsInIt )
            {
                Console.WriteLine("Hi Bob, this is Bob with maintenance. How can I help?");
            }

            Console.ReadLine();
        }
    }
}
