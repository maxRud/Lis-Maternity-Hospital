using LisMaternityHospital.Employees;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Ranks
{
    class Specialist : IRank
    {
        public double CalculateBonus(IEmployee employee)
        {
            return employee.hourSalary * 0.3 * employee.GetWorkHours();
        }
    }
}
