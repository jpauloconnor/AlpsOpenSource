using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Interface rules - Beginning
/// 1. use interface keyword
/// 2. Use I to name it. Common convention. Not an error.
/// 3. Methods do not have an implementation. You can declare a method, but 
/// you don't implement anything in it.
/// Example: 
///     Correct:
///     void SayHello();
///     Incorrect:
///     void SayHello()
///     {
///         Console.WriteLine("Hello");
///     }
/// 4. Interface members are public by default. Can't use the public keyword or explicit
/// access identifiers. Don't use "public" or "private".
/// 5. Interfaces can't have fields.
/// 6. Can be implemented by a class.
/// 7. A class can inherit from an interface.
/// 8. You must add the method into the class.
/// 9. A class can inherit from multiple interfaces at the same time.
/// 10. If a class inherits from 2 interfaces, it must implement all methods.
/// </summary>
namespace Interfaces_Demo_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.SayHello();
            person1.SayHelloInAnotherLanguage();

            Console.ReadLine();
        }
    }

    interface IPerson
    {
        void SayHello();
    }

    interface IPerson2
    {
        void SayHelloInAnotherLanguage();
    }

    public class Person : IPerson, IPerson2
    {
        public void SayHello()
        {
           Console.WriteLine("Hello");
        }

        public void SayHelloInAnotherLanguage()
        {
            Console.WriteLine("Hola");
        }
    }
}
