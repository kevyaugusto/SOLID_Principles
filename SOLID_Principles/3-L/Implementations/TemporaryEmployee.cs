using SOLID_Principles._3_L.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._3_L.Implementations
{
    public class TemporaryEmployee : Employee
    {
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * 0.05M;
        }

        public override decimal GetMinimumSalary()
        {
            return 80000;
        }
    }
}
