using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;
using SoccerBettingApp.Model;
using SoccerBettingApp.Services;
using Microsoft.Maui.Controls;

namespace SoccerBettingApp.ViewModel
{
    public partial class BetViewModel : ObservableObject
    {
        readonly AzureSqlService _db;
        readonly UserService _user;

        public ObservableCollection<Bet> Bets { get; } = new();

        public BetViewModel(AzureSqlService db, UserService user)
        {
            _db = db;
            _user = user;
            _ = LoadBetsAsync();

        }

        [RelayCommand]
        async Task LoadBetsAsync()
        {
            Bets.Clear();
            var u = _user.CurrentUser?.Id ?? Guid.Empty;
            var list = await _db.GetUserBetsAsync(u);
            foreach (var b in list)
                Bets.Add(b);
        }
    }
}

