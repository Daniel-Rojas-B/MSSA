using SoccerBettingApp.View;
using SoccerBettingApp.Services;

namespace SoccerBettingApp
{
    public partial class App : Application
    {
        public App(LoginPage loginPage)
        {
            InitializeComponent();
            MainPage = new NavigationPage(loginPage); // Or use NavigationPage(new LoginPage()) if not using Shell
        }

        //  Safe access to the DI service provider
        public static IServiceProvider Services =>
            Current?.Handler?.MauiContext?.Services!;


    }
}

