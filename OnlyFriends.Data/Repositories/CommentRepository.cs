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
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        public CommentRepository(OnlyFriendsDbContext context) : base(context) { }

        public async Task<IEnumerable<Comment>> GetCommentsByPostIdAsync(int postId)
        {
            return await _context.Comments.Where(c => c.PostId == postId).ToListAsync();
        }

        public async Task<IEnumerable<Comment>> GetCommentsByUserIdAsync(string userId)
        {
            return await _context.Comments.Where(c => c.UserId == userId).ToListAsync();
        }
    }
}
