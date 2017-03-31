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
            MainAppTitle();
            Console.WriteLine("Choose your warrior.\n" +
                              "Option 0: Ninja Assassin\n" +
                              "Option 1: Berserker\n" +
                              "Option 2: Spy\n" +
                              "Option 3: Samurai");
            int playerType = int.Parse(Console.ReadLine());
            Console.WriteLine("===============================");

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your clan name?");
            string clan = Console.ReadLine();
            Console.WriteLine("===============================");

            Player player = new Player(name, clan);
           // Console.WriteLine(player.PlayerName);
            //player.ShowPower();
            player.ChooseType(playerType);
            Console.WriteLine(player.ToString());
            Console.WriteLine("You are starting out with {0}Hp", player.CurrentPower);
            Console.WriteLine("");
            Console.WriteLine("What do you want to do?\n" +
                              "Option 0: Fight\n" +
                              "Option 1: Farm\n" +
                              "Option 2: Travel\n" +
                              "Option 3: Quit");
           int choice = Int32.Parse(Console.ReadLine());
            do
            {
                if (choice == 0)    //FIGHT
                {
                    bool continueChoice = true;

                    EnemySamurai eSamurai = new EnemySamurai();
                    Console.WriteLine("{0} came acrossed a enemy.", player.PlayerName);
                    Console.WriteLine("He has: " + eSamurai.PowerLevel + "Hp his name is: {0}.", eSamurai.Name);
                    while (true)
                    {
                        eSamurai.Insult();
                        Console.WriteLine("Do you want to fight? y/n");
                        string userAnswer = Console.ReadLine();
                        if (userAnswer == "y")
                        {
                            eSamurai.JerkAttack(player);
                            player.PlayerAttack(eSamurai);

                            if (player.CurrentPower <= 0)
                            {
                                Console.WriteLine("DISHONORED");
                                continueChoice = false;
                            }
                            else if ((eSamurai.PowerLevel <= 0))
                            {
                                Console.WriteLine("VICTORY");
                                continueChoice = false;
                            }
                            continueChoice = false;

                        }
                        else
                        {
                            Console.WriteLine("DISHONOR ON YOUR FAMILY");
                            break;
                        }
                        continueChoice = false;
                    }
                }
            } while (choice != 3);
            
            






            


            

                


            Console.ReadLine();

        }
        private static void MainAppTitle()
        {
            Console.Clear();
            string appTitle = @"    __  ___     __           ______               
   /  |/  /__  / /_____ _   / ____/__  ____ ______
  / /|_/ / _ \/ __/ __ `/  / / __/ _ \/ __ `/ ___/
 / /  / /  __/ /_/ /_/ /  / /_/ /  __/ /_/ / /    
/_/  /_/\___/\__/\__,_/   \____/\___/\__,_/_/     
                                                  ";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(appTitle);
            Console.ForegroundColor = ConsoleColor.White;
        }


    }
}
