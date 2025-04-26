using System;
using System.Net.Http;
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
            var fullUrl = $"{BaseUrl}?api_token={ApiToken}&filters=fixtureLeagues:8";

            try
            {
                var response = await _httpClient.GetAsync(fullUrl);
                
                response.EnsureSuccessStatusCode(); // Throws exception if status code is not successful

                string json = await response.Content.ReadAsStringAsync();

                System.Diagnostics.Debug.WriteLine("Raw JSON response:\n" + json);


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

    }
}
