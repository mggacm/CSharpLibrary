using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_Methods_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Player zanado = new Player();
            zanado.Name = "Zanado";
            zanado.Attack();
            zanado.Attack("Stick");
            zanado.Attack("Wooden Sword", 5);

            Console.ReadLine();
        }
    }
}
