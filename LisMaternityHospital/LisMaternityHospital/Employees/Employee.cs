using LisMaternityHospital.Ranks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    abstract class Employee : IEmployee
    {
        protected IList<IRank> ranks = new List<IRank>();
        public double CalculateSalary()
        {
            return 0;
        }
    }
}
