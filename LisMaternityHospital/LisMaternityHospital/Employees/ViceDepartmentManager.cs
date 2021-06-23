﻿using LisMaternityHospital.Ranks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LisMaternityHospital.Employees
{
    class ViceDepartmentManager : ProfessionalEmployee
    {
        public ViceDepartmentManager()
        {
            ranks.Add(new Manager());
            ranks.Add(new DecisionMaker());
        }
    }
}
