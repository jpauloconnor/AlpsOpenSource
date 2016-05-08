using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardShortcuts_Chords
{
    /// <summary>
    /// Demo of three slashes for commenting. 
    /// </summary>
   
    class Program
    {
        
        static void Main(string[] args)
        {
            //CHORDS REQUIRE Holding Ctrl and then two keys in a row.
            
            //COMMON CHORDS 

            //Comment & Uncomment
            //Commment and ucomment the the following code:
            Console.WriteLine("Ctrl + K -> Ctrl + C adds a comment");
            Console.WriteLine("Ctrol + K -> Ctrl + U uncomments");

            //XML Comment 
            //Outside of this class and funtion 

           

            //REFACTORING
            //Rename all instances -
            Console.WriteLine("Ctrl R, R");

            //CLick on cat -> Click Ctrl R,R -> Change to dog.
            string cat = "Mabel";
            Console.WriteLine(cat);
            Console.WriteLine(cat.Length);



        }
        
    }
}
