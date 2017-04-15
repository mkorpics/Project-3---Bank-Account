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
        protected double balance;
        protected string accountType;

        //properties?

        //default constructor
        public Account()
        {

        }

        //methods
        
        //formats balance in $ currency
        public string BalanceFormat(double balance)
        {
            string balanceString = balance.ToString();
            string balanceFormat = string.Format("{0:C}", Convert.ToDouble(balanceString));

            return balanceFormat;
        }

        public void DisplayBalanceChecking()
        {
            Console.WriteLine("\r\n\r\n\tAccount Type: " + accountType.ToUpper());
            Console.WriteLine("\r\n\tAccount Number: " + accountNumber);
            Console.WriteLine("\r\n\tBalance: " + BalanceFormat(balance));
            Console.WriteLine();
        }

        public void DisplayBalanceSavings(Savings savings)
        {
            Console.WriteLine("\r\n\r\n\tAccount Type: " + accountType.ToUpper());
            Console.WriteLine("\r\n\tAccount Number: " + accountNumber);
            Console.WriteLine("\r\n\tBalance: " + BalanceFormat(balance));
            Console.WriteLine("\r\n\tMinimum Balance: " + savings.MinimumBalance);
            Console.WriteLine();
        }

        //display balance after transaction
        public void DisplayNewBalance()
        {
            System.Threading.Thread.Sleep(700);
            Console.WriteLine("\r\nThank you for your transaction.");
            System.Threading.Thread.Sleep(700);
            Console.WriteLine("\r\nYour current balance now is: \t" + BalanceFormat(balance));
        }

        public void Deposit()
        {
            Console.Write("\r\n\r\nAmount of deposit: \t");
            double deposit = double.Parse(Console.ReadLine());

            this.balance += deposit;

            DisplayNewBalance();
        }

        public virtual void Withdraw()
        {
            Console.Write("\r\n\r\nAmount of withdrawal: \t");
            double withdrawal = double.Parse(Console.ReadLine());

            this.balance -= withdrawal;

            DisplayNewBalance();
        }

        public void PrintClientInfo(Client client, Savings savings, Checking checking)
        {
            Console.WriteLine("\r\n\r\n\r\n\tLast Name: " + client.LastName);
            Console.WriteLine("\r\n\tFirst Name: " + client.FirstName);
            Console.WriteLine("\r\n\tUsername: " + client.UserName);
            Console.WriteLine();

            Console.WriteLine("\r\n\tAccount Type: " + checking.accountType.ToUpper());
            Console.WriteLine("\r\n\tAccount Number: " + checking.accountNumber);
            Console.WriteLine("\r\n\tBalance: " + checking.BalanceFormat(balance));
            Console.WriteLine();

            Console.WriteLine("\r\n\tAccount Type: " + savings.accountType.ToUpper());
            Console.WriteLine("\r\n\tAccount Number: " + savings.accountNumber);
            Console.WriteLine("\r\n\tBalance: " + savings.BalanceFormat(balance));
            Console.WriteLine("\r\n\tMinimum Balance: " + savings.MinimumBalance);
        }



    }
}
