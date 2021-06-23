using LisMaternityHospital.Ranks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    class Intern : ProfessionalEmployee
    {
        public Intern()
        {
            ranks.Add(new JuniorEmployee());
        }
    }
}
