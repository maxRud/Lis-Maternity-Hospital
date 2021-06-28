using LisMaternityHospital.Ranks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    class Nurse : ProfessionalEmployee
    {
        public Nurse(string firstName, string lastName, int idNumber) : base(firstName, lastName, idNumber)
        {
            ranks.Add(new JuniorEmployee());
        }
    }
}
