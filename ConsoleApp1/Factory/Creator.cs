using Console_App.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App.Factory
{
    abstract internal class Creator
    {
        public abstract EmployeeBase Create();
    }
}
