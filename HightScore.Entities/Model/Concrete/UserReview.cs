using HightScore.Entities.Model.Abstract;

namespace HightScore.Entities.Model.Concrete
{
    public class UserReview : BaseEntity
    {
        public int ItemId { get; set; }
        public Item itemId { get; set; }
        public int UserId { get; set; }
        public User userId { get; set; }
        public int UserRating { get; set; }
        public string Comment { get; set; }
    }
}
