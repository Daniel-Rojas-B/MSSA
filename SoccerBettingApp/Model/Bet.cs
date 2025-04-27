using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerBettingApp.Model
{
    public class Bet
    {
        public int BetId { get; set; }         // identity PK
        public int MatchId { get; set; }         // was string
        public string MatchName { get; set; }         // store name too
        public string SelectedOutcome { get; set; }       // "Home"/"Tie"/"Away"
        public decimal Amount { get; set; }
        public DateTime PlacedAt { get; set; }
        public Guid UserId { get; set; }
        public bool? IsCorrect { get; set; }         // optional
    }
}
