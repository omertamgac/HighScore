using HightScore.BL.Managers.Abstract;
using Microsoft.AspNetCore.Identity;

namespace HightScore.BL.Managers.Concrete
{
    public class UserManager : IUserManager
    {
        private readonly IUserRepository _userRepository;

        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IdentityUser> GetUserByIdAsync(string userId)
        {
            return await _userRepository.GetByIdAsync(userId);
        }

        public async Task<IdentityUser> GetUserByUsernameAsync(string username)
        {
            return await _userRepository.GetByUsernameAsync(username);
        }

        public async Task<List<IdentityUser>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllUsersAsync();
        }

        public async Task<IdentityResult> CreateUserAsync(string username, string email, string password)
        {
            var user = new IdentityUser { UserName = username, Email = email };
            return await _userRepository.CreateAsync(user, password);
        }

        public async Task<IdentityResult> UpdateUserAsync(IdentityUser user)
        {
            return await _userRepository.UpdateAsync(user);
        }

        public async Task<IdentityResult> DeleteUserAsync(string userId)
        {
            var user = await _userRepository.GetByIdAsync(userId);
            if (user == null)
            {
                // Handle user not found scenario
                return IdentityResult.Failed();
            }

            return await _userRepository.DeleteAsync(user);
        }
    }
}
