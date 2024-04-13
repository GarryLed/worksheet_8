/*
* Name: Garry Ledwith
* Date: 13/04/24
* Description:
* Worksheet 8, Q3
* 
Create a new project for this question. Write a class to represent a Car
The class should have four private attributes to represent the cars 
name (string)
 brand (string)( VW, BMW, Audi are only valid brands allowed, otherwise unknown), 
colour (string) 
registration number (int).
Provide a single constructor which should initialise the name, brand and colour attributes to a value which is passed to the constructor and sets a unique value for the reg number.
Provide properties and getter and setter methods for the attributes as appropriate.
Provide a ToString() method to return a string with the values of Car’s attributes.

Write a Main() method in the program.cs class to use the Car class.  Here you will
Declare an array of 5 Car objects. Instantiate each of the Car objects by obtaining the necessary attributes from a user through keyboard input.  
Your solution should make use of a loop.

Assume that an incorrect Brand was entered for the second car in the array. 
Print the brand name of the second car to the screen using the appropriate getter method and ask the user to enter the correct brand name. 
Use the setter method to set the value for the brand of the second car.

Use the ToString() method to print the attributes for each car object.

*/
namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Car[] cars = new Car[3]; // create an array from the Car class 

            for (int i = 0; i < cars.Length; i++) 
            {
                Console.Write("Enter name of car: ");
                string name = Console.ReadLine();
                Console.Write("Enter brand of car: ");
                string brand = Console.ReadLine();
                Console.Write("Enter colour of car: ");
                string colour = Console.ReadLine();

                cars[i] = new Car(name, brand, colour); // instantites a new Car object with 3 attributes at each iteration 
            }

            // for loop to make changes to attributes 
            for (int i = 0;i < cars.Length;i++) 
            {
                if (i == 1) 
                {
                    Console.WriteLine(cars[i].Brand);
                    Console.Write("Enter brand of car: ");
                    string brand = Console.ReadLine();

                    cars[i].Brand = brand; // set brand of car to new value entered by the user
                }
            }
            
            // loop through Cars array to print all attributes of each car 
            for (int i = 0; i < cars.Length;  i++) 
            {
                Console.WriteLine(cars[i].ToString());
            }
        }
    }
}