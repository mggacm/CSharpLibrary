using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_Interface
{
    class Program
    {
        static void Main(string[] args)
        {


            Bear barryTheBear = new Bear();
            barryTheBear.Weight = 2000;
            barryTheBear.Walks();
            barryTheBear.Speak();
            Console.WriteLine();


            Dog remmi = new Dog();
            remmi.Name = "Remmy";
            remmi.Weight = 75;
            remmi.HasEyes = true;
            remmi.Listens();
            remmi.Speak();

            remmi.Walks();


            PolarBear cokeACola = new PolarBear();
            cokeACola.Weight = 2000;


            Console.ReadLine();
        }

    }
}
