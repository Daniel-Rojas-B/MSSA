using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Newtonsoft.Json;

namespace SoccerBettingApp.Model
{
    public class MatchOdd
    {
        public string Label { get; set; } // Home, Tie, Away
        public string Value { get; set; } // The odds value
        public int BookmakerId { get; set; } // Bookmaker ID
    }
    public class Match : INotifyPropertyChanged
    {
        decimal _betAmount;
        public decimal BetAmount
        {
            get => _betAmount;
            set
            {
                if (_betAmount != value)
                {
                    _betAmount = value;
                    OnPropertyChanged();
                }
            }
        }
        [JsonProperty("id")]
        public int MatchId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("starting_at")]
        public string StartingAt { get; set; }

        public string DisplayTitle => Name;

        public string DisplayDate =>
            DateTime.TryParse(StartingAt, out var date)
                ? date.ToString("dddd, MMMM dd, yyyy hh:mm tt")
                : StartingAt ?? "No date available";


        private string _homeValue;
        public string HomeValue
        {
            get => _homeValue;
            set
            {
                _homeValue = value;
                OnPropertyChanged();
            }
        }

        private string _tieValue;
        public string TieValue
        {
            get => _tieValue;
            set
            {
                _tieValue = value;
                OnPropertyChanged();
            }
        }

        private string _awayValue;
        public string AwayValue
        {
            get => _awayValue;
            set
            {
                _awayValue = value;
                OnPropertyChanged();
            }
        }

        private string _selectedOutcome; // "Home", "Tie", or "Away"
        public string SelectedOutcome
        {
            get => _selectedOutcome;
            set
            {
                if (_selectedOutcome != value)
                {
                    _selectedOutcome = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(IsHomeSelected));
                    OnPropertyChanged(nameof(IsTieSelected));
                    OnPropertyChanged(nameof(IsAwaySelected));
                }
            }
        }

        // Helper properties for binding
        public bool IsHomeSelected => SelectedOutcome == "Home";
        public bool IsTieSelected => SelectedOutcome == "Tie";
        public bool IsAwaySelected => SelectedOutcome == "Away";

        // Commands
        public ICommand SelectHomeCommand { get; set; }
        public ICommand SelectTieCommand { get; set; }
        public ICommand SelectAwayCommand { get; set; }

        public Match()
        {
            SelectHomeCommand = new Command(SelectHome);
            SelectTieCommand = new Command(SelectTie);
            SelectAwayCommand = new Command(SelectAway);
        }

        // Odds for this match
        public List<MatchOdd> Odds { get; set; } = new List<MatchOdd>();

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public void SelectHome()
        {
            SelectedOutcome = "Home";
        }

        public void SelectTie()
        {
            SelectedOutcome = "Tie";
        }

        public void SelectAway()
        {
            SelectedOutcome = "Away";
        }

    }

    public class MatchApiResponse
    {
        [JsonProperty("data")]
        public List<Match> Data { get; set; }
    }


}
