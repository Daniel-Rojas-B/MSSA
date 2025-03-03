using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Cors;

namespace SoccerBettingAPI.Controllers
{
    [EnableCors("_myAllowSpecificOrigins")]
    [ApiController]
    [Route("api/[controller]")]
    public class PredictionController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        private readonly string _openAiApiKey;

        public PredictionController(IConfiguration configuration, HttpClient httpClient)
        {
            _httpClient = httpClient ?? new HttpClient();
            _openAiApiKey = configuration["OpenAI:ApiKey"];

            if (string.IsNullOrEmpty(_openAiApiKey))
            {
                throw new ArgumentException("OpenAI API key is missing from configuration.");
            }
        }


        [HttpGet("match")]
        public async Task<IActionResult> GetMatchPrediction(string homeTeam, string awayTeam)
        {
            var requestBody = new
            {
                model = "gpt-3.5-turbo",
                messages = new[]
                {
            new { role = "system", content = "You are a soccer match predictor." },
            new { role = "user", content = $"Based on the current form, team statistics, head-to-head results, and key player performances, give a brief description of {homeTeam} vs {awayTeam} match. Provide a 4 sentences paragraph for your prediction. Give me a tentative score" }
        }
            };

            var jsonRequest = JsonConvert.SerializeObject(requestBody);
            var request = new HttpRequestMessage(HttpMethod.Post, "https://api.openai.com/v1/chat/completions")
            {
                Content = new StringContent(jsonRequest, Encoding.UTF8, "application/json"),
                Headers = { { "Authorization", $"Bearer {_openAiApiKey}" } }
            };

            // Send request to OpenAI API
            var response = await _httpClient.SendAsync(request);

            if (!response.IsSuccessStatusCode)  // Handle API errors
            {
                var errorMessage = await response.Content.ReadAsStringAsync();
                return StatusCode((int)response.StatusCode, new { error = "Failed to fetch prediction", details = errorMessage });
            }

            var jsonResponse = await response.Content.ReadAsStringAsync();
            var responseData = JsonConvert.DeserializeObject<dynamic>(jsonResponse);

            // Ensure choices and message exist in response
            if (responseData?.choices == null || responseData.choices.Count == 0 || responseData.choices[0]?.message?.content == null)
            {
                return StatusCode(500, new { error = "Invalid response from OpenAI API", response = jsonResponse });
            }

            return Ok(new { prediction = (string)responseData.choices[0].message.content });
        }

    }
}

