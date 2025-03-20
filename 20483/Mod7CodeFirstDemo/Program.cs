using Microsoft.EntityFrameworkCore;
using Mod7CodeFirstDemo.Data;

namespace Mod7CodeFirstDemo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Records.employeeContext = new EmployeeContext();
            Records.employeeContext.Database.EnsureCreated();
            Records.employeeContext.Departments.Load();
            Records.employeeContext.Employees.Load();
            Application.Run(new Form1());
        }
    }
}