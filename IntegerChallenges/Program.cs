using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerChallenges
{
    class Program
    {
        static void Main(string[] args)
        {


/*
BRONZE: 



SILVER: 
Using up to 4 different integers(a, b, c, d), show FOIL in the console. (x + y)(x - 7)
Print out the answer. 

GOLD: 
Using 4 different integers(a, b, c, d), show four different operations to reach 100 or (e).  
Print those operations to the console like this example: "The value of (a + b) * c / d is : 100"
Resource: http://www.tutorialspoint.com/csharp/csharp_operators_precedence.htm
*/


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

// = Assignment Operators
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


// in-line conditional operator
int lj = 23;
int sc = 30;
string jordan = (lj == 23) ? "Lebron James" : "Steph Curry";
string curry = (sc == 23) ? "Lebron James" : "Steph Curry";

Console.WriteLine("Lebron's number is: {0}", lj);
Console.WriteLine("Steph's number is: {0}", sc);

Console.ReadLine();

        }
    }
}
