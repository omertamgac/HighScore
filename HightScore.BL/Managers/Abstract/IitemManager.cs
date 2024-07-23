using HightScore.Entities.Model.Concrete;

namespace HightScore.BL.Managers.Abstract
{
    public interface IitemManager : IManager<Item>
    {
        public Task<IEnumerable<Item>> GetAllGamesAsync();
        Task<Item> GetGameByIdAsync(int id);
    }
}
