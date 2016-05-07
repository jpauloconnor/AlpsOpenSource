using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_ConstructorChallengeWithAnswer_paul
{
    class Program
    {
        static void Main(string[] args)
        {
            string paulsPhone = "I own the ";
            MobilePhone myPhone = new MobilePhone("iPhone", "6");
            Console.WriteLine(paulsPhone + myPhone.Brand + " " + myPhone.Version + ".");
            Console.ReadLine();
        }
    }
    public class MobilePhone
    {
        public MobilePhone(string brand, string version)
        {
            this.Brand = brand;
            this.Version = version;
        }
        public string Brand { get; set; }
        public string Version { get; set; }

    }


}



