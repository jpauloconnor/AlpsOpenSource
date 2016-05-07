using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_ConstructorDemo_Paul
{
    class Program
    {
        static void Main(string[] args)
        {

            /*CONSTRUCTOR NOTES: 
No return type. 
Name matches name of class.
Help set default values.
Don't always need them in the class, but create safety.
*/

            //*****TWO OBJECTS FROM CLASS 1 *****//
            Student studentOne = new Student();
            studentOne.name = "Gavin";

            Student studentTwo = new Student();
            studentTwo.name = "Paul";//Play around with commenting this out.
            Console.WriteLine("{0} and {1} are great students.", studentOne.name, studentTwo.name);

            //*****TWO OBJECTS FROM CLASS 2 *****//
            StudentClassTwo s1 = new StudentClassTwo();
            s1.name = "Gavin";

            StudentClassTwo s2 = new StudentClassTwo();
            s2.name = "Paul";  //Play around with commenting this out.
            Console.WriteLine("Great job, {0} and {1}", s1.name, s2.name);
            Console.WriteLine(s1.name.Length + "" + s2.name.Length);



            //*****TWO OBJECTS FROM CLASS 3 *****//
            //Notice that you now create objects inline.
            StudentClassThree student1 = new StudentClassThree("John");
            StudentClassThree student2 = new StudentClassThree("Jenn");

            Console.WriteLine("{0} and {1} are making big changes in coding education.", student1.Name, student2.Name);
            Console.ReadLine();
        }
    }
    //CLASS 1: A CLASS WITHOUT A CONSTRUCTOR
    class Student
    {
        public string name;
    }

    //CLASS 2: Class WITH A CONSTRUCTOR and no parameters
    class StudentClassTwo
    {
        //Constructor 
        public StudentClassTwo()
        {
            name = "";
        }

        public string name = "";
    }
    //CLASS 3: WITH CONSTRUCTOR USING A PARAMETER

    class StudentClassThree
    {
        //constructor
        public StudentClassThree(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

    }

}

