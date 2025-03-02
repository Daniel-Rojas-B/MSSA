using System.ComponentModel.DataAnnotations;


namespace SoccerBettingAPI.Models
{
    public class Match
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string TeamA { get; set; }

        [Required]
        public string TeamB { get; set; }

        public DateTime MatchDate { get; set; }

        public decimal OddsTeamA { get; set; }
        public decimal OddsTeamB { get; set; }
        public decimal OddsDraw { get; set; }

        public string Result { get; set; } // "TeamA", "TeamB", "Draw" or "Pending"
    }
}
