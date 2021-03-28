using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_2
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonCurrent p1 = new PersonCurrent(10000);
            Console.WriteLine("Current Account");
            p1.withdraw(1000);
            p1.deposit(500);
            Console.WriteLine("*********************************");

            Saving s1 = new Saving(10000);
            Console.WriteLine("Saving Account");
            s1.withdraw(1000);
            s1.deposit(500);
            Console.WriteLine("*********************************");

            Overdraft o1 = new Overdraft(10000);
            Console.WriteLine("Overdraft Account");
            o1.withdraw(1000);
            o1.deposit(500);
            Console.WriteLine("*********************************");


        }
    }
}
