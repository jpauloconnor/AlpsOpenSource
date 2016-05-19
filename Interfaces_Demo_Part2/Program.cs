using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// See Part 1 for rules. This seciton will get into interface chaining. Talking about multiple interfaces inheriting from each other.
/// Disclaimer: The methods are just dummy methods to show the relationships. These aren't necessarily real world examples. 
/// 
/// 1. Interfaces, like classes, can inherit from each other.
/// 2. If an inteface inherits from another(IPerson2) 
///     and the class(Person) inherits only from the inherited interface(IPerson2 and not IPerson1), 
///     the class must implement the property(StateName) of the base interface(IPerson1). 
/// </summary>
namespace Interfaces_Demo_Part2
{
    class Program
    {
        static void Main(string[] args)
        { 

            Person person1 = new Person();
            person1.StateName();
        }
    }

   

    interface IPerson1
    {
        void StateName();
    }

    interface IPerson2 : IPerson1
    {
        void StateLastName();
    }

    interface IPerson3
    {
        void StateAwesome();
    }

    public class Person : IPerson2
    {
        public void StateName()
        {
            Console.WriteLine("My name is Jonas");
        }
        public void StateLastName()
        {
            Console.WriteLine("O'Connor");
        }
    }


    public class Paul : Person, IPerson3
    {
        public void StateAwesome()
        {
            Console.WriteLine("Awesome");
        }
    }
}
