using LisMaternityHospital.Ranks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    class ProCleaner : AdministrativeEmployee
    {
        public ProCleaner()
        {
            ranks.Add(new SeniorEmployee());
        }
    }
}
