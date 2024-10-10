using OnlyFriends.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyFriends.Domain.Interfaces
{
    public interface ICommentRepository : IRepository<Comment>
    {
        Task<IEnumerable<Comment>> GetCommentsByPostIdAsync(int postId);
        Task<IEnumerable<Comment>> GetCommentsByUserIdAsync(string userId);
    }
}
