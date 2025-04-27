using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using SoccerBettingApp.Model;
using SoccerBettingApp.Services;
using Microsoft.Maui.Controls;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace SoccerBettingApp.ViewModel
{
    public class MatchListViewModel : INotifyPropertyChanged
    {
        
        private readonly SoccerApiService _soccerApiService;

        public ObservableCollection<Match> Matches { get; set; } = new ObservableCollection<Match>();

        public Match SelectedMatch => Matches.FirstOrDefault(m =>
        m.IsHomeSelected || m.IsTieSelected || m.IsAwaySelected);

        // Constructor accepts SoccerApiService, which will be injected
        public MatchListViewModel(SoccerApiService soccerApiService)
        {
            _soccerApiService = soccerApiService;
            Matches = new ObservableCollection<Match>();
            LoadMatches();
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


        // === INotifyPropertyChanged Implementation ===
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}


