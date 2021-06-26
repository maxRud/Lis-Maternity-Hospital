using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital
{
    abstract class Person
    {
        public string firstName { get; }
        public string lastName { get; }
        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
