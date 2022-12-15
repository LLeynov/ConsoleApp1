using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App.Employees
{
    public enum salaryType
    {
        Undefined,
        Fixed,
        Hourly
    }

    internal abstract class EmployeeBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Salary { get; private set; }
        public salaryType SalaryType { get; set; }
        public abstract double GetAverageSalary();

    }
}
