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
            this.balance = (random.Next(894)*328); //I was having trouble getting the numbers to be different, so I did it somewhat manually.
            this.accountType = "Checking";
            BankAccountNumber();
        }

        //methods

        //call this method when the user wants to withdraw funds
        public override void Withdraw()
        {
            DisplayBalance();

            Console.Write("\r\n\r\nAmount of withdrawal: \t");
            string withdrawalInput = Console.ReadLine();

            double withdrawal = FilterInput(withdrawalInput);

            this.balance -= withdrawal;

            DisplayNewBalance();
        }

        //Generates random 11-digit number for account #
        public override void BankAccountNumber()
        {
            string accountNumber = "";

            for (int i = 0; i < 11; i++)
            {
                accountNumber += random.Next(0, 9).ToString();
            }

            this.accountNumber = accountNumber;
        }

        //call this method to display account information and current balance
        public override void DisplayBalance()
        {
            Console.WriteLine("\r\n\r\n\tAccount Type: " + accountType.ToUpper());
            Console.WriteLine("\r\n\tAccount Number: " + accountNumber);
            Console.WriteLine("\r\n\tBalance: " + BalanceFormat(balance));
            Console.WriteLine();
        }
    }
}
