using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBasicClassNetflixChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create object 1. "Use the class/cookie cutter"
            NetflixShow houseOfCards = new NetflixShow();
            houseOfCards.Name = "House of Cards";
            houseOfCards.Rating = 4.5;
            houseOfCards.Genre = "Political Drama";
            houseOfCards.shows();

            //Object 2.
            NetflixShow roseanne = new NetflixShow();
            roseanne.Name = "Roseanne";
            roseanne.Rating = 3.9;
            roseanne.Genre = "Sitcom";
            roseanne.shows();

            //Object 3.
            NetflixShow thundercats = new NetflixShow();
            thundercats.Name = "Thundercats";
            thundercats.Rating = 4.0;
            thundercats.Genre = "Cartoon/Action";
            thundercats.shows();

            Console.ReadLine();


        }
    }

    class NetflixShow
    {
        //Properties
        public string Name { get; set; }
        public double Rating { get; set; }
        public string Genre { get; set; }

        //Methods
        public void shows()
        {
            Console.WriteLine("Name: {0}  Genre: {1}  Rating: {2}", Name, Genre, Rating);
        }

        public string GetSuggestion()
        {
            if (this.Rating >= 4)
                return "You definitely need to watch this show";
            else
                return "You probably won't want to watch this show";
        }
    }
}
