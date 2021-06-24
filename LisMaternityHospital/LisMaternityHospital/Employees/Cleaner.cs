using LisMaternityHospital.Ranks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    class Cleaner : AdministrativeEmployee
    {
        public Cleaner(string firstName, string lastName): base(firstName, lastName)
        {
            ranks.Add(new JuniorEmployee());
        }
    }
}
