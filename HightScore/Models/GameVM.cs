using HightScore.Entities.Model.Concrete;

namespace HightScore.Models
{
    public class GameVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime RelaseDate { get; set; }
        public string? Iframe { get; set; }
        public string? photo { get; set; }
        public decimal UserAverageRating { get; set; }
        public decimal MediaAverageRating { get; set; }
        public List<ItemCategory>? ItemCategories { get; set; }
        public List<ItemPlatform>? ItemPlatforms { get; set; }

    }
}
