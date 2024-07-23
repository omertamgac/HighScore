using HightScore.BL.Managers.Abstract;
using HightScore.Entities.DbContexts;
using HightScore.Entities.Model.Concrete;

namespace HightScore.BL.Managers.Concrete
{
    public class MediaManager : ManagerBase<Media>, IMediaManager
    {
        public MediaManager(AppDbContext context) : base(context)
        {
        }
    }
}
