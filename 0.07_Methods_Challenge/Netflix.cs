using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Methods_Challenge
{
    class Netflix
    {
        //Properties
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Rating { get; set; }
        public int TotalMinutes { get; set; }

        //Methods
        /// <summary>
        /// Methods with no returns
        /// </summary>
        public void GetSuggestion()
        {
            if (this.Rating == 5)
                Console.WriteLine("You should definitly watch " + Name + ".");
            else if ((Rating == 4))
                Console.WriteLine("You will probably like " + Name + ".");
            else if ((Rating == 3))
                Console.WriteLine("You might like " + Name + ".");
            else if ((Rating == 2))
                Console.WriteLine("" + Name + " is okay.");
            else if ((Rating == 1))
                Console.WriteLine("Noone Likes " + Name + ".");
            else
                Console.WriteLine("Noone Likes " + Name + ".");

        }
        /// <summary>
        /// Methods that return the value.
        /// </summary>
        /// <returns></returns>
       public int ShowRunTime()
        {
            Console.WriteLine(Name + "is " + this.TotalMinutes + " minutes long.");
            return this.TotalMinutes;
        }        

        ///Methods that have parameters
        public string ShowWhoView(string user, string time)
        {
            string details = user + " watched " + Name + " at " + time ;
            Console.WriteLine(details); //either or
            return user;
        }
        
        public int ShowMinutesLeft(int NumberOfMinutesWatched)
        {
           int  MinutesLeft = this.TotalMinutes - NumberOfMinutesWatched;
            Console.WriteLine("Ther are " + MinutesLeft + " minutes left.");
                return MinutesLeft;
        }


    }
}
