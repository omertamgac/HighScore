using Microsoft.AspNetCore.Identity;

namespace HightScore.Entities.Model.Concrete
{
    public class MetaUser : IdentityUser
    {
        public ICollection<UserReview> UserReviews { get; set; } = new List<UserReview>();

    }
}
