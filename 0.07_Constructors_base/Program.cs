using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Constructors_base
{
    class Program
    {
        static void Main(string[] args)
        {
            Person kenn = new Person("Kenn", "Pascascio", 27);
            kenn.DummyMethod();

            Minor evey = new Minor("Evey", "Milstead", 3, true);
            evey.DummyMethod();
            evey.Demo();

            Person jenn = new Minor("Jenn", "akins", 17, true);
            jenn.DummyMethod();

            Console.ReadLine();

        }
    }
}
