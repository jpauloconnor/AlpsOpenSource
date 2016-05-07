/* Challenge 
BRONZE:
Create a Dictionary that has all of the academy award winners for best picture from 2000-2005.
Iterate over that dictionary and print it to the console.


SILVER: 
Create a Dictionary of Best Picture Nominees that has the year as the key and an array of movies as the values for the same years.
Iterate over that Dictionary and print the values to the console.

GOLD:
Create two Readline prompts in the console. The first one should say this:
	
	Please type a year in the space below to show the movie that won:
	>

Then after entering a number, you should be able to enter another number and list out all the nominees for a year.
	Please type a year to show the movies that were up for an award that year:
	>
	

*/

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {

        /*********BRONZE*********/
        Dictionary<string, string> bestPicture = new Dictionary<string, string>()
	{
	    {"2000", "American Beauty"},
		{"2001", "Gladiator"},
		{"2002", "Beautiful Mind"},
		{"2003", "Chicago"},
		{"2004", "Lord of the Rings: The Return of the King"},
		{"2005", "Million Dollar Baby"}
	    
	};

        // Loop over pairs with foreach.
        foreach (KeyValuePair<string, string> pair in bestPicture)
        {
            Console.WriteLine("{0}, {1}", pair.Key, pair.Value);
        }


        Console.WriteLine("                                                ");
        Console.WriteLine("                                                ");

        /*********SILVER*********/




        var bestPictureNominees = new Dictionary<string, string[]>()
		{
			{"2000", new string[] {"Movie1", "Movie2", "Movie3"}},
			{"2001", new string[] {"Movasdf", "Movie2", "Movie3"}},
			{"2002", new string[] {"Movasdfa", "Movie2", "Movie3"}},	
				
		};


        foreach (KeyValuePair<string, string[]> pair in bestPictureNominees)
        {
            Console.WriteLine("{0}, {1}, {2}", pair.Key, pair.Value[0], pair.Value[1]);

        }


        Console.WriteLine("                                                ");
        Console.WriteLine("                                                ");

        /*********GOLD*********/
        Console.WriteLine("Please type a year to show the movie that won: ");
        string readLine = Console.ReadLine();

        if (bestPicture.ContainsKey(readLine))
        {
            string value_For_Key = bestPicture[readLine];
            Console.WriteLine("The best picture in " + readLine + " was " + value_For_Key);
        }

        Console.WriteLine("Please type a year to show the movies that were up for an award that year: ");
        string readLineTwo = Console.ReadLine();

        if (bestPictureNominees.ContainsKey(readLine))
        {

            string[] value_For_Key = bestPictureNominees[readLine];
            string s = string.Join(", ", value_For_Key);
            Console.WriteLine("The best nominees in " + readLine + " were " + s);
        }
    }

}
