using LisMaternityHospital.Ranks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    class Doctor : ProfessionalEmployee
    {
        public Doctor(string firstName, string lastName) : base(firstName, lastName)
        {
            ranks.Add(new SeniorEmployee());
        }
    }
}
