using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Multidimensional_JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jagged array is an array of arrays
            //Jagged because all inner arrays can be different sizes.
        
            string[][] jaggedArray = new string[3][]
            {
                new[] {"a","b"},
                new[] {"a","b","c"},
                new[] {"a", "b", "c", "d"}
            };

            Console.WriteLine(jaggedArray[1][2]);
            Console.ReadLine();
        }
    }
}
