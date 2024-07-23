using HightScore.Entities.Model.Abstract;

namespace HightScore.Entities.Model.Concrete
{
    public class Platform : BaseEntity
    {
        public string PlatformName { get; set; }
        public string? Logo { get; set; }
        public ICollection<ItemPlatform> ItemPlatforms { get; set; }
    }
}