using LisMaternityHospital.Employees;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Ranks
{
    class EmployeeAtRisk : IRank
    {
        private double riskPercentage;
        public EmployeeAtRisk(double riskPercentage)
        {
            this.riskPercentage = riskPercentage;
        }
        public double CalculateBonus(IEmployee employee)
        {
            return employee.hourSalary * (riskPercentage / 100) * employee.GetWorkHours();
        }
    }
}
