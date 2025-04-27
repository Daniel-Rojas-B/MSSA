using SoccerBettingApp.Model;
using SoccerBettingApp.Services;
using SoccerBettingApp.ViewModel;

namespace SoccerBettingApp.View;

public partial class MatchListPage : ContentPage
{
    public MatchListPage(MatchListViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}

