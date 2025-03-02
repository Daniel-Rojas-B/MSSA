using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoccerBettingAPI.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Username { get; set; }

        [Required]
        public string PasswordHash { get; set; } // Hashed password for security

        [Required, EmailAddress]
        public string Email { get; set; }

        public decimal WalletBalance { get; set; } = 0; // Default balance is 0

        public List<Bet> Bets { get; set; } = new List<Bet>(); // One user can have many bets
    }
}
