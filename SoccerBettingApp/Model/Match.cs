using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerBettingApp.Model
{
    public class Match
    {
        public int MatchId { get; set; }
        public string Name { get; set; }
        public string StartingAt { get; set; }

        public string DisplayTitle => Name;
        public string DisplayDate =>
            DateTime.TryParse(StartingAt, out var date)
                ? date.ToString("dddd, MMMM dd, yyyy hh:mm tt")
                : StartingAt;

    }
    public class MatchApiResponse
    {
        public List<Match> Data { get; set; }
    }
}
