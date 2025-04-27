using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using SoccerBettingApp.Model;
using SoccerBettingApp.Services;
using Microsoft.Maui.Controls;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SoccerBettingApp.ViewModel
{
    public partial class MatchListViewModel : ObservableObject

    {
        
        private readonly SoccerApiService _soccerApiService;
        readonly AzureSqlService _db;
        readonly UserService _user;

        public ObservableCollection<Match> Matches { get; set; } = new();

        [ObservableProperty] 
        private Match selectedMatch;

        [ObservableProperty] 
        private decimal betAmount;

        // DIFFERENT property (no conflict with SelectedMatch)
        public Match FirstSelectedMatch => Matches.FirstOrDefault(m => m.IsHomeSelected || m.IsTieSelected || m.IsAwaySelected);

        // Constructor accepts SoccerApiService, which will be injected
        public MatchListViewModel(SoccerApiService soccerApiService, AzureSqlService db,  UserService userService)
        {
            _soccerApiService = soccerApiService;
            _db = db;
            _user = userService;
            _ = LoadMatchesAsync();
        }

        [RelayCommand]
        private async Task LoadMatchesAsync()
        {
            try
            {
                var list = await _soccerApiService.GetMatchOddsAsync();
                Matches.Clear();
                foreach (var m in list)
                    Matches.Add(m);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading matches: {ex.Message}");
            }
        }

        [RelayCommand]
        private async Task PlaceBetAsync()
        {
            if (SelectedMatch == null || SelectedMatch.SelectedOutcome == null || BetAmount <= 0)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Select Home/Tie/Away and enter an amount", "OK");
                return;
            }

            var user = _user.CurrentUser;
            if (user == null)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Not logged in", "OK");
                return;
            }

            var bet = new Bet
            {
                MatchId = SelectedMatch.MatchId,
                MatchName = SelectedMatch.Name,
                SelectedOutcome = SelectedMatch.SelectedOutcome,
                Amount = BetAmount,
                PlacedAt = DateTime.UtcNow,
                UserId = user.Id
            };

            await _db.PlaceBetAsync(bet);

            // Reset
            BetAmount = 0;
            SelectedMatch.SelectedOutcome = null;

            // Navigate to MyBets
            await Shell.Current.GoToAsync(nameof(View.BetPage));
        }

        // LoadMatches method now uses SoccerApiService to get matches
        public async Task LoadMatches()
        {
            try
            {
                // Calling the GetMatchesAsync method from SoccerApiService
                var matches = await _soccerApiService.GetMatchesAsync(); // Matches will now be a List<Match>

                if (matches != null && matches.Any())
                {
                    Matches.Clear(); // Clear any existing matches in the ObservableCollection

                    // Add each match to the ObservableCollection individually
                    foreach (var match in matches)
                    {
                        // System.Diagnostics.Debug.WriteLine($"Loaded Match: {match.Name}, Date: {match.StartingAt}");  // debugging line
                        
                        Matches.Add(match);
                    }
                    // Now load the odds for the matches
                    await LoadOdds();
                }
                else
                {
                    // Handle the case when there are no matches or when the list is null
                    Console.WriteLine("No matches found.");
                }
            }
            catch (Exception ex)
            {
                // Handle the error if something goes wrong
                Console.WriteLine($"Error loading matches: {ex.Message}");
            }
        }

        // LoadOdds method now fetches odds for the matches
        private async Task LoadOdds()
        {
            try
            {
                // Get the matches with odds
                var matchesWithOdds = await _soccerApiService.GetMatchOddsAsync();
                Console.WriteLine($"Fetched {matchesWithOdds.Count} matches with odds");

                // Update the Matches collection with odds data
                foreach (var match in matchesWithOdds)
                {
                    Console.WriteLine($"Match: {match.Name}, Home: {match.HomeValue}, Tie: {match.TieValue}, Away: {match.AwayValue}");
                    // Update the properties with the fetched odds
                    var existingMatch = Matches.FirstOrDefault(m => m.MatchId == match.MatchId);
                    if (existingMatch != null)
                    {
                        existingMatch.HomeValue = match.HomeValue;
                        existingMatch.TieValue = match.TieValue;
                        existingMatch.AwayValue = match.AwayValue;

                        Console.WriteLine($"Updated match {existingMatch.Name} with odds");
                    }
                }

                // Notify the UI about the changes to the matches (with odds)
                OnPropertyChanged(nameof(Matches)); // Notify UI that the collection has changed
            }
            catch (Exception ex)
            {
                // Handle the error if something goes wrong
                Console.WriteLine($"Error loading odds: {ex.Message}");
            }
        }


        
    }
}


