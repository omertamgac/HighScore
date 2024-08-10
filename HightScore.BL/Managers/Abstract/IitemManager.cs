using HightScore.Entities.Model.Concrete;

namespace HightScore.BL.Managers.Abstract
{
    public interface IitemManager : IManager<Item>
    {
        public Task<IEnumerable<Item>> GetAllGamesAsync();
        Task<Item> GetGameByIdAsync(int id);
        Task<Item> FindByIdAsync(int id);
        Task DeleteAsync(Item item);
        public int Update(Item item);
        public Task<int> UpdateAsync(Item item);
        public Task<double> GetAverageRatingAsync(int itemId);

    }
}
