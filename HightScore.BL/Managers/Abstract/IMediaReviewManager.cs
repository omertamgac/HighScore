using HightScore.Entities.Model.Concrete;

namespace HightScore.BL.Managers.Abstract
{
    public interface IMediaReviewManager : IManager<MediaReview>
    {
        public Task<IEnumerable<MediaReview>> GetReviewsByItemIdAsync(int itemId);
    }
}
