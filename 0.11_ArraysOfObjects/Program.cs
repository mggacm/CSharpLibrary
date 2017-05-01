using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_ArraysOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {

            //Country[] countries = new Country[10];
            //countries[0] = new Country("Houndurans", "Tegucigalpa");
            //countries[1] = new Country("Italy", "Rome");
            //countries[2] = new Country("USA", "Washington D.C.");
            //countries[3] = new Country("Isreal", "Jerusalem");
            //countries[4] = new Country("Peru", "Lima");
            //countries[5] = new Country("Japan", "Tokyo");
            //countries[6] = new Country("Austrlia", "Sydney");
            //countries[7] = new Country("Nicaragua", "Managua");
            //countries[8] = new Country("China", "Beijing");
            //countries[9] = new Country("Houndurans", "Tegucigalpa");

            //foreach (var country in countries) //VAR
            //{
            //    country.PrintToScreen();
            //}
            //Console.WriteLine("");

            double[] balance = new double[10];
            int[] madeUp = new int[] { 99, 77, 4, 25, 86 };

            int[] n = new int[10]; /* n is an array of 10 integers */
            int i, j;

            /* initialize elements of array n */
            for (i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }

            /* output each array element's value */
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("Element[{0}] = {1}", j, n[j]);
            }
            Console.ReadKey();




            Console.ReadLine();
        }
    }
}
