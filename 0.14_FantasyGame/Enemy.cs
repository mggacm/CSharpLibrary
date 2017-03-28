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
        protected ArrayList insult = new ArrayList { "noob", "buster", "wimp" };
        protected Random rnd = new Random();
        public string Name { get; set; }
        public int PowerLevel { get; set; }

        //Methods
        public virtual void Insult()
        {                        
            int r = rnd.Next(0, insult.Count);
            Console.WriteLine(Name + " called you: \"{0}\" and  said: \"Yo mama.\" power level is: {1}", insult[r], this.PowerLevel);
        }

        public void Attack(Player player)
        {
            Console.WriteLine("{0} power is at {1}",player.PlayerName, player.CurrentPower);
            player.CurrentPower -= 15; 
        }


    }
}
