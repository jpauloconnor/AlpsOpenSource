using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Smaller data type to larger type -> converts implicitly
            //Larger data type to smaller data type -> We have to do the conversion.


            //Implicit example - Easy
            int typeCastExampleImplicit = 50;
            float floatConversionExample = typeCastExampleImplicit;//Implicit conversion happens. Float is a bigger data type than int.

            //Another easy example
            int i = 1000;
            float f = i;

            //EXPLICIT CONVERSION - We do the work.
            //Float to int? Bigger to smaller.
            float floatNum = 123.45F;
            //int brokenConversionExample = floatNum;  //There is overflow here. 

            //Typecast operator
            int typeCastExample = (int)floatNum;
            Console.WriteLine("Type Cast Example: {0}", typeCastExample);

            //.NET convert class
            float temperature = 98.6F;
            int temp = Convert.ToInt32(temperature);

            Console.WriteLine("Temperature float: {0} , Converted to Int32: {1}", temperature, temp);


            //Typecast versus Convert class
            //if Float holds too big of a number, there will be an exception.
            float bigNumber = 987654321.123456F;
            int convertBigNumberWithTypecast = (int)bigNumber;

            float bigNumber2 = 987654321.1234F;
            int convertBigNumberWithConvertClass = Convert.ToInt32(bigNumber2);

            Console.WriteLine("Convert big num with TypeCast: {0}, Convert with Convert Class {1}", bigNumber, bigNumber2);


            string age = "39";
            int ageInt = int.Parse(age);
            Console.WriteLine(ageInt);

            //TryParse Demo
            //Note -> TryParse result is actually a Boolean. 
            int tryParseParameter = 0;
            string serialNumber = "100098X";
            bool serialConversion = int.TryParse(serialNumber, out tryParseParameter);
            if (serialConversion)
            {
                Console.WriteLine(tryParseParameter);
            }
            else
            {
                Console.WriteLine("The number you entered is not a valid number");
            }

            //Printing to show the Boolean.
            Console.WriteLine("Serial Number with TryParse: {0}", serialConversion);
            Console.ReadLine();
        }
    }
}
