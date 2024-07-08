using HightScore.DAL.Repository.Abstract;
using HightScore.Entities.Model.Abstract;

namespace HightScore.BL.Managers.Abstract
{
    public interface IManager<T> : IRepository<T> where T : BaseEntity
    {

    }
}
