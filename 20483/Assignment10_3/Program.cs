using Assignment10_3.Data;

using Microsoft.EntityFrameworkCore;

namespace Assignment10_3
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

            Records.carContext = new CarContext();
            Records.carContext.Database.EnsureCreated();
            Records.carContext.Cars.Load();

            Application.Run(new Form1());
        }
    }
}