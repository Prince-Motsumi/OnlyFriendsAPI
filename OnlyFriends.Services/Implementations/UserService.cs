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
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _unitOfWork.Users.GetByIdAsync(id);
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await _unitOfWork.Users.GetUserByEmailAsync(email);
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _unitOfWork.Users.GetAllAsync();
        }

        public async Task CreateUserAsync(User user)
        {
            await _unitOfWork.Users.AddAsync(user);
            await _unitOfWork.CompleteAsync();
        }

        public async Task UpdateUserAsync(User user)
        {
            _unitOfWork.Users.UpdateAsync(user);
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeleteUserAsync(int id)
        {
            await _unitOfWork.Users.DeleteAsync(id);
            await _unitOfWork.CompleteAsync();
        }
    }
}
