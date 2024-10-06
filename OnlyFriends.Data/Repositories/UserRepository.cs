using Microsoft.EntityFrameworkCore;
using OnlyFriends.Domain.Entities;
using OnlyFriends.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyFriends.Data.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(OnlyFriendsDbContext context) : base(context) { }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<IEnumerable<User>> GetUsersByRoleAsync(string role)
        {
            return await _context.Users.Where(u => u.Bio == role).ToListAsync(); // Example role
        }
    }
}
