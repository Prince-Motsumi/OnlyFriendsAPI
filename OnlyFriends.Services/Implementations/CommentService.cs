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
    public class CommentService : ICommentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CommentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Comment>> GetCommentsByPostIdAsync(int postId)
        {
            return await _unitOfWork.Comments.GetCommentsByPostIdAsync(postId);
        }

        public async Task CreateCommentAsync(Comment comment)
        {
            await _unitOfWork.Comments.AddAsync(comment);
            await _unitOfWork.CompleteAsync();
        }

        public async Task UpdateCommentAsync(Comment comment)
        {
            await _unitOfWork.Comments.UpdateAsync(comment);
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeleteCommentAsync(int id)
        {
            await _unitOfWork.Comments.DeleteAsync(id);
            await _unitOfWork.CompleteAsync();
        }
    }
}
