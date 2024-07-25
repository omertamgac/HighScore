using HightScore.BL.Managers.Abstract;
using HightScore.Entities.DbContexts;
using HightScore.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore;

namespace HightScore.BL.Managers.Concrete
{
    public class ItemManager : ManagerBase<Item>, IitemManager
    {

        private readonly AppDbContext _context;

        public ItemManager(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task DeleteAsync(Item item)
        {
            _context.Items.Remove(item);
            await _context.SaveChangesAsync();
        }

        public async Task<Item> FindByIdAsync(int id)
        {
            return await _context.Items.FindAsync(id);
        }

        public async Task<IEnumerable<Item>> GetAllGamesAsync()
        {
            return await _context.Items.ToListAsync();
        }

        public async Task<Item> GetGameByIdAsync(int id)
        {
            return await _context.Items
                .Include(g => g.ItemCategories)
                .Include(g => g.ItemPlatforms)
                .FirstOrDefaultAsync(g => g.Id == id);
        }
    }

}

