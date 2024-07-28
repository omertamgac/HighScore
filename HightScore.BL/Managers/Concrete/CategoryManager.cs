using HightScore.BL.Managers.Abstract;
using HightScore.Entities.DbContexts;
using HightScore.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore;

namespace HightScore.BL.Managers.Concrete
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
