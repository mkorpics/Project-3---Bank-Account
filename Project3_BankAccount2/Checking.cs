using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3_BankAccount2
{
    class Checking : Account
    {
        //fields

        //properties

        //constructors
        public Checking()
        {
            this.accountNumber = BankAccountNumberChecking();
            this.balance = random.Next(999999);
            this.accountType = "Checking";
        }

        public Checking(string accountNumber)
        {
            this.accountNumber = accountNumber;
            this.balance = random.Next(99999);
            this.accountType = "Checking";

        }

        //methods

        public override void DisplayBalance()
        {
            Console.WriteLine("\r\n\r\n\tAccount Type: " + accountType.ToUpper());
            Console.WriteLine("\r\n\tAccount Number: " + accountNumber);
            Console.WriteLine("\r\n\tBalance: " + BalanceFormat(balance));
            Console.WriteLine();
        }
    }
}
