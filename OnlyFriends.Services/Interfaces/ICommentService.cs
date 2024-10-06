using OnlyFriends.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyFriends.Services.Interfaces
{
    public interface ICommentService
    {
        Task<IEnumerable<Comment>> GetCommentsByPostIdAsync(int postId);
        Task CreateCommentAsync(Comment comment);
        Task UpdateCommentAsync(Comment comment);
        Task DeleteCommentAsync(int id);
    }
}
