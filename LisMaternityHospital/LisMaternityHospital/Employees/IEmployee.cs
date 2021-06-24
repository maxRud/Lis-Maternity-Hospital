using LisMaternityHospital.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    interface IEmployee
    {
        public double CalculateSalary();
        public double hourSalary { get; set; }
        public double fixedSalary { get; set; }
        public IList<WorkTracker> shifts { get; set; }
        public double GetWorkHours();
    }
}
