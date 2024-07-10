using HightScore.Entities.Model.Abstract;

namespace HightScore.Entities.Model.Concrete
{
    public class AdminAction : BaseEntity
    {
        public int AdminId { get; set; }
        public User Admin { get; set; }

        public string ActionType { get; set; }
        public string Description { get; set; }
    }

}
