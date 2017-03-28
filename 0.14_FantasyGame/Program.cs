using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_FantasyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //user input
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your clan name?");
            string clan = Console.ReadLine();
            Console.WriteLine("What is your player type?\n" +
                               "0: Assassin\n" +
                               "1: BlitzenBlopper\n" +
                               "2: Professsor\n" +
                               "3: HorseMange\n" +
                               "4: TaxMan\n" +
                               "5: Human\n");
            int playerType = int.Parse(Console.ReadLine());

            Player player = new Player(name, clan);
           // Console.WriteLine(player.PlayerName);
            //player.ShowPower();
            player.ChooseType(playerType);
            Console.WriteLine(player.ToString());

            //Enemy
            Enemy zard = new Enemy();
            zard.Name = "Zard";           
            zard.Insult();


            //Jerk enemy
            Jerk airHead = new Jerk("AirHead", "BaseBall-Bat", 50);
            


            Console.ReadLine();

        }
    }
}
