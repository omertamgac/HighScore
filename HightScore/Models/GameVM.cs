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
        public double? AverageRating { get; set; }
        public List<string>? Categories { get; set; }
        public List<string>? Platforms { get; set; }
        public List<UserReview>? UserReviews { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }

    }
}
