using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_FantasyGame
{
    class Program
    {
        static void Main(string[] args)
        {                ////////////      WE ARE ROBIN vs COURT of OWLS    ////////////////
            //SpeechSynthesizer talkingConsole = new SpeechSynthesizer();
            //talkingConsole.Speak("what is your name?");


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
                               "5: Human");
            int playerType = int.Parse(Console.ReadLine());

            Player player = new Player(name, clan);
           // Console.WriteLine(player.PlayerName);
            //player.ShowPower();
            player.ChooseType(playerType);
            Console.WriteLine(player.ToString());
            Console.WriteLine("You are starting out with {0}Hp", player.CurrentPower);
            
            
            Console.WriteLine();


            //Jerk enemy
            Jerk jerk = new Jerk();
            Console.WriteLine("{0} came acrossed a jerk.", player.PlayerName);            
            Console.WriteLine("He has: " + jerk.PowerLevel + "Hp his name is: {0}.",jerk.Name);


            while (true)
            {
                jerk.Insult();
                Console.WriteLine("Do you want to fight? y/n");
                string userAnswer = Console.ReadLine();
                if (userAnswer == "y")
                {
                    jerk.JerkAttack(player);
                    player.PlayerAttack(jerk);

                    if (player.CurrentPower <= 0)
                    {
                        Console.WriteLine("you ded");
                        break;
                    }
                    else if ((jerk.PowerLevel <= 0))
                    {
                        Console.WriteLine("You won.");
                        break;
                    }
                    

                }
                else
                {
                    break;
                }
            }






            Console.WriteLine("What would you like to do?");


            

                


            Console.ReadLine();

        }
    }
}
