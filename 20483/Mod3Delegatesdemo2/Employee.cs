using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Delegatesdemo2
{
    internal class Employee
    {
        delegate bool IsPromotable(Employee employee);
        public int Eid { get; set; }
        public string? Name { get; set; }
        public int YearsOfExp {get; set;}
        public char Grade { get; set; }

    }
}
