using HighScore.Entities.Model.Concrete;

namespace HighScore.BL.Managers.Abstract
{
    public interface IitemCategoryManager : IManager<ItemCategory>
    {
        Task<List<ItemCategory>> GetByIdAsync(int id);
        Task RemoveByItemIdAsync(int itemId);
        public Task AddAsync(ItemCategory itemCategory);
    }
}
