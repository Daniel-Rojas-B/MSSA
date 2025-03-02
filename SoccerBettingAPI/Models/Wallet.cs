using System.ComponentModel.DataAnnotations;

namespace SoccerBettingAPI.Models
{
    public class Wallet
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        public decimal Balance { get; set; } = 0; // Default to zero

        public List<Transaction> Transactions { get; set; } = new List<Transaction>(); // List of transactions
    }
}
