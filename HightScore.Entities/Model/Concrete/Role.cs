using HightScore.Entities.Model.Abstract;

namespace HightScore.Entities.Model.Concrete
{
    public class Role : BaseEntity
    {
        public string Roles { get; set; }
        public ICollection<User> users { get; set; }
    }
}