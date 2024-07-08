using HightScore.Entities.EntityConfig.Abstract;
using HightScore.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HightScore.Entities.EntityConfig.Concrete
{
    public class CategoriesConfig : BaseConfig<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.CategoryName).HasMaxLength(50);
            builder.HasIndex(p => p.CategoryName).IsUnique();
            builder.Property(p => p.CategoryDescription).HasMaxLength(500);

            builder.HasData(

                new Category
                {
                    Id = 1,
                    CategoryName = "Action",
                    CategoryDescription = "Games that emphasize physical challenges, including hand-eye coordination and reaction-time."
                },
                new Category
                {
                    Id = 2,
                    CategoryName = "Adventure",
                    CategoryDescription = "Games focused on story-driven gameplay and exploration of a virtual world."
                },
                new Category
                {
                    Id = 3,
                    CategoryName = "Role-Playing (RPG)",
                    CategoryDescription = "Games where players assume the roles of characters in a fictional setting and take control over many of those characters' actions."
                },
                new Category
                {
                    Id = 4,
                    CategoryName = "Simulation",
                    CategoryDescription = "Games designed to simulate real-world activities and scenarios as closely as possible."
                },
                new Category
                {
                    Id = 5,
                    CategoryName = "Strategy",
                    CategoryDescription = "Games that focus on careful planning and skillful thinking to achieve victory."
                },
                new Category
                {
                    Id = 6,
                    CategoryName = "Sports",
                    CategoryDescription = "Games that simulate the practice of sports, including team sports, track and field, and extreme sports."
                },
                new Category
                {
                    Id = 7,
                    CategoryName = "Puzzle",
                    CategoryDescription = "Games that emphasize solving puzzles as the main gameplay element."
                },
                new Category
                {
                    Id = 8,
                    CategoryName = "Horror",
                    CategoryDescription = "Games designed to scare the player, often through a combination of atmosphere, storytelling, and shock elements."
                },
                new Category
                {
                    Id = 9,
                    CategoryName = "Racing",
                    CategoryDescription = "Games where the primary objective is to race against opponents or the clock."
                },
                new Category
                {
                    Id = 10,
                    CategoryName = "MMO (Massively Multiplayer Online)",
                    CategoryDescription = "Games that support large numbers of players interacting with each other in a persistent virtual world."
                }

                );

        }
    }
}
