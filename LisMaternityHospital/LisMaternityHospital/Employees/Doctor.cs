using LisMaternityHospital.Ranks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    class Doctor : ProfessionalEmployee
    {
        public Doctor()
        {
            ranks.Add(new SeniorEmployee());
        }
    }
}
