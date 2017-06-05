using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _0._17._5_MoreLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dirfiles = Directory.GetFiles("c:\\sri\\");
            var avg = dirfiles.Select(file => new FileInfo(file).Length).Average();
            avg = Math.Round(avg / 10, 1);
            Console.WriteLine("The Average file size is {0} MB", avg);
            Console.ReadLine();
        }
    }
}
