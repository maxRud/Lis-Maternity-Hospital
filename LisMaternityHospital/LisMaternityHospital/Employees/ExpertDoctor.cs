using LisMaternityHospital.Ranks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    class ExpertDoctor : SeniorDoctor
    {
        public ExpertDoctor(string firstName, string lastName) : base(firstName, lastName)
        {
            ranks.Add(new Specialist());
        }
    }
}
