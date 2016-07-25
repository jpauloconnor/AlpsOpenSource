using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        public enum Weekday
        {
            Monday = 0,
            Tuesday = 1,
            Wednesday = 2,
            Thursday = 3,
            Friday = 4,
            Saturday = 5,
            Sunday = 6
        };

        static void Main(string[] args)
        {
          
            //The days of the week are a collection of constants inside the enum.
            //Here's an enum, Angie
            
        //Access it by writing the name of the enum then the dot operator and then the constant 
        Console.WriteLine(Weekday.Monday);
            Console.WriteLine(Weekday.Tuesday);

            Console.WriteLine("                           ");


            //An enum is a type, like int, bool or string. 
            // So here's how you can create one.
            //1. write the enum name to access it.
            //2. create a variable name 
            //3. grab the constant that you want with the name.constant


            // 1        2       	      3
            Weekday dayOfTheWeek = Weekday.Wednesday;
            Console.WriteLine(dayOfTheWeek);


            //Here's how we can use a switch with an enum. Play around with this.
            Weekday day = Weekday.Monday;



            //Notice that I can use it in my parameter in a function, too.
            //Instead of string weekday, I say Weekday weekday. The lowercase one is just the paramter name.


            //Here I can use it in a switch.
            switch (day)
            {
                case Weekday.Monday:
                    Console.WriteLine("Somebody's got a case of the Mondays!");
                    break;
                case Weekday.Tuesday:
                    Console.WriteLine("I'll be here all week, Twice on Tuesdays");
                    break;
                case Weekday.Wednesday:
                    Console.WriteLine("It's Hump Day");
                    break;
                case Weekday.Thursday:
                    Console.WriteLine("Almost the weekend");
                    break;
                case Weekday.Friday:
                    Console.WriteLine("Time to go home.");
                    break;
                default:
                    Console.WriteLine("Hang out with kids, and maybe mow the lawn.");
                    break;
            }
            Console.ReadLine();
        }

    }

}

