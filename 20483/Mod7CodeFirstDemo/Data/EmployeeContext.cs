using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mod7CodeFirstDemo.Models;

namespace Mod7CodeFirstDemo.Data
{
    public class EmployeeContext:DbContext // represent the database base in my server
    {
        public DbSet<Department> Departments { get; set; } // table 
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=DR;initial catalog=PCAD16Employees;integrated security=True;encrypt=False;trustservercertificate=True;MultipleActiveResultSets=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, DepartmentName = "HR" },
                new Department { DepartmentId = 2, DepartmentName = "Marketing" },
                new Department { DepartmentId = 3, DepartmentName = "Finance" }
                );
            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmpId = 101, Name = "Daniel", Salary = 60000, DepartmentId = 1 },
                new Employee { EmpId = 102, Name = "Bob", Salary = 70000, DepartmentId = 2 },
                new Employee { EmpId = 103, Name = "Jackson", Salary = 80000, DepartmentId = 3 }
                );
        }
    }
}
