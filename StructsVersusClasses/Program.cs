using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Struct is a value type(stored on the stack where they are declared)
//Class is a reference type

//Structs are stored on the stack 
//Classes are stored on teh heap
//ATTN: This code is to be used with this video: https://www.youtube.com/watch?v=AGNW0jH1sn0

namespace StructsVersusClasses_Demo_Paul
{
    class Program
    {

        static void Main(string[] args)
        {
            //With value types we can create a copy of the struct or type
            //An int is a kind of struct. Hover over int and check it out.

            int i = 10;
            
            //We can create a copy of the i and call it j.. 
            int j = i;

            //Now j is a copy and it's value will change if we do things to it.
            j = j + 1;
            
            //Note that the value of i does not increment by 1.
            Console.WriteLine("i - {0} && j = {1}", i, j);



            //With reference types, we don't get a copy of the object, we get a copy of the reference.

            //Create an object. Note that C1 is a reference type.
            Customer C1 = new Customer();
            C1.ID = 101;
            C1.Name = "Paul";
          
            //Make a copy of the reference.
            Customer C2 = C1;

            //Operations on one value will affect the other.
            C2.Name = "Mary";

            //Note after running that both names are Mary. Both are pointing to the same object.
            Console.WriteLine("C1.Name = {0} && C2.Name = {1}", C1.Name, C2.Name);
            Console.ReadLine();
        }
        public class Customer
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
    }
}
