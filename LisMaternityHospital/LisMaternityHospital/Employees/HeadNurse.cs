using LisMaternityHospital.Ranks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    class HeadNurse : Nurse
    {
        public HeadNurse(string firstName, string lastName, int idNumber) : base(firstName, lastName, idNumber)
        {
            ranks.Add(new SeniorEmployee());
            ranks.Add(new DecisionMaker());
        }
    }
}
