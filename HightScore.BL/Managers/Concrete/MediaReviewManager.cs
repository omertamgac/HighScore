using HightScore.BL.Managers.Abstract;
using HightScore.Entities.DbContexts;
using HightScore.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore;

namespace HightScore.BL.Managers.Concrete
{
    public class MediaReviewManager : ManagerBase<MediaReview>, IMediaReviewManager
    {
        private readonly AppDbContext _context;
        public MediaReviewManager(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MediaReview>> GetReviewsByItemIdAsync(int itemId)
        {
            return await _context.MediaReviews
                                    .Include(m => m.mediaId)
                                    .Where(m => m.ItemId == itemId)
                                    .ToListAsync();
        }
    }
}
