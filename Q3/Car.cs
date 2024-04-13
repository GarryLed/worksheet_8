using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Car
    {
        // attributes 
        /*
         name (string)
         brand (string)( VW, BMW, Audi are only valid brands allowed, otherwise unknown), 
         colour (string) 
         registration number (int).
         */
        private string _name;
        private string _brand;
        private string _colour;

        // static variable 
        public static int registrationNumber;

        /*
         *   Provide a single constructor which should initialise the name,
         *   brand and colour attributes to a value which is passed to the constructor and sets a unique value for the reg number.
             Provide properties and getter and setter methods for the attributes as appropriate.
             Provide a ToString() method to return a string with the values of Car’s attributes.
         */
        // properties 
        public string Name
        {
            get { return _name; } // get method 
            set { _name = value; } // set method 
        }
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }
        public string Colour
        {
            get { return _colour; }
            set { _colour = value; }
        }
      
        // parameterised constructor 
        public Car(string name, string brand, string colour) 
        {
            Name = name;
            Brand = brand;
            Colour = colour;
            registrationNumber ++; // increments regNum each time a new object is created 
        }
        // method to print attributes of an object 
        public override string ToString()  
        {
            return "Car's attributes: " + Name + " " + Brand + " " + Colour + " " + registrationNumber;
        }
    }
}
