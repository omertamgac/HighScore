using HighScore.Entities.Model.Concrete;

namespace HighScore.BL.Managers.Abstract
{
    public interface IitemPlatformManager : IManager<ItemPlatform>
    {
        Task<List<ItemPlatform>> GetByIdAsync(int id);
        Task RemoveByItemIdAsync(int itemId);
        public Task AddAsync(ItemPlatform itemPlatform);
    }
}
