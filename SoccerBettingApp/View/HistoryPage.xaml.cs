
using SoccerBettingApp.Services;
using SoccerBettingApp.ViewModel;

namespace SoccerBettingApp.View;

public partial class HistoryPage : ContentPage
{
    public HistoryPage(HistoryViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}