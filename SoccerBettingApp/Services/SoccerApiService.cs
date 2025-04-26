using System;
using System.Net.Http;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SoccerBettingApp.Model; // Ensure you have your models defined

namespace SoccerBettingApp.Services
{
    public class SoccerApiService
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "https://api.sportmonks.com/v3/football/fixtures/between/2025-04-24/2025-05-01";

        private readonly string ApiToken = "DBsyG5AnMjQ31nhvc4yLGQZXhPnVtPxEZzw2htf96A4wCxnEpRd0mYkPULrJ"; // Ideally this should come from configuration

        public SoccerApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Match>> GetMatchesAsync()
        {
            //var fullUrl = $"{BaseUrl}?api_token={ApiToken}&filters=fixtureLeagues:8";
            var fullUrl = $"https://api.sportmonks.com/v3/football/fixtures/between/2025-04-27/2025-05-01?api_token=DBsyG5AnMjQ31nhvc4yLGQZXhPnVtPxEZzw2htf96A4wCxnEpRd0mYkPULrJ&include=odds&filters=markets:1;fixtureLeagues:8";
            try
            {
                var response = await _httpClient.GetAsync(fullUrl);
                
                response.EnsureSuccessStatusCode(); // Throws exception if status code is not successful

                string json = await response.Content.ReadAsStringAsync();

                //System.Diagnostics.Debug.WriteLine("Raw JSON response:\n" + json);


                if (string.IsNullOrEmpty(json))
                {
                    // Log or handle empty response scenario
                    return new List<Match>(); // Return an empty list if the response is empty
                }

                // Deserialize JSON to a list of Match objects
                // If your API returns a wrapper object around matches, you may need to adjust this line
                var apiResponse = JsonConvert.DeserializeObject<MatchApiResponse>(json);
                return apiResponse?.Data ?? new List<Match>();
                

                if (apiResponse == null || apiResponse.Data == null)
                {
                    return new List<Match>(); // No data received or deserialization failed
                }

                return apiResponse.Data;
            }
            catch (HttpRequestException ex)
            {
                // Log HttpRequestException details (e.g., bad URL, connectivity issues)
                Console.WriteLine($"HttpRequestException: {ex.Message}");
                return new List<Match>(); // Return an empty list if there's a request error
            }
            catch (JsonException ex)
            {
                // Log JSON deserialization error
                Console.WriteLine($"JsonException: {ex.Message}");
                return new List<Match>(); // Return an empty list if JSON parsing fails
            }
            catch (Exception ex)
            {
                // Catch any other unexpected exceptions
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return new List<Match>(); // Return an empty list for any other errors
            }
        }
        // Method to pull and map the odds to the Match class
        public async Task<List<Match>> GetMatchOddsAsync()
        {
            var matches = await GetMatchesAsync();

            foreach (var match in matches)
            {
                // Log the match name and the odds list to check if it's populated
                System.Diagnostics.Debug.WriteLine($"Processing match: {match.Name}");
                System.Diagnostics.Debug.WriteLine($"Odds List Count: {match.Odds?.Count ?? 0}");

                // Get all odds (don't filter by bookmaker)
                var odds = match.Odds?.ToList();

                if (odds != null && odds.Count > 0) // Ensure there are odds to process
                {
                    // Group the odds by label (Home, Draw, Away) and pick the first value
                    var groupedOdds = odds
                        .GroupBy(o => o.Label)
                        .ToDictionary(group => group.Key, group => group.First().Value);

                    // Get Home, Draw, and Away odds
                    if (groupedOdds.ContainsKey("Home"))
                        match.HomeValue = groupedOdds["Home"];

                    if (groupedOdds.ContainsKey("Draw"))
                        match.TieValue = groupedOdds["Draw"];

                    if (groupedOdds.ContainsKey("Away"))
                        match.AwayValue = groupedOdds["Away"];

                    // Log the values of Home, Tie, and Away odds after assignment
                    System.Diagnostics.Debug.WriteLine($"Home Value: {match.HomeValue}, Tie Value: {match.TieValue}, Away Value: {match.AwayValue}");
                }
                else
                {
                    // Log a message if no odds were found
                    System.Diagnostics.Debug.WriteLine($"No odds found for match: {match.Name}");
                }
            }

            return matches;
        }

    }
}
