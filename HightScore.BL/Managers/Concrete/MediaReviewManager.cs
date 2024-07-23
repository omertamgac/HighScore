using HightScore.BL.Managers.Abstract;
using HightScore.Entities.DbContexts;
using HightScore.Entities.Model.Concrete;

namespace HightScore.BL.Managers.Concrete
{
    public class MediaReviewManager : ManagerBase<MediaReview>, IMediaReviewManager
    {
        public MediaReviewManager(AppDbContext context) : base(context)
        {
        }
    }
}
