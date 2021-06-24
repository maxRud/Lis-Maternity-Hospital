using LisMaternityHospital.Ranks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    class ToxicCleaner: Cleaner
    {
        public ToxicCleaner(string firstName, string lastName) : base(firstName, lastName)
        {
            ranks.Add(new DecisionMaker());
            ranks.Add(new Specialist());
            ranks.Add(new EmployeeAtRisk(20));
        }
    }
}
