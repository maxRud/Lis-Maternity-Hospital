using LisMaternityHospital.Ranks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    class Chef : SuChef
    {
        public Chef(string firstName, string lastName, int idNumber) : base(firstName, lastName, idNumber)
        {
            ranks.Add(new DecisionMaker());
        }
    }
}
