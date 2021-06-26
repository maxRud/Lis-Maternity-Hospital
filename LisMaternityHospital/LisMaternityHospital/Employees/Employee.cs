using LisMaternityHospital.Ranks;
using LisMaternityHospital.Utils;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    class Employee : Person, IEmployee
    {
        protected IList<IRank> ranks;

        public double hourSalary { get; set; } = 100;
        public double fixedSalary { get; set; } = 1000;
        public IList<WorkTracker> shifts { get; set; }

        public Employee(string firstName, string lastName) : base(firstName, lastName)
        {
            ranks = new List<IRank>();
            shifts = new List<WorkTracker>();
        }

        public Employee(string firstName, string lastName, double hourSalary, double fixedSalary) : base(firstName, lastName)
        {
            ranks = new List<IRank>();
            shifts = new List<WorkTracker>();
            this.hourSalary = hourSalary;
            this.fixedSalary = fixedSalary;
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
            LastDayInTheMonthShift(endDate);
            shifts.Last().FinishedWorking(endDate);
        }

        public void EndShift()
        {
            LastDayInTheMonthShift(DateTime.Now);
            shifts.Last().FinishedWorking();
        }
        private void LastDayInTheMonthShift(DateTime finishedWork)
        {
            if (finishedWork.Month != shifts.Last().StartTime.Month)
            {
                var firstDayOfNewMonth = new DateTime(finishedWork.Year, finishedWork.Month, 1);
                var lastMilisecondOfLastMonth = firstDayOfNewMonth.AddMilliseconds(-1);
                shifts.Last().FinishedWorking(lastMilisecondOfLastMonth);
                StartShift(firstDayOfNewMonth);
            }
        }

        public double CalculateSalary()
        {
            return GetSalaryByHour() + GetSalaryBonus();
        }

        public double GetSalaryBonus()
        {
            return ranks.ToList().Sum(rank => rank.CalculateBonus(this));
        }

        public double GetSalaryByHour()
        {
            return ranks.FirstOrDefault(rank => rank is Manager) != null ? fixedSalary : hourSalary * this.GetWorkHours();
        }

        public double GetWorkHours()
        {
            return shifts.ToList()
                .Where(shift => shift.EndTime.Month == DateTime.Now.Month)
                .Sum(shift => ((shift.EndTime - shift.StartTime).TotalHours));
        }


    }
}
