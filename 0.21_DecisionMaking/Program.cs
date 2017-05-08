using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._21_DecisionMaking
{
    class Program
    {
        public static void Main(string[] args)
        {
           string direction = "";
            switch (direction)
            {
                case "8":
                    Console.WriteLine("git status");
                    break;
                case "6":
                    Console.WriteLine("git add .");
                    break;
                case "2":
                    Console.WriteLine("git commit -m 'Added'");
                    break;
                case "4":
                    Console.WriteLine("git branch");
                    break;
                default:
                    Console.WriteLine("git push");
                    break;



            }
        }
    }
}


//Exp1 ? Exp2 : Exp3;

//Where Exp1, Exp2, and Exp3 are expressions.Notice the use and placement of the colon.
//The value of a? expression is determined as follows: Exp1 is evaluated.If it is true, 
//then Exp2 is evaluated and becomes the value of the entire ? expression.If Exp1 is false, 
//then Exp3 is evaluated and its value becomes the value of the expression.