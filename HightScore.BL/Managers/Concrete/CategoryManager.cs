using HighScore.BL.Managers.Abstract;
using HighScore.Entities.DbContexts;
using HighScore.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore;

namespace HighScore.BL.Managers.Concrete
{
    public class CategoryManager : ManagerBase<Category>, ICategoryManager
    {
        private readonly AppDbContext _appDbContext;
        public CategoryManager(AppDbContext context) : base(context)
        {
            _appDbContext = context;
        }

        public async Task<List<Category>> GetAllAsync()
        {
            return await _appDbContext.Categories.ToListAsync();
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            return await _appDbContext.Categories.ToListAsync();
        }


    }
}
