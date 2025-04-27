using SoccerBettingApp.Model;
using SoccerBettingApp.Services;
using SoccerBettingApp.ViewModel;

namespace SoccerBettingApp.View;

public partial class BetPage : ContentPage
{
    public BetPage(BetViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}