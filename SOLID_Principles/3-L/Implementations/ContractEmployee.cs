using SOLID_Principles._3_L.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._3_L.Implementations
{
    public class ContractEmployee : IEmployee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal GetMinimumSalary()
        {
            return 10000;
        }
    }
}