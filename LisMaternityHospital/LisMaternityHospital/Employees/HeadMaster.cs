using LisMaternityHospital.Ranks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    class HeadMaster : AdministrativeEmployee
    {
        public HeadMaster(string firstName, string lastName) : base(firstName, lastName)
        {
            ranks.Add(new Manager());
            ranks.Add(new DecisionMaker());
        }
    }
}
