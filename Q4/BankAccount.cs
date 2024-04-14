using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a class to represent objects of type BankAccount.  It should have the following private attributes :
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
 */

namespace Q4
{
    internal class BankAccount
    {
        // static variable available to the entire class 
        private static int _accountNumberSeed = 1234567890; // number will be incremented for each new object 
        public static string bic = "BOFIIE2D"; // set the BIC code 
        
        // attributes 
        private string _name;
        private string _accountType; // only allows 3 types of bank account; Current, Deposit, Savings (all else is invalid) 
        private int _accountNumber;
        private string _bic; // how do I create a BIC?
        private decimal _balance;
        private string _accountPin; // 4 digit 

        // properties 
     
        // expression-bodied member syntax 
        public string Name { get; private set; }
        public int AccountNumber => _accountNumberSeed;

        public decimal Balance { get { return _balance; } } // get only  

        public string AccountType
        {
            get { return _accountType; }
            set 
            {
                if (value == "Current" || value == "Deposit" || value == "Savings")
                {
                    _accountType = value; 
                }
                else
                {
                    throw new FormatException("Invalid account type"); // I need to handle this error 
                }
            }
        }
        public string Bic { get; private set; } // private setter 

        private string AccountPin { get; set; } // private 
       

        // parameterised constructor 
        public BankAccount(string name, string accountType, string pin )
        {
            _accountNumber =_accountNumberSeed++; // increment this number by one for each new objcet 
            Name = name;
            AccountType = accountType;
            AccountPin = pin;
            Bic = bic; // set bic to public static variable 
            _balance = 0; // initial balance is set to 0 
        }

        // Methods
        public decimal LodgeMoney(decimal amount) // is decimal the corrent return type for this method? 
        { 
            if (amount <= 0)
            {
                throw new ArgumentException("Amount must be greater than 0"); // I need to handle these exceptinos 
            }
             return _balance += amount;
            
        }
        // withdraw money method 
        public decimal WithdrawMoney(decimal amount) // method needs input validaation 
        {
            if (amount < _balance)
            {
               _balance -= amount;
            }
            return amount;
        }
        // chagne pin method 
        public string ChangePin()
        {
            Console.WriteLine("Enter new pin: ");
            string newPin = Console.ReadLine();

            return AccountPin = newPin; // not sure if this is corrent return value of this method 
        }
        // Validate current pin method 
        public bool VerifyPin(string pin)
        {
            return (AccountPin == pin); // returns true if AccountPin and pin match 
        }


        // method to print attributes of an object 
        public override string ToString()
        {
            return $"Account Number: {_accountNumber}, Name: {Name}, Balance: {Balance}";
        }
    }
}
