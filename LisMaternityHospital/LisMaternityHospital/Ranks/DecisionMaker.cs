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
            return (employee.GetWorkHours() > 50) 
                ? (employee.hourSalary * 0.5 * (employee.GetWorkHours() + 200)) 
                : 0;
        }
    }
}
