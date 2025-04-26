//using System.Net.Http.Json;
//using SoccerBettingApp.Model;

//public class MatchService
//{
//    private readonly HttpClient _httpClient;

//    public MatchService()
//    {
//        _httpClient = new HttpClient();
//    }

//    public async Task<List<Match>> GetMatchesAsync()
//    {
//        var url = "https://api.sportmonks.com/v3/football/fixtures/between/2025-04-24/2025-05-01?api_token=DBsyG5AnMjQ31nhvc4yLGQZXhPnVtPxEZzw2htf96A4wCxnEpRd0mYkPULrJ&include=odds&filters=markets:1;fixtureLeagues:8";

//        var response = await _httpClient.GetAsync(url);
//        if (!response.IsSuccessStatusCode)
//            return new List<Match>();

//        var jsonString = await response.Content.ReadAsStringAsync();

//        var apiResponse = JsonSerializer.Deserialize<ApiResponse>(jsonString);

//        // Map the API response to your Match objects
//        var matches = new List<Match>();

//        foreach (var fixture in apiResponse.data)
//        {
//            var match = new Match
//            {
//                DisplayTitle = $"{fixture.homeTeamName} vs {fixture.awayTeamName}",
//                DisplayDate = fixture.starting_at.ToString("g"),
//                HomeValue = fixture.odds?.FirstOrDefault(x => x.label == "Home")?.value ?? "-",
//                TieValue = fixture.odds?.FirstOrDefault(x => x.label == "Draw")?.value ?? "-",
//                AwayValue = fixture.odds?.FirstOrDefault(x => x.label == "Away")?.value ?? "-"
//            };
//            matches.Add(match);
//        }

//        return matches;
//    }
//}



