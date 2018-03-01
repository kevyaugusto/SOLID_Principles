using SOLID_Principles._3_L.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._3_L.Abstracts
{
    public abstract class Employee : IEmployee, IEmployeeBonus
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public abstract decimal CalculateBonus(decimal salary);

        public abstract decimal GetMinimumSalary();
    }
}
