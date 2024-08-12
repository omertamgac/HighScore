using HightScore.Entities.Model.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace HightScore.Entities.DbContexts
{
    public class AppDbContext : IdentityDbContext<MetaUser, Role, string>
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<UserReview> UserReviews { get; set; }
        public DbSet<ItemCategory> ItemCategories { get; set; }
        public DbSet<ItemPlatform> ItemPlatforms { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public AppDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(@"server=localhost;port=3306;user=root;password=asd123;database=HightScoreDb;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<MetaUser>()
                .HasDiscriminator<string>("Discriminator")
                .HasValue<MetaUser>("MetaUser");

            var hasher = new PasswordHasher<MetaUser>();

            // Admin kullanıcı
            var adminUser = new MetaUser
            {
                Id = "0",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@example.com",
                NormalizedEmail = "ADMIN@EXAMPLE.COM",
                EmailConfirmed = true,
                PhoneNumber = "555-666-777",
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            adminUser.PasswordHash = hasher.HashPassword(adminUser, "asd123.");

            modelBuilder.Entity<MetaUser>().HasData(adminUser);

            var users = new List<MetaUser>();
            for (int i = 1; i <= 20; i++)
            {
                var user = new MetaUser
                {
                    Id = $"{i}",
                    UserName = $"user{i}",
                    NormalizedUserName = $"USER{i}",
                    Email = $"user{i}@example.com",
                    NormalizedEmail = $"USER{i}@EXAMPLE.COM",
                    EmailConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString("D")
                };
                user.PasswordHash = hasher.HashPassword(user, "asd123.");
                users.Add(user);
            }

            modelBuilder.Entity<MetaUser>().HasData(users);


            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "1",
                    UserId = "0"
                }
            );

            foreach (var user in users)
            {
                modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                    new IdentityUserRole<string>
                    {
                        RoleId = "2",
                        UserId = user.Id
                    }
                );
            }
        }
    }
}
