using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO: Still needs a little work with explanation. Maybe more examples.

    //EXPERIMENT: Try commenting out the null coalescing operator(section 2) and uncommenting the other code(section 1). How is the result different/similar?
 
namespace Null_CoalescingOperator_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int? HoursOfWork = null;

            /* Section 1: This code is a longer version of the Null Coalescing Operator below
            int HoursLeft;
            
            if(HoursOfWork == null)
            {
                HoursLeft = 0;
            }
            else
            {
                HoursLeft = (int)HoursOfWork; //Use (int) to cast/force convert the type into a non-nullabe data type.
            }
            */

            //Section 2: Here's the NULL COALESCING OPERATOR. it's what you all came to see! 
            int HoursLeft = HoursOfWork ?? 0; //This says, if HoursOfWork is null(remember that an int needs to have that ?), use the value after the ??.

            Console.WriteLine("Hours of Work = {0}", HoursLeft);  
            Console.ReadLine();
        }
    }
}
