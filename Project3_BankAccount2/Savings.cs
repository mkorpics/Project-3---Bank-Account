using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3_BankAccount2
{
    class Savings : Account
    {
        //fields
        private double minimumBalance;

        //properties
        public double MinimumBalance
        {
            get { return minimumBalance; }
        }

        //constructors
        public Savings()
        {
            this.balance = (random.Next(243)*2484);
            this.accountType = "Savings";
            this.minimumBalance = 100; //what should this number be?
            BankAccountNumber();
        }

        //methods

        //Generates random 11-digit number for account #
        public override void BankAccountNumber()
        {
            this.accountNumber = Convert.ToInt64((random.Next(17000, 18000 ) * 99999)+8374865432).ToString(); //having trouble getting numbers to differ, so I did it somewhat manually
        }

        //call this method to display account information and current balance
        public override void DisplayBalance()
        {
            Console.WriteLine("\r\n\r\n\tAccount Type: " + accountType.ToUpper());
            Console.WriteLine("\r\n\tAccount Number: " + accountNumber);
            Console.WriteLine("\r\n\tBalance: " + BalanceFormat(balance));
            Console.WriteLine("\r\n\tMinimum Balance: " + BalanceFormat(minimumBalance));
            Console.WriteLine();
        }

        //call this method when the user wants to withdraw funds
        public override void Withdraw()
        {

            DisplayBalance();

            Console.Write("\r\n\r\nAmount of withdrawal: \t");
            string withdrawalInput = Console.ReadLine();

            double withdrawal = FilterInput(withdrawalInput);

            //make sure user can't deplete account beyond minimum balance (if so, offer chance to withdraw a valid amount)
            while ((balance - withdrawal) < minimumBalance)
            {
                Console.WriteLine("\r\n\r\nI'm sorry, but this amount reduces your balance beyond the minimum amount.");
                Console.WriteLine("Would you like to make another withdrawal? (YES/NO)");
                Console.Write("\r\n\r\n>  ");
                string userResponse = Console.ReadLine();

                if (userResponse.ToUpper() == "NO")
                {
                    withdrawal = 0;
                    break;
                }
                else
                {
                    Console.Clear();
                    DisplayBalance();
                    Console.Write("\r\n\r\nAmount of withdrawal: \t");
                    withdrawal = int.Parse(Console.ReadLine());
                }
            }

            this.balance -= withdrawal;

            DisplayNewBalance();
        }



    }
}

