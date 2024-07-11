using HightScore.Entities.Model.Abstract;

namespace HightScore.Entities.Model.Concrete
{
    public class ItemCategory : BaseEntity
    {
        public int itemId { get; set; }
        public Item items { get; set; }

        public int categoryId { get; set; }
        public Category category { get; set; }
    }
}
