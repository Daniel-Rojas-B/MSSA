using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7CodeFirstDemo.Models
{
    // child table (1 to many)
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmpId { get; set; } // PK
        public string Name { get; set; }
        public double Salary { get; set; }
        public int DepartmentId { get; set; } // FK
        public virtual Department Department { get; set; } // relationship
    }
}
