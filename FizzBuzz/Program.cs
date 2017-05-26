using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        public void DoFizzBuzz()
        {
            for (int i = 1; i < 101; i++) Console.WriteLine("{0:#;}{1:;;Fizz}{2:;;Buzz}", i % 3 * i % 5 == 0 ? 0 : i, i % 3, i % 5);
        }

        static void Main(string[] args)
        {
            Program few = new Program();
            few.DoFizzBuzz();

            //for (int n = 1; n <= 100; n++)
            //{
            //    if (n % 15 == 0)
            //    {
            //        Console.WriteLine("FizzBuzz");
            //    }
            //    else if (n % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else if (n % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(n);
            //    }
            //}





            Console.ReadLine();
        }
    }
}
