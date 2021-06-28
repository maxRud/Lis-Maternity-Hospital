using LisMaternityHospital.Ranks;
using LisMaternityHospital.Utils;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    class Employee : Person, IEmployee //Uses the Interface of IEmployee and son of Person class
    {
        protected IList<IRank> ranks; //Payment ranks
        public double hourSalary { get; set; } = 100;
        public double fixedSalary { get; set; } = 1000;
        public IList<WorkTracker> shifts { get; set; } //Shifts tracker


        public Employee(string firstName, string lastName, int idNumber) : base(firstName, lastName, idNumber)
        {
            ranks = new List<IRank>();
            shifts = new List<WorkTracker>();
        }

        /* Input: string firstName, string lastName, int idNumber, double hourSalary, double fixedSalary
         * Output: Employee
         * Explain: constractor of Employee class, based on Person Class.
         * Can set the hour and fixed salary.
         */
        public Employee(string firstName, string lastName, int idNumber, double hourSalary, double fixedSalary) : base(firstName, lastName, idNumber)
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
            if (CheckIfInShift()) //Check if there is an open shift. If yes --> close and open new one.
            { 
                EndShift();
            }
            shifts.Add(new WorkTracker(startDate));
        }

        public bool CheckIfInShift()
        {
            return shifts.Count > 0 && shifts.Last().EndTime == DateTime.MinValue;
        }

        public void EndShift(DateTime endDate)
        {
            ChuckShiftsByMonth(endDate);
            shifts.Last().FinishedWorking(endDate);
        }

        public void EndShift()
        {
            EndShift(DateTime.Now);
        }

        /* Input: DateTime finishedWork
         * Output: None
         * Explain: Chunk all the shifts by month - if the start date and the end date are in different months (or years).
         */
        private void ChuckShiftsByMonth(DateTime finishedWork)
        {
            DateTime startTime = shifts.Last().StartTime;

            if (finishedWork.Month != startTime.Month)
            {
                for (DateTime date = startTime.AddMonths(1); date <= finishedWork.AddMonths(1); date = date.AddMonths(1))
                {
                    var firstDayOfNewMonth = new DateTime(date.Year, date.Month, 1);
                    var lastMilisecondOfLastMonth = firstDayOfNewMonth.AddMilliseconds(-1);
                    shifts.Last().FinishedWorking(lastMilisecondOfLastMonth);
                    StartShift(firstDayOfNewMonth);
                }
            }
        }

        public double CalculateSalary()
        {
            if (CheckIfInShift())
            {
                EndShift();
            }
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
                .Where(shift => shift.EndTime.Year == DateTime.Now.Year && shift.EndTime.Month == DateTime.Now.Month)
                .Sum(shift => ((shift.EndTime - shift.StartTime).TotalHours));
        }

        public override string ToString()
        {
            return $"My name is {this.FirstName + this.LastName}. My id number is {this.IdNumber}.";
        }
    }
}
