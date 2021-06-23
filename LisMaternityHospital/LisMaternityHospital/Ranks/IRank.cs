using LisMaternityHospital.Employees;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Ranks
{
    interface IRank
    {
        public double CalculateBonus(IEmployee employee);
    }
}
