using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_FantasyGame
{   public enum CharacterType
    {
        Assassin = 0,
        Berserker = 1,
        Spy = 2,
        Samurai = 3,
    
    }
    class Player
    {  
        //CONSTRUCTS
        //     <name>   <Prop1>     <Prop2>          <Prop3>
        public Player(string name, string clanName, CharacterType type = CharacterType.Samurai)
        {
            this.PlayerName = name;
            this.Clan = clanName;
            //this.BattleCry = battleCry;
            this.CurrentPower = 100;
            this.Type = type;

        }

        //Attack
        Dictionary<string, int> Fighting = new Dictionary<string, int>
        {
                {"Punch", 5 },
                {"Kick", 7 },
                {"Sword", 13 },
        };


        //PROPERTIES    
        protected Random rnd = new Random();
        public string PlayerName { get; set; }
        public string Clan { get; set; }
        //public string BattleCry { get; set; }
        public int CurrentPower { get; set; }
        public CharacterType Type { get; set; }        
        

        //METHODS
        public CharacterType ChooseType(int t)
        {
            switch (t)    //If spicifc
            {
                case 0:
                    //Console.WriteLine("You are an Ninja Assassin.");
                    return this.Type = CharacterType.Assassin;
                    
                case 1:
                    //Console.WriteLine("You are a Berserker.");
                    return this.Type = CharacterType.Berserker;
                   
                case 2:
                    //Console.WriteLine("You are a Spy");
                    return this.Type = CharacterType.Spy;
                   
                case 3:
                    //Console.WriteLine("You are a Samurai.");
                    return this.Type = CharacterType.Samurai;
                                   
                default:
                    Console.WriteLine("You are a Samurai.");
                    return this.Type = CharacterType.Samurai;
                    
            }
        }
        public void ShowPower()
        {
            Console.WriteLine(this.PlayerName + " has " + this.CurrentPower + "% power.");
        }
        
        public override string ToString()
        {
            return $"Player Name: {this.PlayerName}\nGamer Name: {this.Clan}\nPlayer Type: {this.Type}";
        }

        public void PlayerAttack(EnemySamurai jerk, Dictionary<string, int> dict, Object enemyName)
        {


            var singleAttack = dict.ElementAt(rnd.Next(dict.Count));
            int attackVall = singleAttack.Value;
            string attackName = singleAttack.Key;

            Console.WriteLine("You attacked with {0} and deals {1} amount of damage.", attackName, attackVall);
            jerk.PowerLevel -= attackVall;
            Console.WriteLine("{0} power is at {1}%", jerk.Name, jerk.PowerLevel);
            

        }

        public void PlayerAttack(EnemySamurai jerk)
        {
            PlayerAttack(jerk, Fighting, this.PlayerName);
        }

    }
}
