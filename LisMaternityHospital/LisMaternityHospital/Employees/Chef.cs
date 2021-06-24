using LisMaternityHospital.Ranks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    class Chef : SuChef
    {
        public Chef(string firstName, string lastName) : base(firstName, lastName)
        {
            ranks.Add(new DecisionMaker());
        }
    }
}
