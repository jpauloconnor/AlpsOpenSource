using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesInheritanceClassicAnimalDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //We can create an Object from the base class if the base class is not abstract.
            Animal georgeTheAnimalSteel = new Animal();
            georgeTheAnimalSteel.GetMad();

            //A few objects built from subclasses of Animal.

            Bear barryTheBear = new Bear();
            barryTheBear.LatinName = "Ursidae";
            barryTheBear.GetMad();
            barryTheBear.EatHiker();
            barryTheBear.numberOfSalmonPerDay = 10;
            barryTheBear.StateType();

            Cat coryTheCat = new Cat();

            Dog donnie = new Dog();

            Elephant eleanor = new Elephant();

        }
    }
    // ********CLASSES: Inheritance focus*******//

    //Possibly discuss Abstract class later
    public class Animal
    {
        //Fields
        string _latinName;


        //Properties - get() & set() properties

        public string LatinName
        {
            get
            {
                return _latinName;
            }

            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name can't be empty");
                }
                else
                {
                    _latinName = value.Trim();
                }
            }
        }
        public string Habitat { get; set; }

        public int NumberOfLegs { get; set; }
        public int Weight { get; set; }
        public int AverageNumOffspring { get; set; }

        public bool HasFur { get; set; }
        public bool HasWings { get; set; }
        public bool CanFly { get; set; }

        //Methods - execute some function
        //Need to discuss overideability of that virtual keyword gives.
        public virtual void StateType()
        {
            Console.WriteLine("I am an animal.");
        }

        public virtual void GetMad()
        {
            Console.WriteLine("ROAR!!!");
        }
    }

    //INHERITANCE - Subclasses

    //BEAR Class
    class Bear : Animal
    {

        //PROPERTIES
        public bool hibernate { get; set; }
        public bool stealsPicnicBaskets { get; set; }
        public int numberOfSalmonPerDay { get; set; }
        public string temperatureOfPorridge { get; set; } //Hot cold just right

        //METHODS
        public override void StateType()
        {  //Discuss how the virtual keyword allows us to do this.
            Console.WriteLine("I am a bear");
        }

        public void EatHiker()
        {
            Console.WriteLine("I just ate a hiker.");
        }

        public override void GetMad()
        {
            Console.WriteLine("Hello, I'm a big bad bear.");
        }
    }

   

    class Cat : Animal
    {
        public override void GetMad()
        {

            Console.WriteLine("Hissssss!");
        }
    }
    class Dog : Animal
    {

    }
    class Elephant : Animal
    {

    }
    class Lion : Animal
    {

    }


    //We can write a subclass of the subclass.
    class BabyBear : Bear
    {

    }


}
