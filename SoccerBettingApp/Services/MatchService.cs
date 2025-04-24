using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using SoccerBettingApp.Model;

namespace SoccerBettingApp.Services
{
    public class MatchService
    {
        private readonly HttpClient _httpClient;
        private const string ApiUrl = "https://api.sportmonks.com/v3/football/fixtures/between/2025-04-24/2025-04-30?api_token=DBsyG5AnMjQ31nhvc4yLGQZXhPnVtPxEZzw2htf96A4wCxnEpRd0mYkPULrJ&include=league";

        public MatchService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<Match>> GetMatchesAsync()
        {
            try
            {
                var response = await _httpClient.GetStringAsync(ApiUrl);
                var jsonDoc = JsonDocument.Parse(response);

                var matches = new List<Match>();

                if (jsonDoc.RootElement.TryGetProperty("data", out JsonElement dataArray))
                {
                    foreach (var item in dataArray.EnumerateArray())
                    {
                        var name = item.GetProperty("name").GetString();
                        var startingAt = item.GetProperty("starting_at").GetString();

                        matches.Add(new Match
                        {
                            Name = name,
                            StartingAt = startingAt
                        });
                    }
                }

                return matches;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching matches: {ex.Message}");
                return new List<Match>();
            }
        }
    }
}

    
