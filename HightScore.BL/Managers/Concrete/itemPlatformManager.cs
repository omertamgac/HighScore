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

        public async Task RemoveByItemIdAsync(int itemId)
        {
            var platforms = await _context.ItemPlatforms
                                           .Where(i => i.itemId == itemId)
                                           .ToListAsync();

            _context.ItemPlatforms.RemoveRange(platforms);
            await _context.SaveChangesAsync();
        }

        public async Task AddAsync(ItemPlatform itemPlatform)
        {
            await _context.ItemPlatforms.AddAsync(itemPlatform);
            await _context.SaveChangesAsync();
        }
    }
}
