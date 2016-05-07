using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here's an example of a List
            var conceptList = new List<string>();
            conceptList.Add("Types");
            conceptList.Add("Strings");
            conceptList.Add("Booleans");
            conceptList.Add("Ints");
            conceptList.Add("Floats");
            conceptList.Add("Doubles");
            conceptList.Add("Decimals");
            conceptList.Add("Methods");
            conceptList.Add("Loops");
            conceptList.Add("Public versus Private");
            conceptList.Add("operators");
            conceptList.Add("Keywords");
            conceptList.Add("Loops");
            conceptList.Add("Conditionals");
            conceptList.Add("DateTime");
            conceptList.Add("Classes: Abstract");
            conceptList.Add("Classes: Sealed");
            conceptList.Add("Classes: Inheritance");
            conceptList.Add("Classes: Inheritance & Subclassing");
            conceptList.Add("Classes: Inheritance & Parent Class");
            conceptList.Add("Classes: Polymorphism & Overloading");
            conceptList.Add("Encapsulation: Access modifiers");
            conceptList.Add("Methods: Void");
            conceptList.Add("Methods: Public");
            conceptList.Add("Methods: return");
            conceptList.Add("Classes: Properties");
            conceptList.Add("Classes: Get & Set");
            conceptList.Add("Classes: constructors");
            conceptList.Add("Collections: Arrays");
            conceptList.Add("Collections: Dictionaries");
            conceptList.Add("Collections: Lists");
            conceptList.Add("Enums");
            conceptList.Add("Structs");
            conceptList.Add("Switch Statements");

            foreach (var item in conceptList)
            {
                Console.WriteLine(item);
              
            }

            Console.ReadLine();
        }
    }
}
