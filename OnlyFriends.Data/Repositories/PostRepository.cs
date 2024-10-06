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
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        public PostRepository(OnlyFriendsDbContext context) : base(context) { }

        public async Task<IEnumerable<Post>> GetPostsByUserIdAsync(int userId)
        {
            return await _context.Posts.Where(p => p.UserId == userId).ToListAsync();
        }

        public async Task<IEnumerable<Post>> GetRecentPostsAsync(int numberOfPosts)
        {
            return await _context.Posts
                .OrderByDescending(p => p.DatePosted)
                .Take(numberOfPosts)
                .ToListAsync();
        }
    }
}
