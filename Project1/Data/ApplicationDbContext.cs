using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Project1.Models.Entities;

namespace Project1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
