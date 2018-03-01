using SOLID_Principles._3_L.Abstracts;
using SOLID_Principles._3_L.Implementations;
using SOLID_Principles._3_L.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._3_L
{
    class Program
    {
        public void Main()
        {
            // Wrong
            List<Employee> employees = new List<Employee>();
            employees.Add(new PermanentEmployee());
            employees.Add(new TemporaryEmployee());

            // this line below does not compile if uncommented because ContractEmployee does not inherit from Employee class
            //employees.Add(new ContractEmployee());

            foreach (var employee in employees)
            {
                employee.CalculateBonus(120000);
                employee.GetMinimumSalary();
            }
            // End Wrong

            // Correct
            List<IEmployee> employeesCorrect = new List<IEmployee>();
            employeesCorrect.Add(new PermanentEmployee());
            employeesCorrect.Add(new TemporaryEmployee());
            employeesCorrect.Add(new ContractEmployee());

            foreach (var employee in employeesCorrect)
            {
                if (employee is PermanentEmployee)
                    (employee as PermanentEmployee).CalculateBonus(120000);

                employee.GetMinimumSalary();
            }

            // End Correct

        }
    }
}
