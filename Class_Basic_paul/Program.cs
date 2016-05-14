using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Basic_paul
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
            newCar.Automatic = true;
            newCar.IsFast = true;
            newCar.Name = "Pinto";
            newCar.Price = 9000;

            Car mustang = new Car();
            mustang.Name = "Mustang";
            mustang.Price = 100000;
            mustang.IsFast = true;



            Console.WriteLine("{0} owns a {1}, and it's in bad shape.", paul.FirstName, newCar.Name);  //In bad shape could be a bool.
            Console.WriteLine("I think it is worth about a ${0} bucks for a trade in.", newCar.Price);


            //A little bit of inheritance.
            SportsCar sportsCar = new SportsCar();
            sportsCar.MadeInUSA = true;
            sportsCar.Name = "Corvette";


            //NEEDS REFACTORING HERE VVVV

            if (sportsCar.MadeInUSA == true)
            {
                Console.WriteLine("He says he wouldn't mind owning a {0}, especially since they are made in the USA", sportsCar.Name);
            }
            else
            {
                Console.WriteLine("He has no interest in owning a {0}, especially since it was not made in the USA", sportsCar.Name);
            }
            
            Console.ReadLine();
        }
    }

    public class Car
    {
        public bool Automatic { get; set; }
        public bool IsFast { get; set; }
        public string Name { get; set; }
        public bool IsExpensive { get; set; }
        public int Price { get; set; }
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
        public bool MadeInUSA { get; set; }
        public int Cost { get; set; }
    }


}
