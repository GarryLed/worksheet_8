/*
* Name: Garry Ledwith
* Date: 13/04/24
* Description:
* Worksheet 8, Q4
* 
Create a new project for this question.
Write a class to represent objects of type BankAccount.  It should have the following private attributes :
Account Number (integer).  This should be unique for all objects of type BankAccount.
Customer Name (string)
Account Type (string ) (allowed types : Current, Deposit, Savings or invalid). 
BIC (bank identification code) (string)
Balance (decimal)
Account PIN  (string- 4 digits)
Create properties (getter and setter) for these as follows:
Balance – getter only
Account type- use the setter to validate that it is an allowed type or throw a format exception. 
Name – getter, private setter
BIC- getter, private setter
PIN – private setter, private getter
Add the following functionality to the class:
Lodge money
Withdraw money
Check Balance
Change PIN
Modify 2,3,and 4 to include use of PIN

Write a Main() method in the program.cs class to use the BankAccount class Here you will
Create a BankAccount object. Instantiate the BankAccount objects by obtaining the necessary attributes from a user through keyboard input. 

Write a menu that allows the user to 
1. Lodge
2. Withdraw
3. Check Balance
4. Change Pin
5. Exit

*/
namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create a new instantce of the class 
            BankAccount account = new BankAccount("Garry", "Current", "1234");
            

            // declare variables  
           // int userChoice = 0;

            // main menu loop (OPTION 1) 
            /*
            do
            {
                // display initial menu 
                Console.WriteLine("\nMain Menu");
                Console.WriteLine("1. Lodge");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Change Pin");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice : ");
                userChoice = int.Parse(Console.ReadLine()); // use TryParse here for input validation 

                while (userChoice != 5)
                {

                    switch (userChoice)
                    {
                        case 1:
                            Console.WriteLine("1. Lodge");
                            // verify pin 
                            Console.WriteLine("Enter your pin: ");
                            string userPin = Console.ReadLine();

                            bool correctPin = account.VerifyPin(userPin);

                            if ( correctPin )
                            {
                                Console.Write("Enter lodgement amount: ");
                                decimal lodgement = decimal.Parse(Console.ReadLine());
                                Console.WriteLine(account.LodgeMoney(lodgement)); // make a lodgement 
                            }
                            else
                            {
                                Console.WriteLine("That pin is invalid");
                                break;
                            }
                            break;
                        case 2:
                            Console.WriteLine("2. Withdraw");
                            // verify pin 
                            Console.WriteLine("Enter your pin: ");
                            userPin = Console.ReadLine();

                            correctPin = account.VerifyPin(userPin);

                            if (correctPin)
                            {
                                Console.Write("Enter withdraw amount: ");
                                decimal withdrawl = decimal.Parse(Console.ReadLine());
                                Console.WriteLine(account.WithdrawMoney(withdrawl)); // make a withdrawl

                            }
                            else
                            {
                                Console.WriteLine("That pin is invalid");
                                break;
                            }
                            break;
                        case 3:
                            Console.WriteLine("3. Check Balance");
                            // verify pin
                            Console.WriteLine("Enter your pin: ");
                            userPin = Console.ReadLine();

                            correctPin = account.VerifyPin(userPin);

                            if (correctPin)
                            {
                                Console.WriteLine(account.ToString()); // print balance 

                            }
                            else
                            {
                                Console.WriteLine("That pin is invalid");
                                break;
                            }
                            break;
                        case 4:
                            Console.WriteLine("4. Change Pin");
                            break;
                        case 5:
                            Console.WriteLine("5. Exit");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                } // end loop 
            }
            while (userChoice != 5);
            */ // end of option 1 menu loop 

            // OPTOIN 2 LOOP: 

            // declare variables 
            bool exitProgram = false; 

            // MAIN MENU LOOP (OPTION 2: USING METHODS)
            while (!exitProgram)
            {
                DisplayMenu(); // display main menu 

                int userChoice; 
                // input validation for userChoice 
                if (!int.TryParse(Console.ReadLine(), out userChoice)) // checks if input is valid and if not executes this block 
                {
                    Console.WriteLine("Invalid entry; please enter a valid number");
                    continue; 
                }

                // menu options list 
                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("\n1. Lodge");

                        PerformBankingOperation(account, "lodge"); //  pass in account object and the stiring "lodge" to determine its a lodgement 
                        break;
                    case 2:
                        Console.WriteLine("\n2. Withdraw");

                        PerformBankingOperation(account, "withdraw"); //  pass in account object and the stiring "withdraw" to determine its a withdrawl 
                        break;
                    case 3:
                        Console.WriteLine("\n3. Check Balance");

                        CheckBalance(account); 
                        break;
                    case 4:
                        Console.WriteLine("\n4. Change Pin");
                        break;
                    case 5:
                        Console.WriteLine("\n5. Exit");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }


            Console.WriteLine("\nThank you! Goodbye");  
        }
        // Methods 
        // Display main menu 
        private static void DisplayMenu()
        {
            // display initial menu 
            Console.WriteLine("\nMain Menu");
            Console.WriteLine("1. Lodge");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Change Pin");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice : ");
        }


        // Perform a Lodgement  or Withdrawl
        private static void PerformBankingOperation(BankAccount account, string operation) // pass in BankAccount account opject and a string 
        {
            Console.Write("Enter your PIN: "); // ask user for their pin
            string userPin = Console.ReadLine();

            // verify pin 
            if (!account.VerifyPin(userPin)) // if userPin is not equal to existing pin then end the operation  
            {
                Console.WriteLine("Invalid PIN");
                return; 
            }

            // ask user for amount 
            Console.WriteLine($"Enter amount to {operation}");
            // validate input from user
            if (!decimal.TryParse(Console.ReadLine(), out decimal amount))
            {
                Console.WriteLine("Invalid entry ");  // create a loop here 
                return;
            }

            // try, catch 
            try
            {
                if (operation == "lodge")
                {
                    // do something with lodgement
                    account.LodgeMoney(amount); // call the LodgeMoney method on an instance of the BankAccout class 
                    // print success message 
                    Console.WriteLine($"Successfully lodged {amount}");
                }
                else if (operation == "withdraw")
                {
                    // do something with withdrawl 
                    account.WithdrawMoney(amount); // call the WithDrawMoney method on an instance of BankAccount class
                    // print success message 
                    Console.WriteLine($"Successfully withdrew {amount}");
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }
        

        // Check Balance 
        private static void CheckBalance(BankAccount account) 
        {
            // ask user of PIN 
            Console.Write("Enter PIN");
            string userPin = Console.ReadLine();

            // check if pin is correce and return relevant message 
            if (account.VerifyPin(userPin)) 
            {
                // print balance 
                Console.WriteLine($"Your balance is {account.Balance}");
            }
            else 
            {
                Console.WriteLine("Invalid PIN");
            }
        }


        // Change Pin 
    }
}