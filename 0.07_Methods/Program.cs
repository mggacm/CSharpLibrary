using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer theJSWizard = new Customer();
            theJSWizard.AppersWealthy = false;
            theJSWizard.FirstName = "James";
            theJSWizard.LastName = "Handshoe";

            theJSWizard.PrintCustomerName();

            Customer theSheriff = new Customer();
            theSheriff.AppersWealthy = false;
            theSheriff.FirstName = "Sheriff";
            theSheriff.LastName = "Holler";

            theSheriff.PrintCustomerName();

            Customer theKenn = new Customer();
            theKenn.AppersWealthy = false;
            theKenn.FirstName = "Kenn";
            theKenn.LastName = "Protol";

            theKenn.PrintCustomerName();
            Console.ReadLine();
        }
       
    }
}
