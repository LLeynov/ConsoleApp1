using Console_App.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App.Factory
{
    internal class HourlyEmplCreator : Creator
    {
        public override EmployeeBase Create() { return new HourlyEmployee(); }
    }
}
