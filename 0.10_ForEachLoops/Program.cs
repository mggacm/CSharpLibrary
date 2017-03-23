using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_ForEachLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;
            Console.WriteLine(numbers[3]);
            Console.WriteLine();
                       //character/value   0  1   2   3   4  5
            int[] lottoNums = new int[] { 15, 4, 16, 23, 42, 7 };
            string[] names = new string[] { "James", "Paul", "Obi Wan", "Anakin", "Meow" };
            /*      Console.WriteLine(lottoNums[5]);
                  Console.WriteLine();
                  foreach (int number in numbers)
                  {
                      Console.WriteLine(number);
                  }
                  Console.WriteLine();
                  foreach (int latto in lottoNums)
                  {
                      Console.Write(latto + " ");
                  }
                  Console.WriteLine();
            */

            foreach (string test in names) 
            {
                Console.WriteLine(test);
            }


            Console.ReadLine();
        }
    }
}
