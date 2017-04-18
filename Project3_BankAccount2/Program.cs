using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3_BankAccount2
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate objects
            Client client = new Client();
            Savings savings = new Savings();
            Checking checking = new Checking();

            Console.WriteLine();

            //welcome page and log in / get user information
            string welcome = "Welcome!";
            Console.SetCursorPosition((Console.WindowWidth - welcome.Length) / 2, Console.CursorTop);
            Console.WriteLine(welcome);

            Console.WriteLine("\r\n\r\nTo view your account, please enter your name and username.");
            Console.WriteLine();

            client.GetClientInfo();

            Console.Clear();

            //declare variables (will use them to collect user's response to the menu)
            string userResponse;
            int userOption;

            do
            {
                //display menu
                Console.WriteLine("\r\nPlease select an option: ");
                Console.WriteLine("\r\n\r\n\t1. View Client Information");
                Console.WriteLine("\r\n\t2. View Account Balance");
                Console.WriteLine("\r\n\t3. Deposit Funds");
                Console.WriteLine("\r\n\t4. Withdraw Funds");
                Console.WriteLine("\r\n\t5. Log in as New User");
                Console.WriteLine("\r\n\t6. Exit");

                Console.Write("\r\n\r\n>  ");
                userResponse = Console.ReadLine();

                //check that user input a number and, if so, return it as an int
                userOption = FilterInput(userResponse);

                Console.Clear();

                //send user to correct response based on menu choice
                switch (userOption)
                {
                    //view client info
                    case 1:
                        Console.WriteLine("\r\n\r\nYour Profile:");
                        checking.PrintClientInfo(client, savings, checking); //doesn't matter which object you use to call the method
                        break;

                    //view account balance
                    case 2:

                        //display account choices, test user input a number, and return user input as an int
                        userOption = SelectAccount();

                        Console.Clear();

                        //send user to proper account
                        if (userOption == 1)
                        {
                            checking.DisplayBalance();
                        }
                        else if (userOption == 2)
                        {
                            savings.DisplayBalance();
                        }
                        else
                        {
                            Console.WriteLine("\r\n\r\nI'm sorry. That is not a valid option.");
                        }

                        break;

                    //deposit funds
                    case 3:

                        //display account choices, test user input a number, and return user input as an int
                        userOption = SelectAccount();

                        Console.Clear();

                        //send user to correct account
                        if (userOption == 1)
                        {
                            checking.Deposit(checking);
                        }
                        else if (userOption == 2)
                        {
                            savings.Deposit(savings);
                        }
                        else
                        {
                            Console.WriteLine("\r\n\r\nI'm sorry. That is not a valid option.");
                        }

                        break;

                    //withdraw funds
                    case 4:

                        //display account choices, test user input a number, and return user input as an int
                        userOption = SelectAccount();

                        Console.Clear();

                        //send user to correct account
                        if (userOption == 1)
                        {
                            checking.Withdraw();
                        }
                        else if (userOption == 2)
                        {
                            savings.Withdraw();
                        }
                        else
                        {
                            Console.WriteLine("\r\n\r\nI'm sorry. That is not a valid option.");
                        }

                        break;
                    
                    //log in as new user
                    case 5:

                        Console.WriteLine("\r\n\r\nThank you for visiting.");
                        System.Threading.Thread.Sleep(1500);
                        Console.Clear();

                        Console.WriteLine("\r\n\r\nTo view your account, please enter your name and username.");
                        Console.WriteLine();

                        client.GetClientInfo();

                        break;

                    //exit
                    case 6:

                        Console.WriteLine("\r\n\r\nThank you for your visit.");
                        System.Threading.Thread.Sleep(1500);

                        break;

                    //number outside range
                    default:
                        Console.WriteLine("\r\n\r\nI'm sorry. That is not a valid option.");
                        break;
                }

                Console.WriteLine("\r\n\r\n");
                PressAndClear();

            } while (userOption != 6);


        }


        //METHODS

        //call this method to test that user input is an int and return a valid int
        public static int FilterInput(string userResponse)
        {
            int userOption;

            //make sure user input is a number and cycle through loop until enter a number
            while (!int.TryParse(userResponse, out userOption))
            {
                Console.WriteLine("\r\nI'm sorry. That is not a valid option. Which action would you like to take?");
                Console.Write("\r\n\r\n>  ");
                userResponse = Console.ReadLine();
            }

            //change number from string to int
            int.TryParse(userResponse, out userOption);

            return userOption;
        }

        //call this method to have the user select which account they would like to interact with
        public static int SelectAccount()
        {
            //display menu
            Console.WriteLine("\r\nPlease select which account to view: ");
            Console.WriteLine("\r\n1. Checking");
            Console.WriteLine("\r\n2. Savings");
            Console.Write("\r\n\r\n>  ");
            string userResponse = Console.ReadLine();

            int userOption;

            //make sure user inputs a number
            while (!int.TryParse(userResponse, out userOption))
            {
                Console.WriteLine("\r\nI'm sorry. That is not a valid option. Which account would you like to select?");
                Console.Write("\r\n\r\n>  ");
                userResponse = Console.ReadLine();
            }

            int.TryParse(userResponse, out userOption);

            return userOption;
        }

        //call this method to call up the "press key to continue" and clear screen process
        public static void PressAndClear()
        {
            Console.WriteLine();
            Console.Write("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

        //call this method to exit program without using the loop
        public static void Exit()
        {
            Console.WriteLine("\r\n\r\nThank you for your visit.");
            Console.WriteLine("\r\n\r\n");
            Environment.Exit(0);
        }



    }
}
