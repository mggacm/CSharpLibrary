using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Methods
{
    class Customer
    {   //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CustomerID { get; set; }
        public string Email { get; set; }
        public bool AppersWealthy { get; set; }
        public decimal BankRoll { get; set; }

        //Methods
        public void PrintCustomerName()
        {
            Console.WriteLine("Hello, {0} {1}", FirstName, LastName);
        }


    }
}
