using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBasicClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer paul = new Customer();
            paul.FirstName = "Paul";
            paul.LastName = "O'Connor";
            paul.AppearWealthy = false;
            paul.PrintCustomer();

            Car newCar = new Car();
            newCar.automatic = true;
            newCar.isFast = true;
            newCar.name = "Pinto";
            newCar.price = 9000;

            Console.WriteLine("{0} owns a {1}, and it's in bad shape.", paul.FirstName, newCar.name);  //In bad shape could be a bool.
            Console.WriteLine("I think it is worth about a ${0} bucks for a trade in.", newCar.price);

                
            //A little bit of inheritance.
            SportsCar sportsCar = new SportsCar();
            sportsCar.madeInUSA = true;
            sportsCar.name = "Corvette";


            //NEEDS REFACTORING HERE VVVV

            if (sportsCar.madeInUSA == true)
            {
                Console.WriteLine("He says he wouldn't mind owning a {0}, especially since they are made in the USA", sportsCar.name);
            }
            else
            {
                Console.WriteLine("He has no interest in owning a {0}, especially since it was not made in the USA", sportsCar.name);
            }




            Console.ReadLine();
        }
    }


    public class Car
    {
        public bool automatic { get; set; }
        public bool isFast { get; set; }
        public string name { get; set; }
        public bool isExpensive { get; set; }
        public int price { get; set; }
        public bool IsPieceOfCrap { get; set; }
    }

    public class Customer
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public bool AppearWealthy { get; set; }

        public void PrintCustomer()
        {
            Console.WriteLine("His name is {0} {1}", FirstName, LastName);
        }

        public void AssessWealth()
        {

            if (AppearWealthy == true)
            {
                Console.WriteLine("He does appear wealthy.");
            }
            else
            {
                Console.WriteLine("He doesn't appear wealthy.");
            }
        }
    }


        //Now we'll work with Subclassing. 
        public class SportsCar : Car
        {
            public bool madeInUSA { get; set; }
            public int cost { get; set; }
        }



}
