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
            BankAccount account = new BankAccount("Garry", "1234");
            Console.WriteLine(account.Name);
            Console.WriteLine(account.AccountNumber);
            Console.WriteLine(account.ToString()); // initial balance is 0 
            Console.WriteLine(account.Bic);

            Console.WriteLine(account.LodgeMoney(5)); // make a lodgement (amount is 5)
                                                      // 
            Console.WriteLine(account.ToString()); // balance is now 5

            Console.WriteLine(account.WithdrawMoney(3)); // withdraw money (amount is  3) 

            Console.WriteLine(account.ToString()); // balance is now 2 

            // create a new instance of the class 
            BankAccount account2 = new BankAccount("Beata", "1234");
            Console.WriteLine(account2.Name);
            Console.WriteLine(account2.AccountNumber);
            Console.WriteLine(account2.Balance);
        }
    }
}