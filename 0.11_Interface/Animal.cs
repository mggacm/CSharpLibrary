using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_Interface
{
    class Animal
    {
        public int NumberOfLegs { get; set; }
        public bool HasEyes { get; set; }
        public int Weight { get; set; }
        public string Type { get; set; }
        public string Sound { get; set; }

        public void Walks()
        {
            Console.WriteLine("I just took 4 steps.");
        }

    }
}
