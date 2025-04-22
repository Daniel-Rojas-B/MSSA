using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using SoccerBettingApp.Model;
using SoccerBettingApp.Services;
using Microsoft.Maui.Controls;

namespace SoccerBettingApp.ViewModel
{
    public class BetViewModel
    {
        private readonly BetService _betService;
        private readonly UserService _userService;

        public Match SelectedMatch { get; set; }
        public string SelectedOutcome { get; set; }
        public List<string> Outcomes { get; } = new() { "Win", "Draw", "Lose" };

        public ICommand PlaceBetCommand { get; }

        public BetViewModel(BetService betService, UserService userService)
        {
            _betService = betService;
            _userService = userService;
            PlaceBetCommand = new Command(async () => await PlaceBetAsync());
        }

        private async Task PlaceBetAsync()
        {
            if (SelectedMatch == null || string.IsNullOrEmpty(SelectedOutcome))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Please select a match and outcome", "OK");
                return;
            }

            var currentUser = _userService.CurrentUser;

            if (currentUser == null)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "User not logged in", "OK");
                return;
            }

            var bet = new Bet
            {
                MatchId = SelectedMatch.MatchId,
                SelectedOutcome = SelectedOutcome,
                PlacedAt = DateTime.Now,
                UserId = currentUser.Id
            };

            _betService.PlaceBet(bet);
            await Application.Current.MainPage.DisplayAlert("Success", "Your bet has been placed!", "OK");

            // Optional: Navigate or clear fields
        }
    }
}

