using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_ArraysOfObjects
{
    class Country
    {
        //Constructors
        public Country(string name, string capital)
        {
            Name = name;
            Capital = capital;
            
        }
        //Properties
        public string Name { get; set; }
        public string Capital { get; set; }

        //Methods
        public void PrintToScreen()
        {
            Console.WriteLine("Capital of {0} is {1}.", this.Name, this.Capital);
        }

    }
}
