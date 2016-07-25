/**** CONDITIONALS ****/
/*
BRONZE CHALLENGE:
    Create a conditional that prompts the user to enter a number from 1-5 to indicate how they're feeling.
    Print a string to the console based on the number   that the user enters.
    For instance, if a user enters a 5, you might print a response that says something like this: "Great to hear that you're feeling so good!"

SILVER CHALLENGE:
    Create a game using conditionals and the ReadLine property.	

GOLD CHALLENGE: 
    Asks users to enter their birthday. Set some conditionals based on age, sign, etc. 
        Example: When is your birthday?
                 > 08/11/1976
                 Oh wow, you're a Leo. Did you know that Leo's love the new and extraordinary? 
                 They despise dull, regular routines and if this is what they are faced with, they will simply create their own drama and excitement.

*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BooleanChallenges
{

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("How are you feeling today from 1-5?");
                string feelingNumber = Console.ReadLine();
                if (feelingNumber == "5")
                {
                    Console.WriteLine("That's great to hear!");
                }
                else if (feelingNumber == "4")
                {
                    Console.WriteLine("Good stuff!");
                }
                else if (feelingNumber == "3")
                {
                    Console.WriteLine("Hope things get better!");
                }
                else if (feelingNumber == "2")
                {
                    Console.WriteLine("Oh. Sorry to hear that.");
                }
                else if (feelingNumber == "1")
                {
                    Console.WriteLine("Dang. We hope your day gets better!");
                }
                else
                {
                    Console.WriteLine("Sorry, we don't understand. Come back later.");
                }
                Console.ReadLine();
            }
        }
    }


