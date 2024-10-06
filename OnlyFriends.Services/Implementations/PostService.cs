using OnlyFriends.Domain.Entities;
using OnlyFriends.Domain.Interfaces;
using OnlyFriends.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyFriends.Services.Implementations
{
    public class PostService : IPostService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PostService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Post>> GetAllPostsAsync()
        {
            return await _unitOfWork.Posts.GetAllAsync();
        }

        public async Task<Post> GetPostByIdAsync(int id)
        {
            return await _unitOfWork.Posts.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Post>> GetPostsByUserIdAsync(int userId)
        {
            return await _unitOfWork.Posts.GetPostsByUserIdAsync(userId);
        }

        public async Task CreatePostAsync(Post post)
        {
            await _unitOfWork.Posts.AddAsync(post);
            await _unitOfWork.CompleteAsync();
        }

        public async Task UpdatePostAsync(Post post)
        {
            await _unitOfWork.Posts.UpdateAsync(post);
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeletePostAsync(int id)
        {
            await _unitOfWork.Posts.DeleteAsync(id);
            await _unitOfWork.CompleteAsync();
        }
    }
}
