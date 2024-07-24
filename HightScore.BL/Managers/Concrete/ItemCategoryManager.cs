using HightScore.BL.Managers.Abstract;
using HightScore.Entities.DbContexts;
using HightScore.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore;

namespace HightScore.BL.Managers.Concrete
{
    public class ItemCategoryManager : ManagerBase<ItemCategory>, IitemCategoryManager
    {
        private readonly AppDbContext _context;
        public ItemCategoryManager(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<ItemCategory>> GetByIdAsync(int id)
        {
            return await _context.ItemCategories
                                 .Include(ic => ic.category)
                                 .Where(ic => ic.itemId == id)
                                 .ToListAsync();
        }

    }
}
