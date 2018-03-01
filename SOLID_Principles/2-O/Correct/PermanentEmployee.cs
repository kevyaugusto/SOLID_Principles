﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._2_O.Correct
{
    public class PermanentEmployee : Employee
    {
        public PermanentEmployee()
        {
        }

        public PermanentEmployee(int id, string name) : base(id,name)
        {
        }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }
    }
}
