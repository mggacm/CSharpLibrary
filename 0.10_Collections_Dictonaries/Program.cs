using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Collections_Dictonaries
{
    class Program
    {
        static void Main(string[] args)
        {
            /*       Dictionary<string, string> dictionary = new Dictionary<string, string>();
                   dictionary.Add("cat", "annoying creature");
                   dictionary.Add("dog", "man's best friend");
                   foreach(KeyValuePair<string, string> pair in dictionary)
                   {
                       Console.WriteLine("{0} is a {1}", pair.Key, pair.Value);
                       }
             */

            //Bronze &&&&&&&&&&&&
            // Dictionary<string, string> createName = new Dictionary<string, string>();

            Dictionary<string, string> winners = new Dictionary<string, string>();

            // createName.Add("string", "string");

            winners.Add("2000", "Gladiator");
            winners.Add("2001", "A Beautiful Mind");
            winners.Add("2002", "Chicago");
            winners.Add("2003", "The Lord of the Rings: The Return of the King");
            winners.Add("2004", "Million dollar Baby");
            winners.Add("2005", "Crash");

            // KeyValuepairs<string, string> anyThing in createName

            foreach (KeyValuePair<string, string> pair in winners)
            {
                Console.WriteLine("{0} best picture is {1}.", pair.Key, pair.Value);
            }


            Dictionary<string, string[]> bestPictureNoms = new Dictionary<string, string[]>();
            bestPictureNoms.Add("2000", new string[] { "Gladiator", "Chocolat", "CTHD" });
            bestPictureNoms.Add("2001", new string[] { "A Beautiful Mind", "Gosford Park", "In the Bedroom" });
            bestPictureNoms.Add("2002", new string[] { "Chicago", "Gangs of NewYork", "Harry Potter CS" });

            foreach(KeyValuePair<string, string[]> bestPictureNom in bestPictureNoms)
            {
                Console.WriteLine("{0}: {1}, {2}, {3}", bestPictureNom.Key, bestPictureNom.Value[0], bestPictureNom.Value[1], bestPictureNom.Value[2]);
            }
            Console.WriteLine("===========================");

            Console.WriteLine(winners["2002"]);
            Console.WriteLine("Please type a year to show the movie that won:");
            string input1 = Console.ReadLine();
            
            if (winners.ContainsKey(input1))
            {
                string valueForKey = winners[input1];
                Console.WriteLine("The best picture in " + input1 + " was " + valueForKey);
            }

            Console.WriteLine("Please type a year to show the movies that were up for an award that year: ");
            string input2 = Console.ReadLine();

            if (bestPictureNoms.ContainsKey(input2))
            {
                string[] valueForKey = bestPictureNoms[input2];
                string nominneeString = string.Join(",", valueForKey);
                Console.WriteLine("the best nominees in " + input2 + " were " + nominneeString);
            }






            Console.ReadLine();
        }
    }
}
