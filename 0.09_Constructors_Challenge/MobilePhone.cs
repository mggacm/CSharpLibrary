using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors_Challenge
{
    class MobilePhone
    {
        //Constructs
        public MobilePhone(string make, string model, string owner)
        {
            this.Make = make;
            this.Model = model;
            this.Owner = owner;
        }

        //Properties
        public int MobilePhoneID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Owner { get; set; }

        //Method
        public void PrintToScreen()
        {
            Console.WriteLine(Owner + " owns a(n) " + Make + " " + Model);
        }
        
    }
}
