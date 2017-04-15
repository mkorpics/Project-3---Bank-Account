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
            this.accountNumber = BankAccountNumberSavings();
            this.balance = random.Next(999999);
            this.accountType = "Savings";
            this.minimumBalance = 100; //what should this number be?
        }

        //methods

        public override void DisplayBalance()
        {
            Console.WriteLine("\r\n\r\n\tAccount Type: " + accountType.ToUpper());
            Console.WriteLine("\r\n\tAccount Number: " + accountNumber);
            Console.WriteLine("\r\n\tBalance: " + BalanceFormat(balance));
            Console.WriteLine("\r\n\tMinimum Balance: " + minimumBalance);
            Console.WriteLine();
        }

        public override void Withdraw()
        {

            Console.Write("\r\n\r\nAmount of withdrawal: \t");
            double withdrawal = int.Parse(Console.ReadLine());

            while ((balance - withdrawal) < minimumBalance)
            {
                Console.WriteLine("\r\n\r\nI'm sorry, but this amount reduces your balance beyond the minimum amount.");
                Console.WriteLine("Would you like to make another withdrawal? (YES/NO)");
                Console.Write("\r\n\r\n>  ");
                string userResponse = Console.ReadLine();

                if (userResponse.ToUpper() == "NO")
                {
                    Console.WriteLine("\r\n\r\nThank you for your visit.");
                    System.Threading.Thread.Sleep(1500);
                    Console.Clear();
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.Write("\r\n\r\nAmount of withdrawal: \t");
                    withdrawal = int.Parse(Console.ReadLine());
                }
            }

            this.balance -= withdrawal;

            DisplayNewBalance();
        }



    }
}

