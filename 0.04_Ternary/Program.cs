using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ternary Operator 
            //Compares 
            
            int number = 10;
            if (number == 7)
                Console.WriteLine("The number is 7");
            else
                Console.WriteLine("The number is not 7");

            //Same as this:
            string response = ((number == 7) ? "Hey, the number is 7, yo" : "The number is not 7, yo");
            Console.WriteLine(response);
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
