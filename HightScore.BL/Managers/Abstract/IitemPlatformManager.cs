using HightScore.Entities.Model.Concrete;

namespace HightScore.BL.Managers.Abstract
{
    public interface IitemPlatformManager : IManager<ItemPlatform>
    {
        Task<List<ItemPlatform>> GetByIdAsync(int id);

    }
}
