using HightScore.BL.Managers.Abstract;
using HightScore.Entities.DbContexts;
using HightScore.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore;

namespace HightScore.BL.Managers.Concrete
{
    public class UserReviewManager : ManagerBase<UserReview>, IUserReviewManager
    {
        private readonly AppDbContext _context;
        public UserReviewManager(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<UserReview>> GetReviewsByItemIdAsync(int itemId)
        {
            return await _context.UserReviews
                         .Include(ur => ur.user)
                         .Where(ur => ur.ItemId == itemId)
                         .ToListAsync();
        }

        public async Task<bool> CreateComment(int itemId, string userId, int userRating, string comment)
        {
            // Kullanıcının daha önce bu item için yorum yapıp yapmadığını kontrol et
            var existingReview = await _context.UserReviews
                                               .FirstOrDefaultAsync(ur => ur.ItemId == itemId && ur.UserId == userId.ToString());

            if (existingReview != null)
            {
                // Kullanıcı daha önce yorum yapmışsa yeni yorum ekleme
                return false;
            }

            // Yeni yorum oluştur ve ekle
            var userReview = new UserReview
            {
                ItemId = itemId,
                UserId = userId.ToString(),
                UserRating = userRating,
                Comment = comment
            };

            await _context.UserReviews.AddAsync(userReview);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
