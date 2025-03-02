using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SoccerBettingAPI.Models
{
    public class Bet
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        [Required]
        public int MatchId { get; set; }
        [ForeignKey("MatchId")]
        public Match Match { get; set; }

        [Required]
        public string BetType { get; set; } // "TeamA", "TeamB", "Draw"

        [Required]
        public decimal Amount { get; set; } // Bet amount

        public decimal? Payout { get; set; } // If null, the bet is still active

        public string Status { get; set; } = "Pending"; // "Pending", "Won", "Lost"
    }
}
