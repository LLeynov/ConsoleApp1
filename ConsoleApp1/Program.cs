using Console_App;
using Console_App.Employees;
using Console_App.Factory;
using System.Reflection.Metadata.Ecma335;
using static Console_App.Employees.FixedEmployee;

namespace TestProj
{
    public class Programm
    {
        static void Main(string[] args)
        {

            FluentHourlyEmployee fluentHourlyEmployee = new FluentHourlyEmployee();
            FluentFixedEmployee fluentFixedEmployee = new FluentFixedEmployee();

            fluentHourlyEmployee.NameOfTheEmployee("Вова").SalaryOfTheEmployee().SurnameOfTheEmployee("Резников");
            fluentFixedEmployee.NameOfTheEmployee("Дима").SalaryOfTheEmployee().SurnameOfTheEmployee("Шиз");

            EmployeeBase[] array = { fluentHourlyEmployee.hourlyEmployee, fluentFixedEmployee.fixedEmployee };

            foreach (EmployeeBase element in array)
            {
                Console.WriteLine(element.Name + " " + element.Surname + " " + element.GetAverageSalary());
            }







        }
    }
}
