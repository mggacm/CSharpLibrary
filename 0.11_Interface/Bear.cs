using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_Interface
{
    class Bear : Animal 
    {       //Properties
        public bool Hibernate { get; set; }
        public string Meal { get; set; }
        public bool StealsPicnicBasket { get; set; }

            //Methods
        public void Speak()
        {
            Console.WriteLine("GRRRRRRRRWWWWWWWWAAAAAAAALL");
        }


    }
}
