using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_Interface
{
    class Dog : Animal
    {
        //Properties   
        public string Name { get; set; }
        public string Fur { get; set; }
        public int Age { get; set; }

        //Methods
        public void Listens()
        {
            if (Name == "Remmy") { 
            Console.WriteLine("Speak Remmy Speak.");
            }
        }

        public void Speak()
        {
            Console.WriteLine("Wuff");
        }


    }
}
