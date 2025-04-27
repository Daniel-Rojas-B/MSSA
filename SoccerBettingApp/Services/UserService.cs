using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoccerBettingApp.Model;

namespace SoccerBettingApp.Services
{
    public class UserService
    {
        private readonly List<User> _users = new();
        public User CurrentUser { get; set; }

        public bool Login(string username)
        {
            var user = _users.FirstOrDefault(u => u.Username == username);
            if (user == null)
            {
                user = new User { Username = username };
                _users.Add(user);
            }

            CurrentUser = user;
            return true;
        }
        public async Task<bool> LoginAsync(string username)
        {
            await Task.Delay(100); // Simulate network delay
            return !string.IsNullOrWhiteSpace(username); // Simulate a basic check
        }
    }
}
