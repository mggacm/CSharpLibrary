using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Methods_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Netflix TWoEightDaysLater = new Netflix();
            TWoEightDaysLater.Genre = "Horror";
            TWoEightDaysLater.Name = "28 Days Later";
            TWoEightDaysLater.Rating = 4;
            TWoEightDaysLater.TotalMinutes = 22;
            TWoEightDaysLater.GetSuggestion();
            TWoEightDaysLater.ShowRunTime();
            TWoEightDaysLater.ShowWhoView("Anthony", "3:300am");//Console.WriteLine(TWoEightDaysLater.ShowWhoView("Anthony", "3:300am");
            TWoEightDaysLater.ShowMinutesLeft(17);


            Netflix Se7en = new Netflix();
            Se7en.Genre = "Detctive";
            Se7en.Name = "Se7en";
            Se7en.Rating = 3;
            //Se7en.GetSuggestion();

            Netflix Akria = new Netflix();
            Akria.Genre = "Anime";
            Akria.Name = "Akria";
            Akria.Rating = 5;
            //Akria.GetSuggestion();

            Console.ReadLine();
        }
    }
}
