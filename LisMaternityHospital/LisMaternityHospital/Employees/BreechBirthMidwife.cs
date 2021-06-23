using LisMaternityHospital.Ranks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    class BreechBirthMidwife : Nurse
    {
        public BreechBirthMidwife(): base()
        {
            ranks.Add(new Specialist());
        }
    }
}
