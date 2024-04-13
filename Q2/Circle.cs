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
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Circle
    {

        // attributes 
        private double _radius;

        // Properties
        public double Radius { get { return _radius; } set { _radius = value; } }

        // Default Constructor 
        public Circle() 
        {
            _radius = 1; // shoould I use this private variable here? 
        }

        // Parameterised constructor 
        public Circle(double radius)
        {
            Radius = radius;
        }
        // Metod to get area of a circle 
        public double GetArea()
        {
            double pi = Math.PI; // returns Pi 
            double  area = (pi * (Radius * Radius)); // calculate area of a circle 
            return area; 
        }

        // Method to print attributes of an object 
        public override string ToString() 
        {
            return "The radius of this circle is " + Radius;
        }
    }


}
