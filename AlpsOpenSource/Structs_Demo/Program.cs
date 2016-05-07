using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var Paul = new AddressBookEntry();

            Paul.AddressLine1 = "123 Coder Boulevard";
            Paul.AddressLine2 = "Attn: Awesomeness";
            Paul.City = "Westfield";
            Paul.State = "IN";
            Paul.ZIP = "46074";

            var Gavin = new AddressBookEntry()
            {
                FirstName = "Gavin",
                LastName = "Robley",
                AddressLine1 = "123 Please Fix My Computer Blvd.",
                City = "San Bernadino",
                State = "CA",
                ZIP = "90210"
            };

            Console.WriteLine(Paul.AddressLine1);
            Console.WriteLine("Gavin's address is {0}", Gavin.AddressLine1);
            Console.WriteLine(Paul.GetAddress());

            var addresses = new List<AddressBookEntry>();
            addresses.Add(Paul);
            addresses.Add(Gavin);

            //Another way to create an object and add a full entry. 
            addresses.Add(new AddressBookEntry()
            {
                FirstName = "Scott",
                LastName = "Jones",
                AddressLine1 = "1150 West 116th St",
                City = "Carmel",
                State = "IN",
                ZIP = "46032"
            });

            Console.WriteLine(addresses.Count);

            Console.WriteLine("                      ");
            Console.WriteLine("                      ");


            foreach (var address in addresses)
            {
                Console.WriteLine(address.GetAddress());
            }
            Console.ReadLine();
        }
    }
    struct AddressBookEntry
    {
        //Variables
        public string FirstName;
        public string LastName;
        public int Age;
        public string AddressLine1;
        public string AddressLine2;
        public string City;
        public string State;
        public string ZIP;

        //Custom Methods
        public string GetAddress()
        {
            var result = String.Format("Address: {0}{4}\nCity: {1}\nState: {2}\nZIP: {3}",
                /* 0 */ this.AddressLine1,
                /* 1 */ this.City,
                /* 2 */ this.State,
                /* 3 */ this.ZIP,
                /* 4 */ String.IsNullOrWhiteSpace(this.AddressLine2) ?
                                 "" : String.Format("\n{0}", this.AddressLine2)
                                );

            return result;
        }
    }
}
