using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerBettingApp.Model
{
    public class Bet
    {
        public string MatchId { get; set; }
        public string SelectedOutcome { get; set; } // "Win", "Draw", "Lose"
        public DateTime PlacedAt { get; set; }
        public Guid UserId { get; set; }
        public bool? IsCorrect { get; set; } // null until match is complete
    }
}
