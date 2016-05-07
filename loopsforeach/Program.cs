/*


BRONZE: 
	Use the ch type to print "Hello World" going vertically down the page.

SILVER: 
	Do the same thing in a single line.
	
GOLD: 
	Print your name using an array built with chars. It's a type we haven't seen yet. 
	Use Unicode or hexidecimal numbers to print your name.

	Use the hexadecimal char array with a foreach loop to print your name going down the console. 


char: https://msdn.microsoft.com/en-us/library/x9h8tsay.aspx
foreach: https://msdn.microsoft.com/en-us/library/ttw7t8t6.aspx

*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopsforeach
{
	class Program
	{
		static void Main(string[] args)
		{


			/*** BRONZE ***/
			foreach (var ch in "Hello World")
			{
				Console.WriteLine("{0}", ch);	// strings are just linked lists of chars
			}

			/*** SILVER ***/

			// that was the same as ...
			foreach (char ch in "Hello World") Console.WriteLine("{0}", ch); // single lines can omit braces

			Console.WriteLine(" ");


			/*** GOLD ****/
			char[] chars = new char[4];

			chars[0] = '\x0050';
			chars[1] = '\x0061';
			chars[2] = '\x0075';
			chars[3] = '\x006C';

			foreach (char c in chars)
			{
				Console.WriteLine(c);
			}

			Console.ReadLine();

		}
	}
}
