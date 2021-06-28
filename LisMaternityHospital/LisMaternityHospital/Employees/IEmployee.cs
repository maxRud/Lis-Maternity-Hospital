using LisMaternityHospital.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    interface IEmployee
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int IdNumber { get; }
        public double hourSalary { get; set; }
        public double fixedSalary { get; set; }
        public IList<WorkTracker> shifts { get; set; }
        public void EndShift();
        public void StartShift();
        public void EndShift(DateTime endDate);
        public void StartShift(DateTime startDate);
        public double CalculateSalary();
        public double GetWorkHours();
        public bool CheckIfInShift();

    }
}
