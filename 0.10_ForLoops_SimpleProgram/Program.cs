using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_ForLoops_SimpleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                    Console.WriteLine("Enter Your Name:");
                    string name = Console.ReadLine();
                    Console.WriteLine(name);
            */
            Console.WriteLine("Enter your starting Number: ");
            int staringNum = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter your ending Number: ");
            int endingNum = Int32.Parse(Console.ReadLine());


            int sum = 0;
            for (int i = staringNum ; i <= endingNum ; i++)
            {
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine("The sum of all numers between {0} and {1} is {2}", staringNum, endingNum, sum);
            ;






            Console.ReadLine();
        }
    }
}
