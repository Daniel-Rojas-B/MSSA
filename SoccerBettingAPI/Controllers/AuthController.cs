using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using BCrypt.Net;
using SoccerBettingAPI.Data;

namespace SoccerBettingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _config;

        public AuthController(IConfiguration config)
        {
            _config = config;
        }

        // ✅ Authenticate user and return JWT token
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLogin userLogin, [FromServices] SoccerBettingContext _context)
        {
            if (userLogin == null || string.IsNullOrEmpty(userLogin.Username) || string.IsNullOrEmpty(userLogin.Password))
            {
                return BadRequest(new { message = "Invalid request. Username and password are required." });
            }

            // Find the user in the database
            var user = await _context.Users
                .Where(u => u.Username == userLogin.Username)
                .FirstOrDefaultAsync();

            if (user == null)
            {
                return Unauthorized(new { message = "User not found" });
            }

            // Verify the hashed password using BCrypt
            if (!BCrypt.Net.BCrypt.Verify(userLogin.Password, user.PasswordHash))
            {
                return Unauthorized(new { message = "Invalid username or password" });
            }

            // Generate JWT token (assuming you have this method)
            var token = GenerateJwtToken(user.Username);

            return Ok(new { token });
        }

        private string GenerateJwtToken(string username)
        {
            var secretKey = _config["JwtSettings:Key"];

            if (string.IsNullOrEmpty(secretKey))
            {
                throw new ArgumentNullException("JwtSettings:Key is null. Make sure it's set in appsettings.json.");
            }

            var key = Encoding.UTF8.GetBytes(secretKey);

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, username) }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }


    }

    public class UserLogin
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
