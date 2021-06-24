using LisMaternityHospital.Ranks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    class BreechBirthMidwife : Nurse
    {
        public BreechBirthMidwife(string firstName, string lastName) : base(firstName, lastName)
        {
            ranks.Add(new Specialist());
        }
    }
}
