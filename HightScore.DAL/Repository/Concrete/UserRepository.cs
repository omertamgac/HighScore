using HightScore.DAL.Repository.Abstract;
using HightScore.Entities.Model.Concrete;
using Microsoft.AspNetCore.Identity;

namespace HightScore.BL.Managers.Concrete
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<MetaUser> _userManager;

        public UserRepository(UserManager<MetaUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<MetaUser> GetByIdAsync(string userId)
        {
            return await _userManager.FindByIdAsync(userId);
        }

        public async Task<MetaUser> GetByUsernameAsync(string username)
        {
            return await _userManager.FindByNameAsync(username);
        }

        public async Task<List<MetaUser>> GetAllUsersAsync()
        {
            return await Task.FromResult(_userManager.Users.ToList());
        }

        public async Task<IdentityResult> CreateAsync(MetaUser user, string password)
        {
            return await _userManager.CreateAsync(user, password);
        }

        public async Task<IdentityResult> UpdateAsync(MetaUser user)
        {
            return await _userManager.UpdateAsync(user);
        }

        public async Task<IdentityResult> DeleteAsync(MetaUser user)
        {
            return await _userManager.DeleteAsync(user);
        }



    }
}
