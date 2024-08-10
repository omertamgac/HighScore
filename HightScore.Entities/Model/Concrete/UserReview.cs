using HightScore.Entities.Model.Abstract;

namespace HightScore.Entities.Model.Concrete
{
    public class UserReview : BaseEntity
    {

        public int ItemId { get; set; }
        public Item Item { get; set; }

        public string UserId { get; set; }
        public MetaUser user { get; set; }

        public int UserRating { get; set; }
        public string Comment { get; set; }
    }
}
