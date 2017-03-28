using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_FantasyGame
{
    abstract class Enemy
    {   //Properties
        protected ArrayList insult = new ArrayList { "Pip-Squek", "Littlebird", "wimp" };
        protected Random rnd = new Random();
        public string Name { get; set; }
        public int PowerLevel { get; set; }

        //Methods
        public virtual void Insult()
        {                        
            int r = rnd.Next(0, insult.Count);
            Console.WriteLine(Name + " said: \"You {0} I have {1}% health.\"", insult[r], this.PowerLevel);
        }

        public void Attack(Player player, Dictionary<string, int> dict, Object enemyName)
        {          
            var singleAttack = dict.ElementAt(rnd.Next(dict.Count));
            int attackVall = singleAttack.Value;
            string attackName = singleAttack.Key;

            Console.WriteLine("Enemy attacked with {0} and deals {1} amount of damage.", attackName, attackVall);
            player.CurrentPower -= attackVall;
            Console.WriteLine("{0} power is at {1}%", player.PlayerName, player.CurrentPower);
            
        }


    }
}
