using LisMaternityHospital.Employees;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Ranks
{
    class SeniorEmployee : IRank
    {
        public double CalculateBonus(IEmployee employee)
        {
            return employee.hourSalary * 0.05 * employee.GetWorkHours();
        }
    }
}
