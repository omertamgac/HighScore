using Microsoft.AspNetCore.Identity;

namespace HightScore.BL.Managers.Abstract
{
    public interface IUserRepository
    {
        Task<IdentityUser> GetByIdAsync(string userId);
        Task<IdentityUser> GetByUsernameAsync(string username);
        Task<List<IdentityUser>> GetAllUsersAsync();
        Task<IdentityResult> CreateAsync(IdentityUser user, string password);
        Task<IdentityResult> UpdateAsync(IdentityUser user);
        Task<IdentityResult> DeleteAsync(IdentityUser user);
    }
}
