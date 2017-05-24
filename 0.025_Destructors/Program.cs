using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._025_Destructors
{
    class first
    {
        public first()
        {
            Console.WriteLine("First Object Created. Press Enter to destroy it.");
        }
        ~first()
        {
            Console.WriteLine("Destroying First Object");
            Console.ReadLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            first ft = new first();
            Console.ReadLine();
        }
    }

}

