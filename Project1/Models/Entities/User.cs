namespace Project1.Models.Entities
{
    public class User
    {
        public int Id { get; set; } // Unique identifier for the user
        public required string FirstName { get; set; } = string.Empty;
        public required string LastName { get; set; } = string.Empty;
        public required string Username { get; set; } = string.Empty;
        public required string Email { get; set; } = string.Empty;
        public required string PasswordHash { get; set; } = string.Empty; // Store hashed passwords
        public bool IsActive { get; set; } = true; // Indicates if the account is active
    }
}
