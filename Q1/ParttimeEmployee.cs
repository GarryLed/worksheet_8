using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 INHERITANCE 
 */
namespace Q1
{
    class PartTimeEmployee : Employee // inherits from the Employee class (PartTimeemployee derives from the Employee Base class) 
    {
        private int _hoursWorked; // new attribute for part time employees 

        // Property for _hoursWorked variable 
        public int HoursWorked
        {
            get
            {
                return _hoursWorked;
            }
            set 
            {
                _hoursWorked = value;
            }
        }

        // default constructor that inherits from employee class constructor 
        public PartTimeEmployee() : base()
        {

        }

        // Paramertised constructor that inherits name, genger, and hourlyRate from the employee class 
        public PartTimeEmployee(string name, string gender, double hourlyRate, int hrs) : base (name, gender, hourlyRate) // (: base (name, gender, hourlyRate) all inherite for Employee class) 
        {
            _hoursWorked = hrs;
        }
        // overrides the Base class level ToString method 
        public override string ToString()
        {
            return base.ToString() + ", Hours Worked: " + HoursWorked;
        }
    }
}
