using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._025_TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 5673.74;
            int i;

            // cast double to int.
            i = (int)d;

            Console.WriteLine(i);
            Console.WriteLine("");


            int x = 75;
            float f = 53.005f;
            double y = 2345.7652;
            bool b = true;

            Console.WriteLine(x.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(y.ToString());
            Console.WriteLine(b.ToString());


            Console.WriteLine(0x4b);


            // Accepting Values from User
            // The Console class in the System namespace provides 
            // a function ReadLine() for accepting input from the user and store it into a variable.
            // num will equal internaly whatever a user enters.
            //For example,

            int num;
            // user enters a sting
            num = Convert.ToInt32(Console.ReadLine());
            //converted to an int
            Console.WriteLine(num);
            //no longer a string type
            

            Console.ReadKey();
        }
    }
}
