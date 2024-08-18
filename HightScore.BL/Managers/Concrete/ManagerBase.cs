using HighScore.BL.Managers.Abstract;
using HighScore.DAL.Repository.Concrete;
using HighScore.Entities.DbContexts;
using HighScore.Entities.Model.Abstract;

namespace HighScore.BL.Managers.Concrete
{
    public class ManagerBase<T> : Repository<T>, IManager<T> where T : BaseEntity
    {
        private AppDbContext context;

        public ManagerBase(AppDbContext context)
        {
            this.context = context;
        }
    }
}
