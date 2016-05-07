using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Example #1 - Using Linq with an array
            //Set up the array
            string[] instructors = { "Paul", "Gavin", "Auri", "Jared" };
            //Set up the query 
            IEnumerable<string> query = from s in instructors
                                        where s.Length == 5
                                        orderby s descending
                                        select s;

            //Loop through the array using the query
            foreach (string name in query)
            {
                Console.WriteLine(name);
            }

            
            //Example #2 - We can use LINQ to query objects.

            //This is done after you build the class below.

            QueryEmployees();
            Console.WriteLine("  BREAK ");
            QueryTypes();
            Console.ReadLine();
        }

        private static void QueryTypes()
        {
            IEnumerable<string> publicTypes =
                from t in Assembly.GetExecutingAssembly().GetTypes()
                where t.IsPublic
                select t.FullName;

            foreach (string name in publicTypes)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }

        private static void QueryEmployees()
        {
            IEnumerable<Employee> employees = new List<Employee>()
            {
            new Employee{ ID=1, Name="Jared", HireDate =new DateTime(2015, 3, 5)},
            new Employee{ ID=2, Name="Gavin", HireDate =new DateTime(2015, 3, 6)},
            new Employee{ ID=3, Name="Auri", HireDate =new DateTime(2015, 3, 6)},
            new Employee{ ID=4, Name="Dave", HireDate =new DateTime(2015, 3, 6)},
            new Employee{ ID=5, Name="Paul", HireDate =new DateTime(2015, 3, 6)}
            };

            IEnumerable<Employee> queryTwo = from e in employees
                                             where e.HireDate.Year == 2015
                                             orderby e.Name
                                             select e;

            foreach (Employee e in queryTwo)
            {
                Console.WriteLine(e.Name);
            }
            Console.ReadLine();
        }
    }



    //This is the first step.
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime HireDate { get; set; }
    }


}
