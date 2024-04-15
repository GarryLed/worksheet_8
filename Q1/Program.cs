/*
 Part 1: Creating and Using Basic Classes

Question 1: Employee (using the example from the lecture/book)
Create a new project called Q1 and add a new class called employee.cs to this project. Copy the code for the employee class to this class. 
You can then do the following in the main method in your program.cs file. Use the debugger to step through the code (note F11 lets you go line by line).
1.	Create a new employee using the default constructor.
2.	Set its attributes using the appropriate Properties.
3.	Print its attributes using the ToString() method
4.	Create a new employee using the parametrised constructor
5.	Print its attributes using the ToString() method.

6.	Edit the employee class. Add a method called CalculateTax to calculate and  return their tax. This is calculated as 40% of their pay. Write code in the main method to check it works.

7.	Edit the employee class. Add a nationality attribute and property, in the setter code if the nationality is “American” set the value to “visa required”. Also edit the ToString method to include the nationality property.


8.	Write code in the main method in the program.cs file to test the nationality properly.



*/
using System.Runtime.InteropServices;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Employee employee = new Employee(); // creates a  new employee objects with default constructor 

            Console.WriteLine(employee.ToString()); // print the employee attributes using the ToString method 

            Console.WriteLine($"Pay = {employee.CalculateTax()}"); // calls the CalculatePay method from the employee class 

            // Setter Method in action 
            employee.Name = "Beata";
            employee.Gender = "Female";
            employee.HourlyRate = 50;

            Console.WriteLine(employee.ToString()); // print the employee attributes using the ToString method 

            Console.WriteLine($"Pay = {employee.CalculateTax()}"); // calls the Calculate tax method from the employee class

            employee = new Employee("Garry","Male", "American", 20); // creating a new employee object using the paramiterised constructor 

            Console.WriteLine(employee.ToString());
            Console.WriteLine($"Pay = {employee.CalculateTax()}"); // calls the Calculate tax method from the employee class

            // create an array of employe objects by creating a new Employee object at each index position 
            Employee[] AllEmployees = new Employee[5];

            // add full time employees to array 
            AllEmployees[0] = new Employee("Mary", "Female", "Irish", 30);
            AllEmployees[1] = new Employee("John", "Male", "Polish", 40);

            // adding part time employees to array 
            AllEmployees[2] = new PartTimeEmployee("Dominik", "Male", "Polish", 45, 15);
            AllEmployees[3] = new PartTimeEmployee("David", "Male", "French", 55, 23);
            AllEmployees[4] = new PartTimeEmployee("Kayla", "Female", "Spanish", 77, 11);


            // print details of all employees objects from an array 
            Console.WriteLine("\nArray of employees\n "); // Heading 
            for (int i = 0; i < AllEmployees.Length; i++) // loop through Empllyees array 
            {
                Console.WriteLine(AllEmployees[i].ToString()); // converts each employee Property into a string 
                Console.WriteLine("Your pay: " + AllEmployees[i].CalculateTax()); // calculate pay per employee 
            }
        }
    }
}