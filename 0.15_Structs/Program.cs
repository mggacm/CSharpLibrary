using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._15_Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookEntry Paul = new AddressBookEntry()
            {
                Address = "123 Coder pl",
                City = "Westfield",
                State = "IN",
                Zip = "44056",
                FirstName = "Paul",
                LastName = "O'Conner",
                Age = 40


            };

            AddressBookEntry Tommy = new AddressBookEntry()
            {
                Address = "Meridian st",
                City = "Indidanpolis",
                State = "IN",
                Zip = "46217",
                FirstName = "Tommy",
                LastName = "Hurly",
                Age = 21


            };

            AddressBookEntry Billy = new AddressBookEntry()
            {
                Address = "Washington st",
                City = "Westfield",
                State = "IN",
                Zip = "44105",
                FirstName = "Billy",
                LastName = "Hurly",
                Age = 23


            };

            AddressBookEntry Bre = new AddressBookEntry()
            {
                Address = "123 Coder pl",
                City = "Mcaster",
                State = "IN",
                Zip = "4305",
                FirstName = "Breeanna",
                LastName = "Elliott",
                Age = 21


            };

            Console.WriteLine(Paul.GetAddress());
            Console.WriteLine("");
            Console.WriteLine(Billy.GetAddress());
            Console.WriteLine("");
            Console.WriteLine(Tommy.GetAddress());
            Console.WriteLine("");
            Console.WriteLine(Bre.GetAddress());
            Console.ReadLine();
        }


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Program (string firstName,string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        struct AddressBookEntry
        {
            public string FirstName;
            public string LastName;
            public int Age;
            public string Address;
            public string City;
            public string State;
            public string Zip;

            public string GetAddress()
            {
                return $"Address: {Address}\nCity: {City}\nState: {State}\nZip: {Zip}\n";
            }
        }
    }
}
