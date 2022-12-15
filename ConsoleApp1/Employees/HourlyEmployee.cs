using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console_App.Employees;

namespace Console_App
{
    internal class HourlyEmployee : EmployeeBase
    {
        public double Salary { get;set; }
        public salaryType SalaryType = salaryType.Hourly;
        public override double GetAverageSalary()
        {
            if (this.SalaryType == salaryType.Hourly)
            {
                Salary = (double)20.8 * 8 * 545;
                return Salary;
            }
            Exception ex = new Exception("У этого сотрудника фиксированнный тип оплаты, исправьте ошибку.");
            Console.WriteLine(ex.Message);
            return -1;
        }

    }
    
    internal class FluentHourlyEmployee
    {
        internal HourlyEmployee hourlyEmployee = new HourlyEmployee();

        public FluentHourlyEmployee NameOfTheEmployee(string FullName)
        {
            hourlyEmployee.Name = FullName;
            return this;
        }

        public FluentHourlyEmployee SurnameOfTheEmployee(string Surname)
        {
            hourlyEmployee.Surname = Surname;
            return this;
        }

        public FluentHourlyEmployee SalaryOfTheEmployee()
        {
            hourlyEmployee.Salary = hourlyEmployee.GetAverageSalary();
            return this;
        }
    }
}
