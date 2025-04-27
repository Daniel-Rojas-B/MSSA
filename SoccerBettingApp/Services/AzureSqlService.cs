using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using SoccerBettingApp.Model;

namespace SoccerBettingApp.Services
{    

    public class AzureSqlService
    {
        private readonly string _connectionString;

        public AzureSqlService(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("AzureSQL");
        }

        // Method to validate user credentials
        public async Task<bool> ValidateUserAsync(string username, string password)
        {
            try
            {
                // Create a connection to your Azure SQL Database
                using (var connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync(); // Asynchronous connection open

                    // SQL query to validate the user (replace with your actual table and column names)
                    string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";

                    using (var command = new SqlCommand(query, connection))
                    {
                        // Add parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        // Execute the query and get the result
                        var result = (int)await command.ExecuteScalarAsync();

                        // If the result is greater than 0, the credentials are valid
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions (e.g., logging the exception)
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public async Task<bool> RegisterUserAsync(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();

                // Optional: check if username already exists
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@Username", username);
                    int existing = (int)await checkCmd.ExecuteScalarAsync();
                    if (existing > 0)
                        return false; // Username already exists
                }

                // Insert new user
                string insertQuery = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@Username", username);
                    insertCmd.Parameters.AddWithValue("@Password", password); // NOTE: hash in production!
                    int rowsAffected = await insertCmd.ExecuteNonQueryAsync();
                    return rowsAffected > 0;
                }
            }
        }
        public async Task PlaceBetAsync(Bet bet)
        {
            const string sql = @"
    INSERT INTO dbo.Bets (MatchId, MatchName, SelectedOutcome, Amount, PlacedAt, UserId)
    VALUES (@m,@n,@o,@a,@p,@u)";
            await using var conn = new SqlConnection(_connectionString);
            await conn.OpenAsync();
            await using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@m", bet.MatchId);
            cmd.Parameters.AddWithValue("@n", bet.MatchName);
            cmd.Parameters.AddWithValue("@o", bet.SelectedOutcome);
            cmd.Parameters.AddWithValue("@a", bet.Amount);
            cmd.Parameters.AddWithValue("@p", bet.PlacedAt);
            cmd.Parameters.AddWithValue("@u", bet.UserId);
            await cmd.ExecuteNonQueryAsync();
        }

        public async Task<List<Bet>> GetUserBetsAsync(Guid userId)
        {
            const string sql = @"
    SELECT BetId,MatchId,MatchName,SelectedOutcome,Amount,PlacedAt,UserId,IsCorrect
      FROM dbo.Bets
     WHERE UserId = @u
  ORDER BY PlacedAt DESC";
            var list = new List<Bet>();
            await using var conn = new SqlConnection(_connectionString);
            await conn.OpenAsync();
            await using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@u", userId);
            await using var rdr = await cmd.ExecuteReaderAsync(CommandBehavior.CloseConnection);
            while (await rdr.ReadAsync())
            {
                list.Add(new Bet
                {
                    BetId = rdr.GetInt32(0),
                    MatchId = rdr.GetInt32(1),
                    MatchName = rdr.GetString(2),
                    SelectedOutcome = rdr.GetString(3),
                    Amount = rdr.GetDecimal(4),
                    PlacedAt = rdr.GetDateTime(5),
                    UserId = rdr.GetGuid(6),
                    IsCorrect = rdr.IsDBNull(7) ? null : rdr.GetBoolean(7)
                });
            }
            return list;
        }

        // You can add methods like RegisterUserAsync(), PlaceBetAsync(), GetMatchListAsync(), etc.
    }

}
