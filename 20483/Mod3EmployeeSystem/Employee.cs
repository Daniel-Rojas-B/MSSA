using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3EmployeeSystem
{
    enum Department
    {
        IT=1,
        Finance=2,
        HR,
        Marketing
    }
    internal class Employee: Person
    {
        public int EmployeeId { get; set; }
        public double Salary { get; set; }

        public Department Dept { get; set; }
    }
}
