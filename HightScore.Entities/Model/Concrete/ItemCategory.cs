using HighScore.Entities.Model.Abstract;

namespace HighScore.Entities.Model.Concrete
{
    public class ItemCategory : BaseEntity
    {
        public int itemId { get; set; }
        public Item items { get; set; }

        public int categoryId { get; set; }
        public Category category { get; set; }
    }
}
