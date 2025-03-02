using Microsoft.AspNetCore.Mvc;
using SoccerBettingAPI.Data;
using SoccerBettingAPI.Models;

namespace SoccerBettingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchController : ControllerBase
    {
        private readonly SoccerBettingContext _context;

        public MatchController(SoccerBettingContext context)
        {
            _context = context;
        }

        // ✅ Get all matches
        [HttpGet]
        public IActionResult GetMatches()
        {
            var matches = _context.Matches.ToList();
            return Ok(matches);
        }
    }
}
