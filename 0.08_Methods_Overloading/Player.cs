using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_Methods_Overloading
{
    class Player
    {
        public string Name { get; set; }

        //Attack x3
        public void Attack()
        {
            Console.WriteLine(Name + " attaked for 5 points");
        }
        public void Attack(string weapon)
        {
            Console.WriteLine(this.Name + " attacked with a " + weapon); //this.
        }
        public void Attack(string weapon, int attackPoints)
        {
            Console.WriteLine(Name + " attaked with " + weapon + " for " + attackPoints +" points");
        }


    }
}
