﻿using LisMaternityHospital.Ranks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    class ExpertDoctor : SeniorDoctor
    {
        public ExpertDoctor(): base()
        {
            ranks.Add(new Specialist());
        }
    }
}
