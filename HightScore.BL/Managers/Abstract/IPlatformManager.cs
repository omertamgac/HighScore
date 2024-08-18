using HighScore.Entities.Model.Concrete;

namespace HighScore.BL.Managers.Abstract
{
    public interface IPlatformManager : IManager<Platform>
    {

        public Task<List<Platform>> GetAllAsync();
    }
}
