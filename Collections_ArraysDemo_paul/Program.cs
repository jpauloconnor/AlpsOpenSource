using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_ArraysDemo_paul
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is just a few basic way to add items to an array.
            //The index starts at 0. 0, 1, 2, 3, 4
            int[] ages = new int[5];
            ages[0] = 37;
            ages[1] = 40;
            ages[2] = 41;
            ages[3] = 35;
            ages[4] = 26;

            //To print one specific number:
            Console.WriteLine(ages[2]);

            //To print the whole array use a foreach:
            foreach (var age in ages)
            {
                Console.WriteLine(age);
            }

            //Arrays are strongly typed. You can't add a string to an int array and vice versa.
            //Arrays cannot grow in size once initialized.
            //Be aware of the index offest -> The array starts at 0. To access it, we need to use that access index 
            //ages[5] = "Paul";  -> This won't work.
            Console.ReadLine();
        }
    }
}
