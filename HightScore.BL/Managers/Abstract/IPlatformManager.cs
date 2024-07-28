using HightScore.Entities.Model.Concrete;

namespace HightScore.BL.Managers.Abstract
{
    public interface IPlatformManager : IManager<Platform>
    {

        public Task<List<Platform>> GetAllAsync();
    }
}
