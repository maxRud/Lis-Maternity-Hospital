using LisMaternityHospital.Ranks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    class Intern : ProfessionalEmployee
    {
        public Intern(string firstName, string lastName) : base(firstName, lastName)
        {
            ranks.Add(new JuniorEmployee());
        }
    }
}
