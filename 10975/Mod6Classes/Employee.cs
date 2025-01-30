using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod6Classes
{
    internal class Employee
    {
        static int count = 0;
        public Employee() 
        {
            count++;
            this.id = count;
        }
        private int id;
        public int Id
        {
            get
            {
                return this.id;
            }
        }
        public string Name { get; set; }
        public float HourlyRate { get; set; }
        public float WeeklyHours { get; set; }
        private decimal salary;
        public decimal Salary
        {
            get { return this.salary; }
        }
        private void Deductions()
        {
            this.HourlyRate = this.HourlyRate - (this.HourlyRate * 5) / 100;
        }
        public decimal CalculateSalary()
        {
            Deductions();
            this.salary = Convert.ToDecimal(this.HourlyRate * this.WeeklyHours);
            return salary;
        }
    }
}
