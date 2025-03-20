using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Mod7CodeFirstDemo.Models;

namespace Mod7CodeFirstDemo.Models
{
    // master table (1 to many)
    public class Department
    {

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public virtual ObservableCollectionListSource<Employee> Employees { get; set; }
    }
}
