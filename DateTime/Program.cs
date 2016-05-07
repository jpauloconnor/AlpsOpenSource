using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExercises
{
    class Program
    {
        static void Main(string[] args)
        {
                        /* Fiddle Challenge
            //https://msdn.microsoft.com/en-us/library/system.datetime(v=vs.110).aspx

            BRONZE: 
            Print your birthday to the console in three different formats:
            My birthday is 8/11/1976.

            SILVER:
            Using the DateTime class, create some logic that will print to the Console how many days old you are. 

            GOLD:
            Can you use DateTime to check the date and time overseas in a couple different countries? 
            How about creating a timeline of key battles from World War II?

            */

            //Now is a static property.
            DateTime myValue = DateTime.Now;

            Console.WriteLine(myValue.ToString());
            Console.WriteLine(myValue.ToShortDateString());
            Console.WriteLine(myValue.ToShortTimeString());
            Console.WriteLine(myValue.ToLocalTime());
            Console.WriteLine(myValue.ToLongDateString());
            Console.WriteLine(myValue.AddDays(30));
            Console.WriteLine(myValue.AddHours(3).ToShortTimeString());



            /***  BRONZE ***/
            DateTime myBirthday = new DateTime(1976, 8, 11);
            Console.WriteLine("My birtday is {0}.", myBirthday.ToShortDateString());

            /***  SILVER ***/
            DateTime myBday = DateTime.Parse("8/11/1976");
            TimeSpan myAge = DateTime.Now.Subtract(myBday);
            Console.WriteLine(myAge.Days);

            DateTime KennBday = DateTime.Parse("7/31/1992");
            TimeSpan KennsAge = DateTime.Now.Subtract(KennBday);
            Console.WriteLine(KennsAge.Days);

            DateTime sBday = DateTime.Parse("10/12/1968");
            TimeSpan StepAge = DateTime.Now.Subtract(sBday);
            Console.WriteLine(StepAge.Days);

            DateTime julieday = DateTime.Parse("09/02/1977");
            TimeSpan julieAge = DateTime.Now.Subtract(julieday);
            Console.WriteLine(julieAge.Days);

            DateTime jennday = DateTime.Parse("02/26/1972");
            TimeSpan jennAge = DateTime.Now.Subtract(jennday);
            Console.WriteLine(jennAge.Days);

            System.DateTime today = System.DateTime.Now;
            System.TimeSpan duration = new System.TimeSpan(360, 0, 0, 0);
            System.DateTime answer = today.Add(duration);
            System.Console.WriteLine("{0:dddd}", answer);

            Console.ReadLine();


            /***  GOLD ***/
        }
    }
}
