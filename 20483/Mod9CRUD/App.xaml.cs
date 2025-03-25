using System.Configuration;
using System.Data;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Mod9CRUD.Data;

namespace Mod9CRUD
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        // we configured our dependencies in following code and registered them with services collection

        private ServiceProvider _serviceProvider;
        public App()
        {
            //collection of services
            ServiceCollection services = new ServiceCollection();
            services.AddDbContext<ProductContext>(option =>
            {
                option.UseSqlite("Data Source=Products.db");
            }
            );
            services.AddSingleton<MainWindow>();
            _serviceProvider = services.BuildServiceProvider();
        }

        private void OnStartUp(object sender, StartupEventArgs e)
        {
            var mainWindow = _serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {

        }
    }

}
