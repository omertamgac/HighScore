using HightScore.Entities.Model.Concrete;

namespace HightScore.BL.Managers.Abstract
{
    public interface IitemCategoryManager : IManager<ItemCategory>
    {
        Task<List<ItemCategory>> GetByIdAsync(int id);
        Task RemoveByItemIdAsync(int itemId);
        public Task AddAsync(ItemCategory itemCategory);
    }
}
