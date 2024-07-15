using Microsoft.AspNetCore.Identity;

namespace HightScore.BL.Managers.Abstract
{
    public interface IUserManager
    {
        Task<IdentityUser> GetUserByIdAsync(string userId);
        Task<IdentityUser> GetUserByUsernameAsync(string username);
        Task<List<IdentityUser>> GetAllUsersAsync();
        Task<IdentityResult> CreateUserAsync(string username, string email, string password);
        Task<IdentityResult> UpdateUserAsync(IdentityUser user);
        Task<IdentityResult> DeleteUserAsync(string userId);
    }
}
