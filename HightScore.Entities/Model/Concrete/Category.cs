using HightScore.Entities.Model.Abstract;

namespace HightScore.Entities.Model.Concrete
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public ICollection<ItemCategory> ItemCategories { get; set; }
    }
}
