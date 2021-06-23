using LisMaternityHospital.Ranks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    class Midwife : Nurse
    {
        public Midwife(): base()
        {
            ranks.Add(new SeniorEmployee());
        }
    }
}
