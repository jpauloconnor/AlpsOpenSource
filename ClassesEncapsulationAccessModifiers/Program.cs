using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEncapsulationAccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {


            Car car = new Car();
            car.name = "Maserati";
            car.customerPrice = 75000;
            car.CalculateGain();

            BankAccountPublic bankAccount = new BankAccountPublic();
            decimal amount = bankAccount.GetAmount();
            Console.WriteLine(amount);

            BankAccountPrivate bankAccountPrivate = new BankAccountPrivate();
            bankAccountPrivate.CustomerName = "Hey";


            BankAccountProtected bankAccountProtected = new BankAccountProtected();
            bankAccountProtected.CloseAccount();
            //Try calling any of the Protected methods on this. You can't do it.

        }
    }
    /*Encapsulation is an object-oriented principle of hiding the internal state and behavior of an object.
It makes code more maintainable.  
For example, the public access modifier allows access to any code but the private access modifier restricts
access to only members of a type. Other access modifiers restrict access in the range somewhere between public
and private. While you can use any of the access modifiers on type members, the only two access modifiers you can
use on types are the public and internal. Here are a few for us to play around with.
*/

    /******Keyword***************Applicable To***************Meaning******************************************		
            public 				  Class, Member				No restrictions
            protected			  Member					Access limited to the class and derived classes
            private				  Member					Access limited to the class.
		
            internal              Class, Member				Access limited to the current assembly		
        protected internal 		  Member					Access limited to current assembly and derived types
		
    **********************************************************************************************************/



    class Car
    {

        //Noitice that this private int can't be accessed outside of the class.
        private int actualCost = 50000;
        public int customerPrice;

        public string name { get; set; }

        public void CalculateGain()
        {
            int gain = customerPrice - actualCost;
            if (gain >= 25000)
            {
                Console.WriteLine("This would be a good customer price for this car.");
            }
            else
            {
                Console.WriteLine("That price is too low for us to make a profit.");
            }

        }
    }


    //Create an employee class. Play around with salary and private var versus public var. 
    //https://msdn.microsoft.com/en-us/library/st6sy9xe.aspx?f=255&MSPPError=-2147217396

    class Employee
    {
        public string name { get; set; }
    }

    //Clarification: The Public, Private, & Protected does not mean that the bank account is public, private, or protected. Those words signify the access levels of types inside the class.

    class BankAccountPublic
    {
        public decimal GetAmount()
        {
            return 1000.00m;
        }
    }

    class BankAccountPrivate
    {
        private string name;
        private int accountNumber;

        public string CustomerName
        {
            get { return name; }
            set { name = value; }
        }

    }

    class BankAccountProtected
    {
        public void CloseAccount()
        {
            ApplyLateCharges();
            CalculateInterest();
        }

        protected virtual void ApplyLateCharges()
        {
            // deduct from account
        }

        protected virtual void CalculateInterest()
        {
            // add to account
        }
    }


    //Notice that this subclass can use the protected methods from the BankAccountProtected class..
    class BankAccountReopenClosedAccount : BankAccountProtected
    {

        public void SettleDebt()
        {
            ApplyLateCharges();
            CalculateInterest();

        }
    }





}
