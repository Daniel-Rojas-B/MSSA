namespace Mod3EmployeeSystem
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

            Data.Employees.Add(new Employee() { EmployeeId = 101, FullName = "Daniel Rojas", Salary = 100000, Address = "NY", Dept = Department.Marketing });
            Data.Employees.Add(new Employee() { EmployeeId = 102, FullName = "Danny Rojas", Salary = 200000, Address = "CA", Dept = Department.IT });

            Application.Run(new Form1());

            
        }
    }
}