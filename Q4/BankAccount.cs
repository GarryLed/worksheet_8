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
        // attributes 
        private string _name;
        private string _accountType; // only allows 3 types of bank account; Current, Deposit, Savings (all else is invalid) 
        private string _bic; // how do I create a BIC?
        private decimal _balance;
        private string _accountPin; // 4 digit 

        // static variable available to the entire class 
        private static int _accountNumberSeed = 1234567890; // number will be incremented for each new object 
        public static string bic = "BOFIIE2D"; // set the BIC code 
       

        // properties 
        // Account number property 
        public int AccountNumber
        {
            get
            {
                return _accountNumberSeed;
            }
        }

        // Balance property 

        public decimal Balance { get { return _balance; } } // get only  

        // Account type property 
        public string AccountType
        {
            get { return _accountType; }
            set 
            {
                if (value == "Current" || value == "Deposit" || value == "Savings")
                {
                    _accountType = value; // how to I use this to create a valid account type? 
                }
                else
                {
                    // prompt user to enter a valid option 
                }
            }
        }
        // name property 
        public string Name 
        { 
            get 
            { return _name; 
            }
            set // how do I make thi setter private? 
            {
                _name = value;
            }
        }
        // BIC property 
        public string Bic
        {
            get
            {
                return _bic;
            }
            set // how do i make this private? 
            {
                _bic = value; 
            }
        }

        // PIN property 
        private string AccountPin
        {
            get
            {
                return _accountPin;
            }
            set
            {
                _accountPin = value;
            }
        }

        // parameterised constructor 
        public BankAccount(string name, string pin )
        {
            _balance = 0; // initial balance is set to 0 
            Name = name;
            AccountPin = pin;
            Bic = bic; // set bic to public static variable 
            _accountNumberSeed++; // increment this number by one for each new objcet 
        }

        // instance methods 
        // Lodge money method 
        public decimal LodgeMoney(decimal amount)
        {
            // write validation logic here for 0 and negative numbers 
            _balance += amount;
            return amount;
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

        }


        // method to print attributes of an object 
        public override string ToString()
        {
            return "Balance: " + Balance; // prints the balance 
        }
    }
}
