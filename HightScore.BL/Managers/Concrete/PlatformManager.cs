using HighScore.BL.Managers.Abstract;
using HighScore.Entities.DbContexts;
using HighScore.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore;

namespace HighScore.BL.Managers.Concrete
{
    public class PlatformManager : ManagerBase<Platform>, IPlatformManager
    {
        private readonly AppDbContext _appDbContext;
        public PlatformManager(AppDbContext context) : base(context)
        {
            _appDbContext = context;
        }

        public Task<List<Platform>> GetAllAsync()
        {
            return _appDbContext.Platforms.ToListAsync();
        }
    }
}
