using System;
using System.Threading.Tasks;
using System.Windows.Input;
using SoccerBettingApp.Services;
using SoccerBettingApp.View;
using Microsoft.Maui.Controls;
using System.ComponentModel;

namespace SoccerBettingApp.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        

        private readonly UserService _userService;
        private readonly AzureSqlService _sqlService;

        public string Username { get; set; }
        public string Password { get; set; }

        public string NewUsername { get; set; }
        public string NewPassword { get; set; }

        public ICommand LoginCommand { get; }
        public ICommand RegisterCommand { get; }

        public LoginViewModel(UserService userService, AzureSqlService sqlService)
        {
            Console.WriteLine("LoginViewModel initialized");

            _userService = userService;
            _sqlService = sqlService;

            LoginCommand = new Command(async () => await DoLoginAsync());
            RegisterCommand = new Command(async () => await RegisterUserAsync());
        }

        private async Task DoLoginAsync()
        {
            var success = await _sqlService.ValidateUserAsync(Username, Password);

            if (success)
            {
                var matchListViewModel = App.Services.GetRequiredService<MatchListViewModel>();
                await Application.Current.MainPage.Navigation.PushAsync(new MatchListPage());
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Login Failed", "Invalid username or password", "OK");
            }
        }

        private async Task RegisterUserAsync()
        {
            Console.WriteLine("Register button clicked!");

            if (string.IsNullOrWhiteSpace(NewUsername) || string.IsNullOrWhiteSpace(NewPassword))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Please enter both username and password.", "OK");
                return;
            }

            var result = await _sqlService.RegisterUserAsync(NewUsername, NewPassword);
            if (result)
            {
                await Application.Current.MainPage.DisplayAlert("Success", "Registration complete!", "OK");
                NewUsername = string.Empty;
                NewPassword = string.Empty;
                OnPropertyChanged(nameof(NewUsername));
                OnPropertyChanged(nameof(NewPassword));
                var matchListViewModel = App.Services.GetRequiredService<MatchListViewModel>();
                await Application.Current.MainPage.Navigation.PushAsync(new MatchListPage());
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Registration failed. Try again.", "OK");
            }
            
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}





