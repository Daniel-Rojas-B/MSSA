using Microsoft.AspNetCore.Mvc;
using SoccerBettingAPI.Data;
using SoccerBettingAPI.Models;

namespace SoccerBettingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BetController : ControllerBase
    {
        private readonly SoccerBettingContext _context;

        public BetController(SoccerBettingContext context)
        {
            _context = context;
        }

        // ✅ Get all bets
        [HttpGet]
        public IActionResult GetBets()
        {
            var bets = _context.Bets.ToList();
            return Ok(bets);
        }
    }
}
