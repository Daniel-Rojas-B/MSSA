using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using SoccerBettingApp.Model;
using SoccerBettingApp.Services;
using Microsoft.Maui.Controls;

namespace SoccerBettingApp.ViewModel
{
    public class MatchListViewModel
    {
        private readonly MatchService _matchService;

        public ObservableCollection<Match> Matches { get; } = new();

        public MatchListViewModel(MatchService matchService)
        {
            _matchService = matchService;
            _ = LoadMatchesAsync(); // fire and forget; optionally await from UI
        }

        private async Task LoadMatchesAsync()
        {
            try
            {
                var list = await _matchService.GetUpcomingMatchesAsync();
                Matches.Clear();

                foreach (var match in list)
                    Matches.Add(match);
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", $"Failed to load matches: {ex.Message}", "OK");
            }
        }
    }
}

