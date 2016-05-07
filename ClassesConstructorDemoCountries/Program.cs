using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesArraysOfObjectDemoCountries
{
    class Program
    {
        static void Main(string[] args)
        {


            Country honduras = new Country("Honduras", "Tegucigalpa");
            Country bolivia = new Country("Bolivia", "Sucre");
            Country russia = new Country("Russia", "Moscow");
            Country japan = new Country("Japan", "Tokyo");

            russia.GiveBasics();


            //Check this out for using building an array of objects.

            Country[] countries = new Country[6];
            countries[0] = new Country("Guatemala", "Guatemala City");
            countries[1] = new Country("Peru", "Lima");
            countries[2] = new Country("The United States", "Washington D.C.");
            countries[3] = new Country("Spain", "Madrid");
            countries[4] = new Country("Pakistan", "Islamabad");
            countries[5] = new Country("Senegal", "Dakar");


            foreach (var country in countries)
            {

                country.GiveBasics();
             }
            Console.ReadLine();

        }
    }


    class Country
    {


        public Country(string name, string capital)  //Looks like a function. Has parameters. Same name as class.
        {
            this.Name = name;          //"Name" corresponds to getter/setter below & "name" attaches to the parameter
            this.Capital = capital;
        }

        public string Name { get; set; }
        public string Capital { get; set; }

        public void GiveBasics()
        {
            Console.WriteLine("The capital of {0} is {1}.", this.Name, this.Capital);  //That method that Scott did yesterday?
        }
    }

}
