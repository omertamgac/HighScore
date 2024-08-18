using HighScore.Entities.Model.Abstract;

namespace HighScore.Entities.Model.Concrete
{
    public class ItemPlatform : BaseEntity
    {
        public int itemId { get; set; }
        public Item Item { get; set; }

        public int platformId { get; set; }
        public Platform platform { get; set; }
    }
}
