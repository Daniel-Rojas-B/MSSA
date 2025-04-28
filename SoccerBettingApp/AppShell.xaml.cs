using SoccerBettingApp.View;

namespace SoccerBettingApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Register the route name "BetPage" to the BetPage type
            Routing.RegisterRoute(nameof(BetPage), typeof(BetPage));
            Routing.RegisterRoute("MainPage", typeof(MatchListPage));
        }
    }
}
