/*
Reference: https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.110).aspx

BRONZE CHALLENGE:
Create a C# List - Hint: List<string>() - of phone numbers. There should be ten numbers in the list.
Make the numbers start at "317.555.0001" and end at "317.555.0010". 

**************************************

SILVER CHALLENGE:
Print the 10 numbers to the console
by ITERATING over the list. 

For a little extra, try printing them out in a different order or even 
a couple different orders.

**************************************

GOLD CHALLENGE: 
Let's pretend that your list has gotten to be hundreds of numbers long. In that list at some point 
you took down Paul's fake phone number at "317.555.2322", and Gavin's fake number at "317.555.4040". But you don't have anything
that connects a name to the number. You just have a bunch of numbers. 
Here are your tasks:
Add those two numbers to the lists.
Pretend you forget what they are except for the 22 for Gavin and 40 for Paul.
Loop through the numbers. 
Print out the following methods:

In the loop, you should print out these messages to the Console:
"Oh yea Paul's phone number is "317.555.4040"." 
Gavin's number is "317.555.2322". 

**************************************

PLATINUM CHALLENGE:
Pretend that you call Gavin 20 times for help.
You call Paul 15 times for help.
The other numbers get called corresponding to their last digit. ("0001" will be called only once.)

Create a method that returns the phone numbers in order from most called to least called. Your
console will show this:
317.555.2322
317.555.4040
317.555.0010
317.555.0009
317.555.0008
etc.

**************************************
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsListChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
