using HightScore.Entities.Model.Concrete;

namespace HightScore.Models
{
    public class GameVM
    {
        public int ItemId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime RelaseDate { get; set; }
        public string? Iframe { get; set; }
        public string? photo { get; set; }
        public decimal UserAverageRating { get; set; }
        public decimal MediaAverageRating { get; set; }
        public List<string>? Categories { get; set; }
        public List<string>? Platforms { get; set; }
        public List<MediaReview> MediaReviews { get; set; }
        public List<UserReview> UserReviews { get; set; }

    }
}
