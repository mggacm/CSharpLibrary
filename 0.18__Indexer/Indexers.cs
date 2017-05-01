using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//An indexer allows an object to be indexed such as an array.
//When you define an indexer for a class, this class behaves similar to a virtual array.
//You can then access the instance of this class using the array access operator ([]).
namespace _0._18__Indexer
{
    class Indexers
    {

        //element - type this[int index]
        //    {
        //        // The get accessor.
        //        get
        //        {
        //            // return the value specified by index
        //        }

        //        // The set accessor.
        //        set
        //        {
        //            // set the value specified by index
        //        }
        //    }

        private string[] namelist = new string[size];
        static public int size = 10;
        public Indexers()
        {
            for (int i = 0; i < size; i++)
                namelist[i] = "N. A.";
        }

        public string this[int index]
        {
            get
            {
                string tmp;

                if (index >= 0 && index <= size - 1)
                {
                    tmp = namelist[index];
                }
                else
                {
                    tmp = "";
                }

                return (tmp);
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                {
                    namelist[index] = value;
                }
            }
        }
        static void Main(string[] args)
        {
            Indexers names = new Indexers();
            names[0] = "Zara";
            names[1] = "Riz";
            names[2] = "Nuha";
            names[3] = "Asif";
            names[4] = "Davinder";
            names[5] = "Sunil";
            names[6] = "Rubic";
            for (int i = 0; i < Indexers.size; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.ReadKey();

        }
    }
}

