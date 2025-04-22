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

    private async void OnPlaceBetClicked(object sender, EventArgs e)
    {
        var button = (Button)sender;
        var selectedMatch = (Match)button.CommandParameter;
        var betViewModel = App.Services.GetRequiredService<BetViewModel>();
        await Navigation.PushAsync(new BetPage(betViewModel, selectedMatch));
    }

    private async void OnHistoryClicked(object sender, EventArgs e)
    {
        var historyViewModel = App.Services.GetRequiredService<HistoryViewModel>();
        await Navigation.PushAsync(new HistoryPage(historyViewModel));
    }
}
