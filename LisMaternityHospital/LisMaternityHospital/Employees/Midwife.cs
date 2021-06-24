using LisMaternityHospital.Ranks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    class Midwife : Nurse
    {
        public Midwife(string firstName, string lastName) : base(firstName, lastName)
        {
            ranks.Add(new SeniorEmployee());
        }
    }
}
