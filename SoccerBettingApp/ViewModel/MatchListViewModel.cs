using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using SoccerBettingApp.Model;
using SoccerBettingApp.Services;
using Microsoft.Maui.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Linq;
using Microsoft.Data.SqlClient;
using SoccerBettingApp.View;
using System.Diagnostics;



namespace SoccerBettingApp.ViewModel
{
    public partial class MatchListViewModel : ObservableObject
    {
        private readonly SoccerApiService _soccerApiService;
        private readonly AzureSqlService _db;
        private readonly UserService _user;

        

        public ObservableCollection<Match> Matches { get; } = new();

        [ObservableProperty]
        private Match selectedMatch;

        

        public MatchListViewModel(SoccerApiService soccerApiService, AzureSqlService db, UserService userService)
        {
            _soccerApiService = soccerApiService;
            _db = db;
            _user = userService;
            _ = LoadMatchesAsync();

            //  TEMPORARY FOR TESTING ONLY
            _user.CurrentUser = new User
            {
                Id = Guid.NewGuid(),  // or some static Guid
                Username = "TestUser"
            };
        }

        [RelayCommand]
        private async Task LoadMatchesAsync()
        {
            try
            {
                var list = await _soccerApiService.GetMatchOddsAsync();
                Matches.Clear();
                foreach (var match in list)
                {
                    // Hook into when a match is clicked
                    match.SelectHomeCommand = new Command(() => SelectOutcome(match, "Home"));
                    match.SelectTieCommand = new Command(() => SelectOutcome(match, "Tie"));
                    match.SelectAwayCommand = new Command(() => SelectOutcome(match, "Away"));
                    Matches.Add(match);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading matches: {ex.Message}");
            }
        }

        private void SelectOutcome(Match match, string outcome)
        {
            // Reset selection for all matches
            foreach (var m in Matches)
            {
                m.SelectedOutcome = null;
            }

            // Set selected outcome for this match
            match.SelectedOutcome = outcome;

            // Update SelectedMatch to this match
            SelectedMatch = match;
        }

        [RelayCommand]
        async Task PlaceBetAsync()
        {
            var m = SelectedMatch;

            if (m == null
                || m.SelectedOutcome == null
                || m.BetAmount <= 0)                    // <-- read from m.BetAmount now
            {
                await Application.Current.MainPage
                     .DisplayAlert("Error", "Select Home/Tie/Away and enter an amount", "OK");
                return;
            }

            var user = _user.CurrentUser;
            if (user == null)
            {
                await Application.Current.MainPage
                     .DisplayAlert("Error", "User not logged in", "OK");
                return;
            }

            decimal odds = SelectedMatch.SelectedOutcome switch
            {
                "Home" => decimal.Parse(SelectedMatch.HomeValue),
                "Tie" => decimal.Parse(SelectedMatch.TieValue),
                "Away" => decimal.Parse(SelectedMatch.AwayValue),
                _ => 0
            };

            // Build your Bet entity using m.BetAmount
            var bet = new Bet
            {
                MatchId = m.MatchId,
                MatchName = m.Name,
                SelectedOutcome = m.SelectedOutcome,
                Amount = m.BetAmount,
                OddsValue = odds,
                PlacedAt = DateTime.UtcNow,
                UserId = user.Id
            };

            try
            {
                await _db.PlaceBetAsync(bet);
            }
            catch (SqlException ex)
            {
                // Log it so you can read it
                System.Diagnostics.Debug.WriteLine("SQL Error: " + ex.Message);
                foreach (SqlError err in ex.Errors)
                    System.Diagnostics.Debug.WriteLine($"  ➜ {err.Message}");

                await Application.Current.MainPage
                     .DisplayAlert("Database Error", ex.Message, "OK");
                return;
            }

            // clear per‐match amount if you like:
            m.BetAmount = 0;

            await Application.Current.MainPage
                 .DisplayAlert("Success", "Your bet has been placed!", "OK");

            // debugging lines to see whats the main page
            Debug.WriteLine($"Application.Current: {Application.Current}");
            Debug.WriteLine($"MainPage type: {Application.Current?.MainPage?.GetType().FullName}");
            Debug.WriteLine($"Shell.Current: {Shell.Current}");

            try
            {
                var dbService = ServiceHelper.GetService<AzureSqlService>();
                var userService = ServiceHelper.GetService<UserService>();
                var viewModel = new BetViewModel(dbService, userService);
                await Application.Current.MainPage.Navigation.PushAsync(new BetPage(viewModel));
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"❗ Navigation failed: {ex}");
                throw;
            }
        }

        private async Task LoadOdds()
        {
            try
            {
                var matchesWithOdds = await _soccerApiService.GetMatchOddsAsync();
                foreach (var match in matchesWithOdds)
                {
                    var existingMatch = Matches.FirstOrDefault(m => m.MatchId == match.MatchId);
                    if (existingMatch != null)
                    {
                        existingMatch.HomeValue = match.HomeValue;
                        existingMatch.TieValue = match.TieValue;
                        existingMatch.AwayValue = match.AwayValue;
                    }
                }

                OnPropertyChanged(nameof(Matches));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading odds: {ex.Message}");
            }
        }
    }
}



