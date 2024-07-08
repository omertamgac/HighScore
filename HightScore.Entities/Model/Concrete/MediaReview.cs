using HightScore.Entities.Model.Abstract;

namespace HightScore.Entities.Model.Concrete
{
    public class MediaReview : BaseEntity
    {
        public int ItemId { get; set; }
        public Item ItemsId { get; set; }

        public int MediaId { get; set; }
        public Media mediaId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }

    }
}
