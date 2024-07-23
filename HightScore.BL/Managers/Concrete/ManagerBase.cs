using HightScore.BL.Managers.Abstract;
using HightScore.DAL.Repository.Concrete;
using HightScore.Entities.DbContexts;
using HightScore.Entities.Model.Abstract;

namespace HightScore.BL.Managers.Concrete
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
