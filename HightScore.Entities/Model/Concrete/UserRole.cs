using HightScore.Entities.Model.Abstract;

namespace HightScore.Entities.Model.Concrete
{
    public class UserRole : BaseEntity
    {
        public int UserId { get; set; }
        public User user { get; set; }


        public int RoleId { get; set; }
        public Role role { get; set; }
    }
}
