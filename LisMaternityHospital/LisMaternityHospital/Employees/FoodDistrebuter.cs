using LisMaternityHospital.Ranks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    class FoodDistrebuter : AdministrativeEmployee
    {
        public FoodDistrebuter()
        {
            ranks.Add(new JuniorEmployee());
        }
    }
}
