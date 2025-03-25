using System.Configuration;
using System.Data;
using System.Windows;
using Assignment11_1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Assignment11_1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ServiceProvider _serviceProvider;
        public App()
        {
            ServiceCollection services = new ServiceCollection();
            services.AddDbContext<BookContext>(option =>
            {
                option.UseSqlite("Data Source=Books.db");
            }
            );
            services.AddSingleton<MainWindow>();
            _serviceProvider = services.BuildServiceProvider();
        }
        private void OnstartUp(object sender, StartupEventArgs e)
        {
            var mainWindow = _serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }
    }

}
