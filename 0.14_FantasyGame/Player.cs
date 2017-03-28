﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_FantasyGame
{   public enum CharacterType
    {
        Assassin = 0,
        BlitzenBlopper = 1,
        Professsor = 2,
        HorseMange = 3,
        TaxMan = 4,
        Human = 5
    }
    class Player
    {   //Properties
        public string PlayerName { get; set; }
        public string Clan { get; set; }
        //public string BattleCry { get; set; }
        public int CurrentPower { get; set; }
        public CharacterType Type { get; set; }

        //Constructs
        //     <name>   <Prop1>     <Prop2>          <Prop3>
        public Player(string name, string clanName, CharacterType type =CharacterType.HorseMange)
        {
            this.PlayerName = name;
            this.Clan = clanName;
            //this.BattleCry = battleCry;
            this.CurrentPower = 100;
            this.Type = type;

        }
        

        //Methods
        public CharacterType ChooseType(int t)
        {
            switch (t)    //If spicifc
            {
                case 0:
                    Console.WriteLine("You are an Assassin.");
                    return this.Type = CharacterType.Assassin;
                    
                case 1:
                    Console.WriteLine("You are a BlitzenBlopper.");
                    return this.Type = CharacterType.BlitzenBlopper;
                   
                case 2:
                    Console.WriteLine("You are a Professor");
                    return this.Type = CharacterType.Professsor;
                   
                case 3:
                    Console.WriteLine("You are a HorseMange.");
                    return this.Type = CharacterType.HorseMange;

                case 4:
                    Console.WriteLine("You are a TaxMan.");
                    return this.Type = CharacterType.TaxMan;
                    
                case 5:
                    Console.WriteLine("You are a Human.");
                    return this.Type = CharacterType.Human;
                    
                default:
                    Console.WriteLine("You are a HorseMange.");
                    return this.Type = CharacterType.HorseMange;
                    
            }
        }
        public void ShowPower()
        {
            Console.WriteLine(this.PlayerName + " has " + this.CurrentPower + "% power.");
        }

        public void Yell()
        {
            Console.WriteLine(PlayerName + " just yelled: \"LeeRyo Jinkins!\""); //Quoests in a string < \" >
        }

        public override string ToString()
        {
            return $"Player Name: {this.PlayerName}\nGamer Name: {this.Clan}\nPlayer Type: {this.Type}";
        }



    }
}
