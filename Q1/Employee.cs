using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
   class Employee
    {
        // attributes 
        private string _name; // the name field 
        private string _gender;
        private int _employeeNumber;

        // static variable 
        public static int lastEmployeeNumber; 

        // properties with getters and setters 
        // Name property 
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value; 
             }
        }

        // Gender property used to get and set the gender attributes of an object 
        public string Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value; 
            }
        }
        // HourlyRate property 
        public double HourlyRate { get; set; } 

        // Employee number property 
        public int EmployeeNumber
        {
            get
            {
                return _employeeNumber;
            }
            set
            {
                _employeeNumber = value;
            }
        }

        // default constructor 
        public Employee() 
        {
            lastEmployeeNumber++; // increments the (static variable) last employee number by 1 when a new object is instantitated 
            EmployeeNumber = lastEmployeeNumber; 
        }

        // parameteriesd constructor  that takes three parameters: name, gender and hourly pay 
        public Employee(string name, string gender, double pay)
        {
            Name = name;
            Gender = gender;
            HourlyRate = pay;
            lastEmployeeNumber++; 
            EmployeeNumber = lastEmployeeNumber;
        }

        // Method to print name of employee 
        public void PrintName()
        {
            Console.WriteLine($"Name is {Name}"); // call the Name property 
        }
        // Method to print the attributes of an object 
        public override string ToString() // to a string method (like the one used in Ruby) 
        {
            return "Name: " + Name + ", Gender: " + Gender + ", Hourly Rate: " + HourlyRate + ", Employee #: " + EmployeeNumber;

        }
        // Method to calculate an employee pay for a 40 hour work week
        public virtual double CalculatePay()
        {
            return 40 * HourlyRate; // call HourlyRate Property and multiply the result by 40  
        }
    }
    
}
