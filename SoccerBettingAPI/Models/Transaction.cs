using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SoccerBettingAPI.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int WalletId { get; set; } // Foreign key for Wallet
        [ForeignKey("WalletId")]
        public Wallet Wallet { get; set; }

        [Required]
        public decimal Amount { get; set; } // Positive for deposit, negative for withdrawal

        [Required]
        public DateTime TransactionDate { get; set; } = DateTime.UtcNow; // Default to current date

        [Required]
        public string Type { get; set; } // "Deposit", "Withdrawal", "Bet Placed", "Bet Won"

        public string Description { get; set; } // Optional description
    }
}
