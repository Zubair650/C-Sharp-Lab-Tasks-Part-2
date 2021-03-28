using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_2
{
    class Saving : BasicBankingInterface
    {
        int Balance;
        public Saving(int Balance)
        {
            this.Balance = Balance;
            Console.WriteLine("The Balance is : " + Balance);
        }

        public bool deposit(int amount)
        {
            Balance += amount;
            Console.WriteLine("Depositted : " + amount);
            Console.WriteLine("Balance after Depositted: " + Balance);

            return true;

        }

        public bool withdraw(int amount)
        {
            if (amount <= Balance * 0.8)
            {
                Balance -= amount;
                Console.WriteLine("Withdrew : " + amount);
                Console.WriteLine("Balance after withdraw: " + Balance);

            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
            return true;

        }
       
    }
}
