using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
     class CurrentAccount : Account
    {
        public CurrentAccount() { }
        public CurrentAccount(string accName, string accNo, double balance) : base(accName, accNo, balance)
        {

        }
        public override void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine("Your acc has been debited by {0} to self", amount);
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }
        public override void SpecialSavings(double amount)
        {
            if (Balance - amount >= Balance * 0.2)
            {
                this.Balance -= amount;
                
                Console.WriteLine("Your acc has been debited by {0} to {1}({2})", amount);
            }
            else
            {
                Console.WriteLine("Can't withdraw money beacuase the balance is less than the 20% of the opening balance");
            }
        }
        public override void OverDraft(double amount)
        {
            if (Balance - amount <= Balance + 5000)
            {
                this.Balance -= amount;

                Console.WriteLine("Your acc has been debited by {0} to {1}({2})", amount);
            }
            else
            {
                Console.WriteLine("Can't withdraw money beacuase the balance is greater than the Balance + 5000");
            }
        }



    }
}
