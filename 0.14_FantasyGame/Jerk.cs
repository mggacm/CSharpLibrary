using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_FantasyGame
{
    class Jerk : Enemy 
    {
        //Borrow
        public Jerk()
        {
            this.Name = "Jerk";
            this.PowerLevel = 15;

        }



        //Properties
       
        public string Weapon { get; set; }
        public int AddedPowerLevel { get; set; }

        //Construct
        public Jerk(string name, string weapon, int addedPowerLevel)
        {
            this.Name = name;
            this.Weapon = weapon;
            this.AddedPowerLevel = PowerLevel + addedPowerLevel;

        }

        //Method
        public void Explain()
        {
            Console.WriteLine(Name + " is a Jerk. He is a higher level enemy so his power is: " + this.AddedPowerLevel);
        }

        public override void Insult()
        {
            int r = rnd.Next(0, insult.Count);
            Console.WriteLine("I am {0}", this.Name, insult[r]);
        }


    }
}
