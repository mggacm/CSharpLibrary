using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //lcv - Loop control variable

            //x +=1;
            //x = 1;
            //x++;

            /*       for (int lcv = 0; lcv < 6; lcv++)
                   {
                       Console.WriteLine("Line: " + lcv );
                   }
                   Console.WriteLine("============================");

                   for (int i = 0; i < 10; i++)
                   {
                       Console.WriteLine(i + 1);
                   }
                   Console.WriteLine("============================");

                   //Challenge
                   for (int r = 0; r < 10; r++)
                   {
                       if (r % 2 == 0)
                       {
                           Console.WriteLine("Even");
                       }
                       else
                       {
                           Console.WriteLine(r);
                       }
                   }
                   Console.WriteLine("============================");
            */
            int sum = 0;
            for (int i = 0; i <= 10; i++)
            {
                sum = sum + i;
            }
           
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("============================");
            Console.WriteLine(sum);





            Console.ReadLine();
        }
    }
}
