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

        public ObservableCollection<Match> Matches { get; set; } = new();

        // Constructor accepts SoccerApiService, which will be injected
        public MatchListViewModel(SoccerApiService soccerApiService)
        {
            _soccerApiService = soccerApiService;
            Matches = new ObservableCollection<Match>();
            LoadMatches();
        }

        // LoadMatches method now uses SoccerApiService to get matches
        private async Task LoadMatches()
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
                        Matches.Add(match);
                    }
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

        // === INotifyPropertyChanged Implementation ===
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}


