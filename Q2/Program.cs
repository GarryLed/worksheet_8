/*
* Name: Garry Ledwith
* Date: 05/10/23
* Description:
* Worksheet 8, Q2
* 
* Create a new project of this question.
Write a class to represent a Circle.  This should include the following:
A single private attribute named _radius
A default constructor which should set the radius attribute to a default value of 1.
A second parameterised constructor which should set the radius attribute to a value which is passed to the constructor.
A public property Radius with Getter and setter methods to get and set the value of _radius
A method called GetArea(), to calculate and return the area of the Circle.
A method called ToString() that returns a string with the value of the attribute radius in the format:
The radius of this circle is xx
Write a Main() method in the program.cs class to use the Circle class. Here you will
Create an array containing 4 circle objects
Use a for loop to set each object to default values when created.
Use the setter method on the 1st and 3rd objects in the array of circle objects to set the radius to 10.
Print the radius of each circle object in the array
Print out the area of the 1st and 4th objects in the array
Call the ToString() method on the 3rd Square object in the array.
*/namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(); // instantiate a new Circle object 
            Console.WriteLine(circle.Radius); // print radius 

            Circle[] circles = new Circle[4]; // create a new array in the Circle calss and set the size to 4 

            for (int i = 0; i < circles.Length; i++) // loop through array 
            {
                circles[i] = new Circle(); // instantiate a new circle object at each iteration  
               if (i % 2 == 0) // checks if index is even 
                {
                    circles[i].Radius = 10; // sets objets ate even index positions to 10 
                    Console.WriteLine(circles[i].GetArea()); // gets and prints the area of these objects 
                }

                Console.WriteLine(circles[i].ToString()); // prints all object radius 

            }
        }
    }
}