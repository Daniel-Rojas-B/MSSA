using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SoccerBettingApp.Model
{
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
    }

    public class MatchApiResponse
    {
        [JsonProperty("data")]
        public List<Match> Data { get; set; }
    }
}
