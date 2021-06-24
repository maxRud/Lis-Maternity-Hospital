﻿using LisMaternityHospital.Ranks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    class SuChef : Cook
    {
        public SuChef(string firstName, string lastName) : base(firstName, lastName)
        {
            ranks.Add(new Specialist());
        }
    }
}
