using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTypes_Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            // Value types, stored on the Stack

            int i = 0;        // implicit conversion, too, a.k.a. Int32
            short sh = 32767; // 2^16, or 32768, or +/- 0-32767, a.k.a. Int16
            byte by = 255;    // 2^8, or 256, or +/- 0-255, a.k.a. Byte
            string s = "hey!"; // up to 2 gigs in size, or 2^32 bytes, or Int32.MaxValue, a.k.a. String
            char c = 'i';          // a string is just a linked list of chars, note the single quotes, a.k.a. Char
            var s2 = @"a \tree";
            var s3 = "a \tree";
            bool b = false; // 1 = true, 0 = false, a.k.a. Boolean
            long l = 7; // long int, 64-bit, a.k.a. Int64
            decimal p; // 128-bit precision decimal, very expensive, a.k.a. Decimal
            double d = 7.80; // 64-bit decimal, a.k.a. Double
            float f = 10.8f; // floating point integer, must put f *explicit* conversion afterwards if using a constant, or you could cast as (float)
            decimal dd = 7.80m; // must add the m if using a constant, or you could cast as (decimal)
            int? ni = null; // nullable variables, use .HasValue to determine if they are populated, useful with web services, database results

            Console.WriteLine(s2);
            Console.WriteLine("i = {0}, sh = {1}", i, sh);
            Console.WriteLine(i + sh);

            Console.ReadLine();


        }
    }
}
