using LisMaternityHospital.Ranks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    class BreechBirthIntern : Intern
    {
        public BreechBirthIntern(): base()
        {
            ranks.Add(new Specialist());
        }
    }
}
