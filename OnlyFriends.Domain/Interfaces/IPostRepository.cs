using OnlyFriends.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyFriends.Domain.Interfaces
{
    public interface IPostRepository : IRepository<Post>
    {
        Task<IEnumerable<Post>> GetPostsByUserIdAsync(int userId);
        Task<IEnumerable<Post>> GetRecentPostsAsync(int numberOfPosts);
    }
}
