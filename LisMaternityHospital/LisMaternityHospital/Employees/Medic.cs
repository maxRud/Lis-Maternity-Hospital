using LisMaternityHospital.Ranks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    class Medic : ProfessionalEmployee
    {
        public Medic()
        {
            ranks.Add(new JuniorEmployee());
        }
    }
}
