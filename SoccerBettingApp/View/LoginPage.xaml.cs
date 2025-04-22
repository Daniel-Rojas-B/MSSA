using SoccerBettingApp.Services;
using SoccerBettingApp.ViewModel;

namespace SoccerBettingApp.View;

public partial class LoginPage : ContentPage
{
    public LoginPage(LoginViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
