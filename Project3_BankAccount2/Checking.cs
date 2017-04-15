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
            this.accountNumber = "235234"; //make actual account number, generate randomly?
            this.balance = 3600.35; //random number?
            this.accountType = "Checking";
        }

        public Checking(string accountNumber)
        {
            this.accountNumber = accountNumber;
            this.balance = 3600.35; //random number?
            this.accountType = "Checking";

        }

        //methods
    }
}
