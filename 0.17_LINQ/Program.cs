using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_LINQ                   //Laungue Intagretated N#### Querry
{
    class Program
    {
        static void Main(string[] args)
        {
            List<UsedCar> usedCars = new List<UsedCar>
            {
                new UsedCar(){VIN = "A1", Make = "Hyundai", Model = "Elantra", Price = 5000, Year = 2009},
                new UsedCar(){VIN = "B1", Make = "Hyundai", Model = "Elantra", Price = 3000, Year = 2004},
                new UsedCar(){VIN = "C1", Make = "Ford", Model = "Tarus", Price = 7000, Year = 2010},
                new UsedCar(){VIN = "D1", Make = "Ford", Model = "Escape", Price = 15000, Year = 20014},
                new UsedCar(){VIN = "E1", Make = "BMW", Model = "55i", Price = 9000, Year = 2015},
                new UsedCar(){VIN = "F1", Make = "BMW", Model = "55i", Price = 6500, Year = 2002},
                new UsedCar(){VIN = "G1", Make = "Toyota", Model = "4Runner", Price = 8700, Year = 2011},
            };


            Console.WriteLine("What is the most you'll spend on a car?");
            int spend = 0;
                spend = int.Parse(Console.ReadLine());

            var cars = from car in usedCars
                       where car.Price < spend //&& car.Price > 5000 //&& car.Make == "BMW"
                       select car;
            foreach (var car in cars)
            {                                                                 //{2:C}  :C = "$#"
                Console.WriteLine("The {0} {1} costs less $10,000 at a cost of: {2:C}", car.Year, car.Make, car.Price);
            }
            Console.WriteLine("============");
            Console.WriteLine("");


            //var bmws = from car in usedCars
            //           where car.Make == "BMW"
            //           select car;
            //foreach (var bmw in bmws)
            //{
            //    Console.WriteLine("The {0} {1} is a nice car that costs: ${2}", bmw.Year, bmw.Make, bmw.Price);
            //}
            //Console.WriteLine("============");





            //Console.WriteLine("LINQ with Lambda");
            //var toyotas = usedCars.Where(car => car.Make == "Toyota");          //Condensed

            //    foreach (var toyota in toyotas)
            //{
            //    Console.WriteLine(toyota.Model);
            //}


            //var niceUsedCars = usedCars.Where(car => car.Price > 7500 && car.Make == "BMW" && car.Make == "Ford");
            //foreach (var niceUsedCar in niceUsedCars)
            //{
            //    Console.WriteLine(niceUsedCar.Model);
            //}


            //Console.WriteLine("============");
            Console.ReadLine();
            //Console.WriteLine("============");



        }
    }

    class UsedCar
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
    }



}
