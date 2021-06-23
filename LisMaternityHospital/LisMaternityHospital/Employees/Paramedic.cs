using LisMaternityHospital.Ranks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    class Paramedic : ProfessionalEmployee
    {
        public Paramedic()
        {
            ranks.Add(new JuniorEmployee());
        }
    }
}
