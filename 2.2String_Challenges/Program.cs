using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2String_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            BRONZE CHALLENGE:
                Research the MSDN to learn about working with strings in C#. Composite formatting.
                Create examples that show techniques for basic string manipulation. You'll need to show how to concatenate multiple strings,
                use composite formating, show how to use escapes, and how to manipulate numbers(eg, dollars & commas).

                Composite reference: https://msdn.microsoft.com/en-us/library/txafckwd(v=vs.110).aspx	
                REFERENCE: https://msdn.microsoft.com/en-us/library/ms173104.aspx

            SILVER CHALLENGE:
                Create a note to a potential employer that states your goals as a developer. Include the date in the string by 
                creating a date string that is converted to a short date string. 
                Here's an example: 	
                "Dear Mr. Jones,
                Today is 3/11/2016. I'm enjoying class, and I think I like C# the best. 
                I'd like to get a job as a developer after I finish this course."

                REFERENCE: https://msdn.microsoft.com/en-us/library/ms228504.aspx

            GOLD CHALLENGE: 
                Create 2 strings: Your username in lower case, and your username in uppercase.
                Write code that compares the two strings and prints whether or not they are equal.
                Print one sentence that says that they are equal. Print another string that says taht they are not equal. 
                REFERENCE https://msdn.microsoft.com/en-us/library/cc165449.aspx
            */


            /**** Bronze ***/
            string aString = string.Format("I heard him say \"What's up?\"");
            Console.WriteLine(aString);

            string myString = string.Format("{0:C}", 123.45);
            Console.WriteLine(myString);

            string bString = string.Format("{0:P}", .123);
            Console.WriteLine(bString);

            string phoneString = string.Format("My phone number is: {0: (###)-###-####}", 1234567890);
            Console.WriteLine(phoneString);

            string instructor = "Paul";
            string instructor2 = "Gavin";
            string confusedItemOne = "jQuery";
            string confusedItemTwo = "objects";
            string confusedItemThree = "functions";

            Console.WriteLine("Hello " + instructor + " and " + instructor2 + " I'm doing great, but I'm still struggling with "
                              + confusedItemOne + ", " + confusedItemTwo + ", " + confusedItemThree + ".");


            /*** Silver ***/
            string potentialEmployerName = "Mr. Jones";
            string date = DateTime.Today.ToShortDateString();

            string str = "Dear " + potentialEmployerName + ". Today is " + date + ".";
            string messageUnderstand = " I'm enjoying class. I think I like C# the best out of anything.";
            string messageGoal = " I'd like to get a job as a developer after I finish this course.";

            str += messageUnderstand;
            str += messageGoal;

            Console.WriteLine(str);

            /*** Gold ***/

            string usernameLow = @"jamespauloconnor";
            string usernameUp = @"JAMESPAULOCONNOR";

            // Use the overload of the Equals method that specifies a StringComparison.
            // Ordinal is the fastest way to compare two strings.

            bool result = usernameLow.Equals(usernameUp, StringComparison.OrdinalIgnoreCase);
            bool resultTwo = usernameLow.Equals(usernameUp, StringComparison.Ordinal);

            Console.WriteLine("{0} and {1} are {2}", usernameLow, usernameUp,
                                result ? "equal." : "not equal.");

            Console.WriteLine("{0} and {1} are {2}", usernameLow, usernameUp,
                                resultTwo ? "equal." : "not equal.");

            Console.ReadLine();
        }
    }
}
