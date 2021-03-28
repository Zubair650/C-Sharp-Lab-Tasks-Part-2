using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_2
{
    class Overdraft: BasicBankingInterface
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
            Console.WriteLine("The User can withdraw by his current balance + 5000 which must be depositted within a month");
            if (amount <= Balance + 5000)
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
        public Overdraft(int Balance)
        {
            this.Balance = Balance;
            Console.WriteLine("The Balance is : " + Balance);
        }
    }
}
