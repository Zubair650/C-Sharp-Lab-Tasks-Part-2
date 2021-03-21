using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a2 = new CurrentAccount("Zubair Ahmed", "146", 50000);

            a2.Withdraw(49600);
            a2.SpecialSavings(500);
            a2.OverDraft(1000);

        }
    }
}
