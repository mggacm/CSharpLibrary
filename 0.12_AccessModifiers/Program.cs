using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
                /*Check out Class file*/

            Acura tl = new Acura("Tl", 2000, 500);
            tl.price = 1000;
            
            Console.WriteLine(tl.AcuraDetails());




            Console.ReadLine();
        }
    }
}
