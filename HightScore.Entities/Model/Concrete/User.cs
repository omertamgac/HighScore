using HightScore.Entities.Model.Abstract;

namespace HightScore.Entities.Model.Concrete
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? Phone { get; set; }
        public string NickName { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }

        public ICollection<UserReview> userReviews { get; set; }

    }
}