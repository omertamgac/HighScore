using HighScore.Entities.Model.Concrete;
using Microsoft.AspNetCore.Identity;

namespace HighScore.DAL.Repository.Abstract
{
    public interface IUserRepository
    {
        Task<MetaUser> GetByIdAsync(string userId);
        Task<MetaUser> GetByUsernameAsync(string username);
        Task<List<MetaUser>> GetAllUsersAsync();
        Task<IdentityResult> CreateAsync(MetaUser user, string password);
        Task<IdentityResult> UpdateAsync(MetaUser user);
        Task<IdentityResult> DeleteAsync(MetaUser user);
    }
}
