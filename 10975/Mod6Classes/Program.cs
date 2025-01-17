using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod6Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Console.WriteLine("Enter the name of the employee:");
            employee1.Name = Console.ReadLine();
            Console.WriteLine("Please enter the hourly rate:");
            employee1.HourlyRate = float.Parse(Console.ReadLine());
            Console.WriteLine("How many hours worked?");
            employee1.WeeklyHours = float.Parse(Console.ReadLine());
            employee1.CalculateSalary();



            Console.WriteLine($"Employee with {employee1.Id} and name {employee1.Name} earned {employee1.Salary}");

            Employee employee2 = new Employee();
            Console.WriteLine("Enter the name of the employee:");
            employee2.Name = Console.ReadLine();
            Console.WriteLine("Please enter the hourly rate:");
            employee2.HourlyRate = float.Parse(Console.ReadLine());
            Console.WriteLine("How many hours worked?");
            employee2.WeeklyHours = float.Parse(Console.ReadLine());
            employee2.CalculateSalary();

            Console.WriteLine($"Employee with {employee2.Id} and name {employee2.Name} earned {employee2.Salary}");


            Console.ReadKey();

        }
    }
}
