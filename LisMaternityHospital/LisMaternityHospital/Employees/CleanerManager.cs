using LisMaternityHospital.Ranks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    class CleanerManager : AdministrativeEmployee
    {
        public CleanerManager(string firstName, string lastName) : base(firstName, lastName)
        {
            ranks.Add(new DecisionMaker());
        }
    }
}
