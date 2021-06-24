using LisMaternityHospital.Ranks;
using LisMaternityHospital.Utils;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    class Employee : IEmployee
    {
        protected IList<IRank> ranks;
        public string firstName { get; }
        public string lastName { get; }
        public double hourSalary { get; set; } = 100;
        public double fixedSalary { get; set; } = 0;
        public IList<WorkTracker> shifts { get; set; }

        public Employee(string firstName, string lastName)
        {
            ranks = new List<IRank>();
            shifts = new List<WorkTracker>();
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void StartShift()
        {
            shifts.Add(new WorkTracker());
        }

        public void StartShift(DateTime startDate)
        {
            shifts.Add(new WorkTracker(startDate));
        }

        public void EndShift(DateTime endDate)
        {
            //if there is a shift that ends one month later so...
            shifts.Last().FinishedWorking(endDate);
        }

        public void EndShift()
        {
            //if there is a shift that ends one month later so...
            shifts.Last().FinishedWorking();
        }
        public double CalculateSalary()
        {
            return fixedSalary + hourSalary * this.GetWorkHours() + ranks.ToList().Sum(rank => rank.CalculateBonus(this));
        }

        public double GetWorkHours()
        {
            return shifts.ToList()
                .Where(shift => shift.EndTime.Month == DateTime.Now.Month)
                .Sum(shift => ((shift.EndTime - shift.StartTime).TotalHours));
        }


    }
}
