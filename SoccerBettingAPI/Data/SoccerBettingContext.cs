using Microsoft.EntityFrameworkCore;
using SoccerBettingAPI.Models;

namespace SoccerBettingAPI.Data
{
    public class SoccerBettingContext : DbContext
    {
        // ✅ Add a parameterless constructor for design-time migrations
        public SoccerBettingContext() { }

        public SoccerBettingContext(DbContextOptions<SoccerBettingContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Bet> Bets { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
