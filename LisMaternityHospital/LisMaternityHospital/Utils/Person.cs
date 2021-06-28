using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital
{
    abstract class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int IdNumber { get; }

        public Person(string firstName, string lastName, int idNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            IdNumber = idNumber;
        }
    }
}
