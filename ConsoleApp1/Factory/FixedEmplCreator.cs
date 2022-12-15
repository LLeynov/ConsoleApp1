using Console_App.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Console_App.Employees.FixedEmployee;

namespace Console_App.Factory
{
    internal class FixedEmplCreator : Creator
    {
        internal FixedEmployee fixedEmployee = new FixedEmployee();

        public FixedEmplCreator NameOfTheEmployee(string FullName)
        {
            fixedEmployee.Name = FullName;
            return this;
        }

        public FixedEmplCreator SurnameOfTheEmployee(string Surname)
        {
            fixedEmployee.Surname = Surname;
            return this;
        }

        public FixedEmplCreator SalaryOfTheEmployee()
        {
            fixedEmployee.Salary = fixedEmployee.GetAverageSalary();
            return this;
        }
        public override EmployeeBase Create() { return (FixedEmployee)fixedEmployee; }
    }
}
