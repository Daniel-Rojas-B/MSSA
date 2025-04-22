using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoccerBettingApp.Model;

namespace SoccerBettingApp.Services
{
    public class BetService
    {
        private readonly List<Bet> _bets = new();

        public void PlaceBet(Bet bet)
        {
            _bets.Add(bet);
        }

        public List<Bet> GetUserBets(Guid userId)
        {
            return _bets.Where(b => b.UserId == userId).ToList();
        }
        public async Task<List<Bet>> GetUserBetsAsync(Guid userId)
        {
            // Simulate delay + fetch
            await Task.Delay(100);
            return _bets.Where(b => b.UserId == userId).ToList();
        }
    }
}
