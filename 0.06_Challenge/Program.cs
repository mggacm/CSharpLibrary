using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel OverPrice = new Hotel();
            OverPrice.RoomNumber = 32;
            OverPrice.IsAvailable = true;
            OverPrice.NumBeds = 2;
            OverPrice.PrintCustomerName();



        }
    }
}
