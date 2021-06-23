using LisMaternityHospital.Ranks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    class SuChef : Cook
    {
        public SuChef() : base()
        {
            ranks.Add(new Specialist());
        }
    }
}
