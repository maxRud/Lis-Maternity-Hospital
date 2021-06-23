using LisMaternityHospital.Ranks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    class SeniorDoctor : Doctor
    {
        public SeniorDoctor(): base()
        {
            ranks.Add(new DecisionMaker());
        }
    }
}
