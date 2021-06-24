using LisMaternityHospital.Ranks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    class ProCleaner : AdministrativeEmployee
    {
        public ProCleaner(string firstName, string lastName) : base(firstName, lastName)
        {
            ranks.Add(new SeniorEmployee());
        }
    }
}
