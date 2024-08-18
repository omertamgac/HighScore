using HighScore.DAL.Repository.Abstract;
using HighScore.Entities.Model.Abstract;

namespace HighScore.BL.Managers.Abstract
{
    public interface IManager<T> : IRepository<T> where T : BaseEntity
    {

    }
}
