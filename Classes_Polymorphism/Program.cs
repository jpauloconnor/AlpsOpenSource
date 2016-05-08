using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Polymorphism allows you to invoke derived class methods through a base class reference during runtime.

namespace Classes_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here we set up an array of objects.
             
            Car[] cars = new Car[3];

            //The first one will use the default fields and default method.
            cars[0] = new Car();

            //Just changing the carModel field in the next 2.
            cars[1] = new TwoDoor();
            cars[1].carModel = "Focus";

            cars[2] = new FourDoor();
            cars[2].carModel = "Taurus";


            //Polymorphism allows you to use derived class methods along with base class reference variables at run time.
            //Here we're using a base class variable - car - to run all of the subclasses/derived classes methods - PrintCarName at run time.
            foreach (Car car in cars)
            {
                car.PrintCarName();
            }

            Console.ReadLine();
        }
    }

    //Base class
    public class Car
    {
        //These fields have to be public to be usable in the subclasses.
        public string carMake = "Ford";
        public string carModel = "Fairlane";

        //We need this virtual keyword to override the method in the subclasses.
        public virtual void PrintCarName()
        {
            Console.WriteLine("{0} {1}", carMake, carModel);
        }
    }
    
    public class TwoDoor : Car
    {
        //Must have the override keyword.
        public override void PrintCarName()
        {
            Console.WriteLine("{0} {1} Two Door Coupe", carMake, carModel);
        }
    }
    public class FourDoor : Car
    {
        public override void PrintCarName()
        {
            Console.WriteLine("{0} {1} Four Door Sedan", carMake, carModel);
        }
    }
}
