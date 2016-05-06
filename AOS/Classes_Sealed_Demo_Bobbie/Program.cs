using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes_Sealed_Demo_Bobbie
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SealedClass sealedCls = new SealedClass();
            int total = sealedCls.Add(4, 5);
            Console.WriteLine("Total = " + total.ToString());
            Console.ReadLine();
        }
    }

    sealed class SealedClass
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}
