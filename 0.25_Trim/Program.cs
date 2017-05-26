using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._25_Trim
{    
    class Program
    {
        static void Main()
        {
            // Input string.
            string st = "  This is an example string. ";

            // Call Trim instance method.
            // This returns a new string copy.
            st = st.Trim();

            Console.WriteLine(st);

            Console.ReadLine();
        }
    }
}
