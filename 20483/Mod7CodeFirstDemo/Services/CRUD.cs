using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mod7CodeFirstDemo.Models;
using Mod7CodeFirstDemo.Data;

namespace Mod7CodeFirstDemo.Services
{
    public class CRUD
    {
        public void AddRecord(Employee employee)
        {
            // object getting added in dbset (local copy)
            Data.Records.employeeContext.Employees.Add(employee);
            Records.employeeContext.SaveChanges();
        }
        public void DeleteRecord(int eid)
        {
            var emp = Records.employeeContext.Employees.Find(eid);
            if (emp != null)
            {
                Records.employeeContext.Employees.Remove(emp);
            }
            Records.employeeContext.SaveChanges();

        }
        public void UpdateRecord(int id, Employee emp)
        {
            var emptoupdate = Records.employeeContext.Employees.Find(id);
            if (emptoupdate != null)
            {
                emptoupdate.EmpId = emp.EmpId;
                emptoupdate.Name = emp.Name;
                emptoupdate.Salary = emp.Salary;
                emptoupdate.DepartmentId = emp.DepartmentId;
                Records.employeeContext.SaveChanges();
            }
        }
        public int GetMaxId()
        {
            return Records.employeeContext.Employees.Max(e => e.EmpId);
        }
        public ICollection<Employee> GetEmployees()
        {
            return Records.employeeContext.Employees.ToList();
        }
        public ICollection<Department> GetDepartments()
        {
            return Records.employeeContext.Departments.ToList();
        }
        public Employee FindEmployee(int id)
        {
            return Records.employeeContext.Employees.Find(id);
        }
    }
}
