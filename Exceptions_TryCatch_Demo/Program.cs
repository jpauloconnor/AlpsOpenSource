using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_TryCatch_Demo
{
    class AgeChecker
    {
        static void Main(string[] args)
        {
            Age ageObjectVariableName = new Age();
            try
            {
                ageObjectVariableName.showAge();
            }
            catch (AgeException exception)
            {
                Console.WriteLine("TempIsZeroException: {0}", exception.Message);
            }
            Console.ReadKey();
        }
    }
}

public class Age
{
    int age = 0;
    public void showAge()
    {
        if (age >= 115)
        {
            throw (new AgeException("Humans don't usually live that long. Make sure you are entering the right age."));
        }
        //We can add other exception handling here as if else. Negative numbers? 

        else
        {
            Console.WriteLine("{0} years old", age);
        }
    }
}

public class AgeException : Exception
{
    public AgeException(string message) : base(message)
    {
    }
}
