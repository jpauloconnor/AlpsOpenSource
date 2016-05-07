using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integers
{
    class Program
    {
        static void Main(string[] args)
        {


            /*INTEGERS*/
            

            // BASIC OPERATORS TO MEMORIZE NOW - Use these 90% of the time

            //  +   math and string concatenation
            //  =   variable assignment
            //  ==  tests for equality
            //  ()  invokes a method OR can be algebraic order of operations
            //  .   member access operator    
            //  &&  conditional and
            //  ||  conditional or


            //OPERANDS VERSUS OPERATORS
            // OPERANDS - You define the names of those.
            string myName;

            int x, y, a, b;

            //Remember that the "=" sign is an Assignment Operator
            x = 35;
            y = 45;
            a = 29;
            b = 14;

            // + * - / Mathematical Operators
            int howToAdd = 5 + 5000;
            howToAdd = x + 3;

            int howToMultiply = y * y;
            Console.WriteLine(howToMultiply);

            //Test Equality 
            Console.WriteLine(x == y);

            //Less Than, Greater Than, & Both
            Console.WriteLine(x < y);
            Console.WriteLine(x > y);
            Console.WriteLine(x <= y);
            Console.WriteLine(x >= y);

            //Conditional && || 
            Console.WriteLine("What will (b > x) && (x < a) give us? \n" +
                              "Will it be true or false? \n {0}", (b > x) || (x < a));
            Console.WriteLine("How about this one: (a > x) || (b < x) give us? \n" +
                              "Will it be true or false? \n {0}", (a > x) || (b < x));


            // in-line conditional operator - this is cool
            int lj = 23;
            int sc = 30;
            string jordan = (lj == 23) ? "Lebron James" : "Steph Curry";
            string curry = (sc == 23) ? "Lebron James" : "Steph Curry";

            //String interpolation with a few ints.
            Console.WriteLine("Lebron's number is: {0}", lj);
            Console.WriteLine("Steph's number is: {0}", sc);
            
            //Challenges 

            //Bronze call
            Console.WriteLine(bodyTemp);

            //Silver call
            PrintBodyTemp();

            temperatureOutside = 48;
            PrintOutdoorTemp();
            ShortsCheck();

            //Later in the day it warmed up to 65. 
            temperatureOutside = 65;
            PrintOutdoorTemp();
            ShortsCheck();
            Console.ReadLine();       
        }

            /*
            BRONZE:
            Create a variable that is initialized with a normal body temperature. 
            Print the temperature to the console in degrees fahrenheit. 
            This number should have a decimal. For example, "98.2". 
	
            SILVER: 
            Create a method that will print body temperature to the console when the method is called. 
            Your message should read like this: "Your body temperature is currently 98.6 degrees."
	
            GOLD: 
            Discuss the weather in the following way:
            1. Write a method that prints the current weather to the console.
            2. Write a method that checks whether or not it would be ok to wear shorts.
            3. Call both methods. Your console should read something like this:
                "The temperature outside is currently 65 degrees. 
                    It would be a great day for shorts"
	 

            //REFERENCE: https://msdn.microsoft.com/en-us/library/ms173104.aspx

            */
            //Possible Answers
            
            //Bronze
            public static float bodyTemp = 98.6f;
            
            //Silver
            public static int temperatureOutside = 64;

            public static void PrintBodyTemp()
            {
	            Console.WriteLine("Your body temperature is currently {0}.", bodyTemp);
            }

            //Gold
            public static void PrintOutdoorTemp()
            {
	            Console.WriteLine("The temperature outside is currently {0}.", temperatureOutside);
            }

            public static void ShortsCheck()
            {
            if (temperatureOutside <= 60) {
	            Console.WriteLine("It's cold enough that you should be wearing pants.");
            } else {
	            Console.WriteLine("You should be ok in shorts.");
	        }
        }
    }
}
/*
            Other options for challenges
            BRONZE: 

            SILVER: 
                Using up to 4 different integers(a, b, c, d), show FOIL in the console. (x + y)(x - 7)
                Print out the answer. 

            GOLD: 
                Using 4 different integers(a, b, c, d), show four different operations to reach 100 or (e).  
                Print those operations to the console like this example: "The value of (a + b) * c / d is : 100"
                Resource: http://www.tutorialspoint.com/csharp/csharp_operators_precedence.htm
            */
