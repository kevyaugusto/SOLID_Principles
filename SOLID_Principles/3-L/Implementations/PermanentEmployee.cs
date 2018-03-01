using SOLID_Principles._3_L.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._3_L.Implementations
{
    public class PermanentEmployee : Employee
    {
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * 0.1M;
        }

        public override decimal GetMinimumSalary()
        {
            return 120000;
        }
    }
}