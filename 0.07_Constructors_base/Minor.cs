using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Constructors_base
{
    class Minor : Person
    {
        public Minor(string firstName, string lastName, int age, bool isInSchool) : base(firstName, lastName, age)
        {
            this.IsInSchool = isInSchool;
        }

        public bool IsInSchool { get; set; }


        public override void DummyMethod()
        {
            Console.WriteLine("Test2");
        }

        public void Demo()
        {
            Console.WriteLine("Fun");
        }

    }
}
