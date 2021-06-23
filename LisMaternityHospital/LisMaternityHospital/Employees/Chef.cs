using LisMaternityHospital.Ranks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    class Chef : SuChef
    {
        public Chef() : base()
        {
            ranks.Add(new DecisionMaker());
        }
    }
}
