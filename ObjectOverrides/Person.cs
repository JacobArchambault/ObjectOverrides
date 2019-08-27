using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    class Person
    {
        //Properties.
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int Age { get; set; }
        public string SSN { get; set; } = "";

        //Constructors.
        public Person(string fName, string lName, int personAge)
        {
            FirstName = fName;
            LastName = lName;
            Age = personAge;
        }
        public Person() { }

        // Method Overrides.
        public override string ToString() => $"[First Name: {FirstName}; Last Name: {LastName}; Age: {Age}]";
        public override bool Equals(object obj) => obj?.ToString() == ToString();
        public override int GetHashCode() => SSN.GetHashCode();
    }
}
