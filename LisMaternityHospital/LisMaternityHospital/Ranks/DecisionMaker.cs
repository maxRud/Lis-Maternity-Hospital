using LisMaternityHospital.Employees;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Ranks
{
    class DecisionMaker : IRank
    {
        public double CalculateBonus(IEmployee employee)
        {
            return 0;
        }
    }
}
