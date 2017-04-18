using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3_BankAccount2
{
    class Client
    {
        //fields
        private string firstName;
        private string lastName;
        private string userName;
        //FILL IN OTHER FIELDS?????

        //properties
        public string FirstName
        {
            get { return this.firstName; }
        }
        
        public string LastName
        {
            get { return this.lastName; }
        }

        public string FullName
        {
            get { return this.firstName + " " + this.lastName; }
        }

        public string UserName
        {
            get { return this.userName; }
        }


        //constructors
        public Client()
        {

        }

        public Client(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        //methods
        public void GetClientInfo()
        {
            Console.Write("Last name: \t");
            this.lastName = Console.ReadLine();

            Console.Write("\r\nFirst name: \t");
            this.firstName = Console.ReadLine();

            Console.Write("\r\nUsername: \t");
            this.userName = Console.ReadLine();

        }

        public void PrintClientInfo()
        {
            Console.WriteLine("\tLast name: " + lastName);
            Console.WriteLine("\r\n\tFirst name: " + firstName);
        }
        
        

    }
}
