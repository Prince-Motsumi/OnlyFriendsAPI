using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyFriends.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        IPostRepository Posts { get; }
        ICommentRepository Comments { get; }

        Task<int> CompleteAsync();
    }
}
