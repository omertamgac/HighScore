using HighScore.Entities.Model.Concrete;

namespace HighScore.BL.Managers.Abstract
{
    public interface ICategoryManager : IManager<Category>
    {
        public Task<List<Category>> GetAllAsync();
        Task<IEnumerable<Category>> GetAllCategoriesAsync();
    }
}
