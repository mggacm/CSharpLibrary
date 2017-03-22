using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How are you feeling today from 1-5?");
            string feelingNumber = Console.ReadLine();

            if (feelingNumber == "5")
            {
                Console.WriteLine("wow man. That's great to hear");
            }
            else if ((feelingNumber == "4"))
            {
                Console.WriteLine("Thats so good.");
            }
            else if ((feelingNumber == "3"))
            {
                Console.WriteLine("Let's try to make today a better day.");
            }
            else if ((feelingNumber == "2"))
            {
                Console.WriteLine("Oh I'm sorry to hear that.");
            }
            else if ((feelingNumber == "1"))
            {
                Console.WriteLine("What can I do to help?");
            }
            else
            {
                Console.WriteLine("I didn't quite catch that.");
            }

            Console.ReadLine();
        }
    }
}
