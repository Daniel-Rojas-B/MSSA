using Microsoft.AspNetCore.Mvc;
using SoccerBettingAPI.Data;
using SoccerBettingAPI.Models;
using Microsoft.AspNetCore.Authorization;

namespace SoccerBettingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly SoccerBettingContext _context;

        public UserController(SoccerBettingContext context)
        {
            _context = context;
        }

        // ✅ Get all users
        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _context.Users.ToList();
            return Ok(users);
        }

        // ✅ Get a user by ID
        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null) return NotFound();
            return Ok(user);
        }
    }
}
