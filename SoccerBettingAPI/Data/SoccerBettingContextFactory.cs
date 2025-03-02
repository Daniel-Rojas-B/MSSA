using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace SoccerBettingAPI.Data
{
    public class SoccerBettingContextFactory : IDesignTimeDbContextFactory<SoccerBettingContext>
    {
        public SoccerBettingContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<SoccerBettingContext>();
            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));

            return new SoccerBettingContext(optionsBuilder.Options);
        }
    }
}