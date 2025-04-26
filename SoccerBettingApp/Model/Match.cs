using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SoccerBettingApp.Model
{
    public class MatchOdd
    {
        public string Label { get; set; } // Home, Tie, Away
        public string Value { get; set; } // The odds value
        public int BookmakerId { get; set; } // Bookmaker ID
    }
    public class Match
    {
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
        
        
        public string HomeValue { get; set; }
        
        public string TieValue { get; set; }
        
        public string AwayValue { get; set; }

        // boolean properties for background color change
        public bool HomeSelected { get; set; }
        public bool TieSelected { get; set; }
        public bool AwaySelected { get; set; }

        // Odds for this match
        public List<MatchOdd> Odds { get; set; } = new List<MatchOdd>();
    }

    public class MatchApiResponse
    {
        [JsonProperty("data")]
        public List<Match> Data { get; set; }
    }
}
