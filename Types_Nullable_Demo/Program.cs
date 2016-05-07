using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types_Nullable_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Strings are reference types.
            //Booleans and ints are value types. 

            //Nullable Types 
            //Nullable types bridge the difference between C# types & database types

            //A string is reference type and can have null values.
            string Name = null;

            //When we print, notice that Name is empty. Why? We have no value.
            Console.WriteLine("The value for name is:{0}", Name);


            //Value types can not have null values.
       
            //int it = null;
            //To make a value type nullable, add a question mark.
            int? i = null;

            //Let's say that we don't want to make users answer this on a form.
            //3 answers:
            //1. IsHappy = true, IsHappy = false, IsHappy = null(did not answer)
            bool? isHappy = null;

            Console.WriteLine(isHappy);
            Console.ReadLine();
        }
    }
}
