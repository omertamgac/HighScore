using HightScore.BL.Managers.Abstract;
using HightScore.DAL.Repository.Abstract;
using HightScore.Entities.Model.Concrete;

namespace HightScore.BL.Managers.Concrete
{
    public class UserReviewManager : ManagerBase<UserReview>, IUserReviewManager
    {
        private readonly IRepository<UserReview> deneme;


        public override int Insert(UserReview UserComment)
        {
            if (UserComment.Comment.Length > 800)
            {
                throw new Exception("Yorum 800 karakterden büyük olamaz");
            }
            else if (UserComment.Comment.Length <= 0)
            {
                throw new Exception("Yorum boş olamaz");
            }
            return base.Insert(UserComment);
        }


    }
}
