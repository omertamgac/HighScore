using HightScore.BL.Managers.Abstract;
using HightScore.Entities.DbContexts;
using HightScore.Entities.Model.Concrete;

namespace HightScore.BL.Managers.Concrete
{
    public class PlatformManager : ManagerBase<Platform>, IPlatformManager
    {
        public PlatformManager(AppDbContext context) : base(context)
        {
        }
    }
}
