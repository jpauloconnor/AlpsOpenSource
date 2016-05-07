/*BRONZE CHALLENGE
//Use the C# List type to make a string list of 10 phone numbers.
 Make the numbers 317.555.0001 all the way up to 317.555.0010
 Print the 10 numbers to the console by ITERATING over the list.

SILVER CHALLENGE
Let's pretend that Paul's phone number is 317.555.0005. Loop through the list and print that number with the message "Paul's phone number is 317.555.0005. Do the same with Gavin's number, except his ends with 0007.
 
 GOLD CHALLENGE
 . 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneList = new List<string>();
            phoneList.Add("317.555.0001");
            phoneList.Add("317.555.0002");
            phoneList.Add("317.555.0003");
            phoneList.Add("317.555.0004");
            phoneList.Add("317.555.0005");
            phoneList.Add("317.555.0006");
            phoneList.Add("317.555.0007");
            phoneList.Add("317.555.0008");
            phoneList.Add("317.555.0009");
            phoneList.Add("317.555.0010");

            for (var i = 0; i < phoneList.Count; i++)
            {
                Console.WriteLine(phoneList[i]);
            }

            for (var i = 0; i < phoneList.Count; i++)
            {
                Console.WriteLine("Paul's phone number is {0}", phoneList.ElementAt(4));
            }

            for (var i = 0; i < phoneList.Count; i++)
            {
                Console.WriteLine(phoneList.OrderByDescending(true));
                Console.WriteLine(phoneList.RemoveAt(2));

            }
        }
    }
}
