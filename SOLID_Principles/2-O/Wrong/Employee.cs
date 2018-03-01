using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._2_O.Wrong
{
    public class Employee
    {
        public Employee()
        {
        }

        public Employee(int id, string name, string employeeType)
        {
            Id = id;
            Name = name;
            EmployeeType = employeeType;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string EmployeeType { get; set; }

        public decimal CalculateBonus(decimal salary)
        {
            return this.EmployeeType == "Permanent"
                ? salary * .1M
                : salary * 0.05M;
        }
    }
}