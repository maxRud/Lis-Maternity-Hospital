using LisMaternityHospital.Ranks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    class Nurse : ProfessionalEmployee
    {
        public Nurse(string firstName, string lastName) : base(firstName, lastName)
        {
            ranks.Add(new JuniorEmployee());
        }
    }
}
