using LisMaternityHospital.Ranks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    class HeadNurse : Nurse
    {
        public HeadNurse(): base()
        {
            ranks.Add(new SeniorEmployee());
            ranks.Add(new DecisionMaker());
        }
    }
}
