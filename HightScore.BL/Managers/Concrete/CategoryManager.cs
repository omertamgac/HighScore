using HightScore.BL.Managers.Abstract;
using HightScore.Entities.DbContexts;
using HightScore.Entities.Model.Concrete;

namespace HightScore.BL.Managers.Concrete
{
    public class CategoryManager : ManagerBase<Category>, ICategoryManager
    {
        public CategoryManager(AppDbContext context) : base(context)
        {
        }
    }
}
