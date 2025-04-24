using SoccerBettingApp.Model;
using SoccerBettingApp.Services;
using SoccerBettingApp.ViewModel;

namespace SoccerBettingApp.View;

public partial class MatchListPage : ContentPage
    {
        public MatchListPage()
        {
            InitializeComponent();

            // Create an HttpClient instance
            var httpClient = new HttpClient();

            // Pass the HttpClient to SoccerApiService constructor
            var _soccerApiService = new SoccerApiService(httpClient);

            // Set the BindingContext
            BindingContext = new MatchListViewModel(_soccerApiService);
        }
    }

