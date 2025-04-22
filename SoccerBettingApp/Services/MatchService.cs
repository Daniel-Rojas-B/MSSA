using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoccerBettingApp.Model;

namespace SoccerBettingApp.Services
{
    public class MatchService
    {
        public Task<List<Match>> GetUpcomingMatchesAsync()
        {
            return Task.FromResult(new List<Match>
        {
            new() { MatchId = "1", HomeTeam = "Team A", AwayTeam = "Team B", MatchDate = DateTime.Today },
            new() { MatchId = "2", HomeTeam = "Team C", AwayTeam = "Team D", MatchDate = DateTime.Today.AddDays(1) }
        });
        }
    }
}
