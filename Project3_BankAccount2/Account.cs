using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3_BankAccount2
{
    abstract class Account
    {
        //fields
        protected string accountNumber;
        protected string routingNumber;
        protected double balance;
        protected string accountType;
        protected Random random = new Random();

        //properties?

        //constructor
        public Account()
        {
            this.routingNumber = BankRoutingNumber();
        }

        //methods

        //Generates random 11-digit number for account #
        public abstract void BankAccountNumber();

        //Generates random 9-digit number for bank routing #
        public string BankRoutingNumber()
        {
            string routingNumber = "";

            routingNumber += random.Next(999999999).ToString();

            return routingNumber;
        }

        //formats balance in $ currency
        public string BalanceFormat(double balance)
        {
            string balanceString = balance.ToString();
            string balanceFormat = string.Format("{0:C}", Convert.ToDouble(balanceString));

            return balanceFormat;
        }

        //derived classes will write methods to display current account balances.
        public abstract void DisplayBalance();

        //display balance after transaction
        public void DisplayNewBalance()
        {
            System.Threading.Thread.Sleep(700);
            Console.WriteLine("\r\nThank you for your transaction.");
            System.Threading.Thread.Sleep(700);
            Console.WriteLine("\r\nYour current balance now is: \t" + BalanceFormat(balance));
        }

        public void Deposit(Account type)
        {
            type.DisplayBalance();

            Console.Write("\r\n\r\nAmount of deposit: \t");
            string depositInput = Console.ReadLine();

            double deposit = FilterInput(depositInput);

            this.balance += deposit;

            DisplayNewBalance();
        }

        public abstract void Withdraw();

        public void PrintClientInfo(Client client, Savings savings, Checking checking)
        {
            Console.WriteLine("\r\n\r\n\r\n\tLast Name: " + client.LastName);
            Console.WriteLine("\r\n\tFirst Name: " + client.FirstName);
            Console.WriteLine("\r\n\tUsername: " + client.UserName);
            Console.WriteLine();

            Console.WriteLine("\r\n\tBank Routing Number: " + routingNumber);
            Console.WriteLine();

            Console.WriteLine("\r\n\tAccount Type: " + checking.accountType.ToUpper());
            Console.WriteLine("\r\n\tAccount Number: " + checking.accountNumber);
            Console.WriteLine("\r\n\tBalance: " + checking.BalanceFormat(checking.balance));
            Console.WriteLine();

            Console.WriteLine("\r\n\tAccount Type: " + savings.accountType.ToUpper());
            Console.WriteLine("\r\n\tAccount Number: " + savings.accountNumber);
            Console.WriteLine("\r\n\tBalance: " + savings.BalanceFormat(savings.balance));
            Console.WriteLine("\r\n\tMinimum Balance: " + savings.BalanceFormat(savings.MinimumBalance));
        }

        public double FilterInput(string moneyIn)
        {
            double moneyOut;

            while (!double.TryParse(moneyIn, out moneyOut))
            {
                Console.WriteLine("\r\nI'm sorry. That is not the correct input. Please enter a valid amount.");
                Console.Write("\r\n\r\n>  ");
                moneyIn = Console.ReadLine();
            }

            double.TryParse(moneyIn, out moneyOut);

            return moneyOut;

        }



    }
}
