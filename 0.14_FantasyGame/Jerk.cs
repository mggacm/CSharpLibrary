using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_FantasyGame
{
    class Jerk : Enemy
    {
        Dictionary<string, int> Attacks = new Dictionary<string, int> {
                {"Head-butt", 3 },
                {"Bite", 5},
                {"Mallet", 7},
            };



        //Constructor
        public Jerk()
        {
            this.Name = "AirHead";
            this.PowerLevel = 15;

        }



        //Properties
       
        public string Weapon { get; set; }
        public int AddedPowerLevel { get; set; }

      

        //Methods
        public void Explain()
        {
            this.AddedPowerLevel = this.PowerLevel + AddedPowerLevel;
            Console.WriteLine(Name + " is a Jerk. He is a higher level enemy so his power is: " + this.AddedPowerLevel);
        }

        public override void Insult()
        {
            int r = rnd.Next(0, insult.Count);
            Console.WriteLine("\"I'm going to crush you {0}.\"", insult[r]);
            
        }

        public void JerkAttack(Player p)
        {
            Attack(p, Attacks, this.Name);
        }
    }
}
