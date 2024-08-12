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
            var game = await _context.Items
                .Include(g => g.ItemCategories)
                .Include(g => g.ItemPlatforms)
                .FirstOrDefaultAsync(g => g.Id == id);

            game.ItemCategories ??= new List<ItemCategory>();
            game.ItemPlatforms ??= new List<ItemPlatform>();

            return game;
        }


        public int Update(Item item)
        {
            _context.Items.Update(item);
            return _context.SaveChanges();
        }

        public async Task<int> UpdateAsync(Item item)
        {
            var entity = _context.Items.FirstOrDefault(x => x.Id == item.Id);
            if (entity != null)
            {
                entity.Id = item.Id;
                entity.Iframe = item.Iframe;
                entity.Title = item.Title;
                entity.photo = item.photo;
                entity.ItemCategories = item.ItemCategories;
                entity.ItemPlatforms = item.ItemPlatforms;
                entity.UpdatedAt = item.UpdatedAt;
                entity.Description = item.Description;
                entity.RelaseDate = item.RelaseDate;

            }

            _context.Items.Update(item);
            return await _context.SaveChangesAsync();
        }



        public async Task<double> GetAverageRatingAsync(int itemId)
        {
            var reviews = await _context.UserReviews
                .Where(r => r.ItemId == itemId)
                .ToListAsync();

            if (reviews.Count == 0)
            {
                return 0;
            }

            double averageRating = Math.Round(reviews.Average(r => r.UserRating), 1);

            return averageRating;
        }

        public IQueryable<Item> GetAllGamesQuery()
        {
            return _context.Items.AsQueryable();
        }
    }

}

