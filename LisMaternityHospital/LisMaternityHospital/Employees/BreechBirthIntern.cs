﻿using LisMaternityHospital.Ranks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    class BreechBirthIntern : Intern
    {
        public BreechBirthIntern(string firstName, string lastName) : base(firstName, lastName)
        {
            ranks.Add(new Specialist());
        }
    }
}