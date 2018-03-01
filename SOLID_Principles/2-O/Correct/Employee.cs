using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._2_O.Correct
{
    public abstract class Employee
    {
        public Employee()
        {

        }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public abstract decimal CalculateBonus(decimal salary);

    }
}
