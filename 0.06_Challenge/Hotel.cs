using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Challenge
{
    class Hotel
    {
        //Properties
        public int RoomNumber { get; set; }
        public bool IsAvailable { get; set; }
        public int NumBeds { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Methods
        public void PrintWelcomeMessage()
        {
            Console.WriteLine("Your room number is {0}", RoomNumber);
        }

        public void IfAvailable()
        {
            if (IsAvailable)
            {
                Console.WriteLine("Yes," + FirstName + " " + LastName + " Room " + RoomNumber + " is available" )
            }
        }



    }
}
