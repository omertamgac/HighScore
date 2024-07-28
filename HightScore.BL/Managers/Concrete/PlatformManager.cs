using HightScore.BL.Managers.Abstract;
using HightScore.Entities.DbContexts;
using HightScore.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore;

namespace HightScore.BL.Managers.Concrete
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
