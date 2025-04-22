using System;
using System.Threading.Tasks;
using System.Windows.Input;
using SoccerBettingApp.Services;
using SoccerBettingApp.View;
using Microsoft.Maui.Controls;

namespace SoccerBettingApp.ViewModel
{
    public class LoginViewModel
    {
        private readonly UserService _userService;

        public string Username { get; set; }
        public ICommand LoginCommand { get; }

        // Constructor injection for UserService
        public LoginViewModel(UserService userService)
        {
            _userService = userService;
            LoginCommand = new Command(async () => await DoLoginAsync());
        }

        // Perform login asynchronously
        private async Task DoLoginAsync()
        {
            var success = await _userService.LoginAsync(Username);

            if (success)
            {
                // Resolve MatchListViewModel using DI
                var matchListViewModel = App.Services.GetRequiredService<MatchListViewModel>();

                // Pass it into MatchListPage constructor
                await Application.Current.MainPage.Navigation.PushAsync(new MatchListPage(matchListViewModel));
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Login Failed", "Invalid username", "OK");
            }
        }

    }
}



