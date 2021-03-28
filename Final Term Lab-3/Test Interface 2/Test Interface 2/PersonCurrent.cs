using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_2
{
    class PersonCurrent : BasicBankingInterface
    {   
        int Balance;
        
        public bool deposit(int amount)
        {
            Balance += amount;
            Console.WriteLine("Depositted : " + amount);
            Console.WriteLine("Balance after Depositted: " + Balance);

            return true;

        }

        public bool withdraw(int amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine("Withdrew : " + amount);
                Console.WriteLine("Balance after withdraw: "+ Balance);
                
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
            return true;

        }
        public PersonCurrent(int Balance)
        {
            this.Balance = Balance;
            Console.WriteLine("The Balance is : " + Balance);
        }

        /* 
         public int Current { get; set; }
         public int Savings { get; set; }
         public int Overdraft { get; set; }*/

    }
}
