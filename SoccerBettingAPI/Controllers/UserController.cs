using Microsoft.AspNetCore.Mvc;
using SoccerBettingAPI.Data;
using SoccerBettingAPI.Models;
using Microsoft.AspNetCore.Authorization;
using BCrypt.Net;

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
        // **POST: Register a new user**
        [HttpPost("register")]
        public IActionResult Register([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest(new { message = "Invalid user data: Request body is empty." });
            }

            if (string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.PasswordHash) || string.IsNullOrEmpty(user.Email))
            {
                return BadRequest(new { message = "Missing required fields." });
            }
            user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(user.PasswordHash);
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return Ok(new { message = "User registered successfully!" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = "Registration failed.", error = ex.Message });
            }
                  
                      

            
        }
    }
}
