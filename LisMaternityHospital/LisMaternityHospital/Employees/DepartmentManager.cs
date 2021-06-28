using LisMaternityHospital.Ranks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    class DepartmentManager : ProfessionalEmployee
    {
        public DepartmentManager(string firstName, string lastName, int idNumber) : base(firstName, lastName, idNumber)
        {
            ranks.Add(new Manager());
            ranks.Add(new DecisionMaker());
            ranks.Add(new EmployeeAtRisk(100));
        }
    }
}
