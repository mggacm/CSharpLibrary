using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace _0._03_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string occupation;

            firstName = "Matt";
            lastName = "Mistead";
            occupation = "Body Gaurd";
            //
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            //String Interpolation
            Console.WriteLine(
                "Name: {0}" + "\n" + "Occupation: {1}\n{2}", 
                fullName, 
                occupation, 
                "other"
                );

            Console.WriteLine(
                "Name: {2}" + "\n" + "Occupation: {0}\n{1}",
                fullName,
                occupation,
                "another"
                );
            //Challenges 
            Console.WriteLine("----Challenges----");

            string binary;
            binary = ("Binary goes by 2's and starts with");

            Console.WriteLine(binary + ": \n{0}\n{1}\n{2}\n{3}", "0000", "0001", "0010", "0011");


            Console.ReadLine();


        }

    }
}
