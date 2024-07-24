using HightScore.BL.Managers.Abstract;
using HightScore.Entities.DbContexts;
using HightScore.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore;

namespace HightScore.BL.Managers.Concrete
{
    public class itemPlatformManager : ManagerBase<ItemPlatform>, IitemPlatformManager
    {
        private readonly AppDbContext _context;
        public itemPlatformManager(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<ItemPlatform>> GetByIdAsync(int id)
        {
            return await _context.ItemPlatforms
                                .Include(i => i.platform)
                                .Where(i => i.itemId == id)
                                .ToListAsync();
        }
    }
}
