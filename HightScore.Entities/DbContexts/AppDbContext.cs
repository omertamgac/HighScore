using HightScore.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace HightScore.Entities.DbContexts
{
    public class AppDbContext : DbContext
    {

        public DbSet<AdminAction> AdminActions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<MediaReview> MediaReviews { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserReview> UserReviews { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<ItemCategory> ItemCategories { get; set; }
        public DbSet<ItemPlatform> ItemPlatforms { get; set; }
        public DbSet<Role> Roles { get; set; }


        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        //Bu metod sayesinde migration ve database'e update işlemi yapıyoruz.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseMySQL(@"server=localhost;port=3306;user=root;password=asd123;database=HightScoreDb;");
        }

        //Seed dataların database'e işlenmesini sağlayan metod
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }







    }
}
