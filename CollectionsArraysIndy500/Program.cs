using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsArraysIndy500
{
    class Program
    {
        static void Main(string[] args)
        {
            /**** Fiddle Challenge - Arrays ****/
/*TODO: 


REFERENCE: https://msdn.microsoft.com/en-us/library/0a7fscd0.aspx

https://msdn.microsoft.com/en-us/library/5ts69ce3(v=vs.90).aspx - iterate

initialize an array

Create an array of three tv shows that you like. 

Create an array of strings that lists the winners of the Indy 500.

Create an array that shows the number of the hole and par on Crooked Stick Golf Course. It's right across the street.

*/

//initialization upon declaration
        string[] indyWinners = { "Juan Pablo Montoya", "Ryan Hunter-Reay", "Tony Kanaan", "Dario Franchitti", "Dan Wheldon" };

        //Looping over the array
        foreach (string element in indyWinners)
        {
	        Console.WriteLine(element);
        }
        Console.ReadLine();



        }
    }
}
