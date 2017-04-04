using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Constructors_base
{
    class Person
    {   //ctor
        public Person()
        {

        }
        public Person(string fristName, string lastName, int age)
        {
            this.FirstName = FirstName;
            this.LastName = lastName;
            this.Age = age;
        }

        //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public virtual void DummyMethod()
        {
            Console.WriteLine("Test 1");
        }
    }
}
