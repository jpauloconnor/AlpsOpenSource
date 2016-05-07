using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*

HELP! My code isn't working for some reason! It's printing this Michael Bolton thing out. I don't want that!
Can you fix it?

I need help!!!!

We also need 2 more subclasses of music and objects to announce some better music, all with the AnnounceGreatMusic Functions.


Also, if you think that Michael Bolton is the best, please leave now.

Reference: http://www.akadia.com/services/dotnet_polymorphism.html

*/

//OVERLOADING: This means that I can create multiple variations on the same function name. I just have to use different parameters for each one. Make sense?

/// <summary>
/// Uncomment the line to work with it.
/// </summary>
/*

    namespace ClassesOverloading
{

public class Program
{
public static void Main()
{

Console.WriteLine("                                    ");
Console.WriteLine("                Object 2            ");

Music ledZeppelin = new Rock();  
ledZeppelin.AnnounceGreatMusic();  //Why is this still printing Michael Bolton? No!!!!!!!!

ledZeppelin.AnnounceGreatMusic();
ledZeppelin.AnnounceGreatMusic("Led Zeppelin", "Physical Graffiti");

//Demo for Fred.
Metal metalBands = new Metal();
metalBands.AnnounceGreatMusic("Metallica", "Rage Against the Machine(I know they're not really metal)", "Black Sabbath", );
Console.ReadLine();

}

}



//change this to abstract
public sealed class Music
{
public virtual void AnnounceGreatMusic() //See overloading note
{
    Console.WriteLine("It's impossible to argue that the greatest music of all time comes from Michael Bolton.");
}

public void AnnounceGreatMusic(string name) //See overloading note
{
    Console.WriteLine("Anything by {0} is the greatest music of all time", name);
}

public void AnnounceGreatMusic(string name, string album) //See overloading note
{

    Console.WriteLine("{0} is the best in the world. Check out {1}. It's a great album.", name, album);
}

//add virtual here for override
public void AnnounceGreatMusic(string band1, string band2, string band3, string band4, string band5)
{
    Console.WriteLine("The five greatest metal bands are {0} {1} {2} {3} {4}", band1, band2, band3, band4, band5);
}
}

public class Rock : Music
{
public override void AnnounceGreatMusic()  //Notice the new keyword here? What's that all about.
{
    Console.WriteLine("Led Zeppelin is the greatest rock band of all time");
}

}

public class Reggae : Music
{
public override void AnnounceGreatMusic()
{
    Console.WriteLine("Culture is one of the greatest reggae bands of all time.");
}
}

public class Classical : Music
{
public override void AnnounceGreatMusic()
{
    Console.WriteLine("Rachmaninoff is the greatest composer of all time.");
}

}

public class Jazz : Music
{
public override void AnnounceGreatMusic()
{
    Console.WriteLine("Miles Davis is the greatest jazz musician of all time. John Coltrane ");
}

}

public class Metal : Music
{
public override void AnnounceGreatMusic(string band1, string band2, string band3, string band4, string band5)
{
    Console.WriteLine("The five greatest metal bands are {0} {1} {2} {3} {4}", band1, band2, band3, band4, band5);
}

}

//OVERLOADING: This means that I can create multiple variations on the same function name. I just have to use different parameters for each one. Make sense?


}
*/
