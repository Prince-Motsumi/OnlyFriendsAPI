using OnlyFriends.Data.Repositories;
using OnlyFriends.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyFriends.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OnlyFriendsDbContext _context;

        public UnitOfWork(OnlyFriendsDbContext context)
        {
            _context = context;
            Users = new UserRepository(context);
            Posts = new PostRepository(context);
            Comments = new CommentRepository(context);
        }

        public IUserRepository Users { get; private set; }
        public IPostRepository Posts { get; private set; }
        public ICommentRepository Comments { get; private set; }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
