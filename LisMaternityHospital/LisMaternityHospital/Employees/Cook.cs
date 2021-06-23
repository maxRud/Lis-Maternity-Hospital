using LisMaternityHospital.Ranks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    class Cook : AdministrativeEmployee
    {
        public Cook()
        {
            ranks.Add(new SeniorEmployee());
        }
    }
}
