/* METHODS - Constructors */
/*
BRONZE 
	Create a MobilePhone class for moblie devices. Have two properties: Make and Model.
	Create a constructor that allows these two arguments to be passed in for a new instance of a phone.
	Create a new phone object that tells what kind of phone you have, and print to the console.
	Example of what should print to the Console - "I own an iPhone 6."
	

SILVER

	Silver Challenge: Print a list of five friends and what they own. 
	Example: Laurissa has an iPhone 6. Ava has the iPhone 5. Kenn has the Samsung Galaxy. Etc...

GOLD:
	Create a laptop class. Create at least 3 properties.
	Create a constructor for the class. 
	Create a method for this class that executes some action.

*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesConstructorChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string paulsPhone = "I own the ";
            MobilePhone myPhone = new MobilePhone("iPhone", "6");
            Console.WriteLine(paulsPhone + myPhone.Brand + " " + myPhone.Version + ".");
            Console.ReadLine();
        }
    }
    public class MobilePhone
    {
        public MobilePhone(string brand, string version)
        {
            this.Brand = brand;
            this.Version = version;
        }
        public string Brand { get; set; }
        public string Version { get; set; }

    }


}


