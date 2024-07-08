using HightScore.Entities.Model.Abstract;

namespace HightScore.Entities.Model.Concrete
{
    public class Platform : BaseEntity
    {
        public string PlatformName { get; set; }
        public byte? Logo { get; set; }
        public ICollection<Item> items { get; set; }
    }
}