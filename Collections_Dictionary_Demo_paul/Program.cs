using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Dictionary_Demo_paul
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("cat", "annoying creature");
            dictionary.Add("dog", "man's best friend");

            foreach (KeyValuePair<string, string> pair in dictionary)
            {
                Console.WriteLine("{0}, {1}", pair.Key, pair.Value);
            }
            
            Console.ReadLine();
               
        }
    }
}
