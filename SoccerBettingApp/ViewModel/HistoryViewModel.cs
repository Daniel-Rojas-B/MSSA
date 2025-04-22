using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using SoccerBettingApp.Services;
using SoccerBettingApp.Model;
using Microsoft.Maui.Controls;

namespace SoccerBettingApp.ViewModel
{
    public class HistoryViewModel
    {
        private readonly BetService _betService;
        private readonly UserService _userService;

        public ObservableCollection<Bet> Bets { get; } = new();

        public HistoryViewModel(BetService betService, UserService userService)
        {
            _betService = betService;
            _userService = userService;
            _ = LoadBetsAsync(); // Fire and forget (can also await in UI if needed)
        }

        private async Task LoadBetsAsync()
        {
            var user = _userService.CurrentUser;
            if (user == null)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "User not logged in.", "OK");
                return;
            }

            var bets = await _betService.GetUserBetsAsync(user.Id);
            Bets.Clear();
            foreach (var bet in bets)
                Bets.Add(bet);
        }
    }
}
