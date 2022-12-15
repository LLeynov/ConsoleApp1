using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Console_App.Employees
{
    internal class FixedEmployee : EmployeeBase
    {
        public double Salary { get; set; }
        public salaryType SalaryType = salaryType.Fixed;

        
        public override double GetAverageSalary()
        {
            if (this.SalaryType == salaryType.Fixed)
            {
                Salary = 90000;
                return Salary;
            }
            Exception ex = new Exception("У этого сотрудника фиксированнный тип оплаты, исправьте ошибку.");
            Console.WriteLine(ex.Message);
            return -1;
        }

        internal class FluentFixedEmployee
        {
            internal FixedEmployee fixedEmployee = new FixedEmployee();

            public FluentFixedEmployee NameOfTheEmployee(string FullName)
            {
                fixedEmployee.Name = FullName;
                return this;
            }

            public FluentFixedEmployee SurnameOfTheEmployee(string Surname)
            {
                fixedEmployee.Surname = Surname;
                return this;
            }

            public FluentFixedEmployee SalaryOfTheEmployee()
            {
                fixedEmployee.Salary = fixedEmployee.GetAverageSalary();
                return this;
            }
        }
    }
}
