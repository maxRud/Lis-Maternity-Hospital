using LisMaternityHospital.Ranks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    class Nurse : ProfessionalEmployee
    {
        public Nurse()
        {
            ranks.Add(new JuniorEmployee());
        }
    }
}
