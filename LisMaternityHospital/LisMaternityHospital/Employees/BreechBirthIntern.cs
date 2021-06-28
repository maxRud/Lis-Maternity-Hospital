using LisMaternityHospital.Ranks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    class BreechBirthIntern : Intern
    {
        public BreechBirthIntern(string firstName, string lastName, int idNumber) : base(firstName, lastName, idNumber)
        {
            ranks.Add(new Specialist());
        }
    }
}
