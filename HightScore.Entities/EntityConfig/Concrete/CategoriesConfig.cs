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
    new Category { Id = 1, CategoryName = "Action", CategoryDescription = "Games that emphasize physical challenges, including hand-eye coordination and reaction-time." },
    new Category { Id = 2, CategoryName = "Adventure", CategoryDescription = "Narrative-focused games that often involve exploration and puzzle-solving." },
    new Category { Id = 3, CategoryName = "Role-Playing", CategoryDescription = "Games that allow players to assume the roles of characters in a fictional setting." },
    new Category { Id = 4, CategoryName = "Strategy", CategoryDescription = "Games that require careful planning and decision-making." },
    new Category { Id = 5, CategoryName = "Simulation", CategoryDescription = "Games that replicate real-world activities or systems." },
    new Category { Id = 6, CategoryName = "Sports", CategoryDescription = "Games based on real or fictional sports." },
    new Category { Id = 7, CategoryName = "Racing", CategoryDescription = "Games centered around competitive or non-competitive racing." },
    new Category { Id = 8, CategoryName = "Fighting", CategoryDescription = "Games focused on hand-to-hand combat between characters." },
    new Category { Id = 9, CategoryName = "Horror", CategoryDescription = "Games designed to scare or unsettle players." },
    new Category { Id = 10, CategoryName = "Puzzle", CategoryDescription = "Games that challenge problem-solving skills." },
    new Category { Id = 11, CategoryName = "Platformer", CategoryDescription = "Games characterized by jumping between platforms and overcoming obstacles." },
    new Category { Id = 12, CategoryName = "Shooter", CategoryDescription = "Games focused on shooting enemies or targets." },
    new Category { Id = 13, CategoryName = "Survival", CategoryDescription = "Games where the player must survive in a hostile environment." },
    new Category { Id = 14, CategoryName = "Open World", CategoryDescription = "Games that allow players to roam freely through a virtual world." },
    new Category { Id = 15, CategoryName = "MMORPG", CategoryDescription = "Massively multiplayer online role-playing games." },
    new Category { Id = 16, CategoryName = "Co-op", CategoryDescription = "Games designed for cooperative multiplayer gameplay." },
    new Category { Id = 17, CategoryName = "Turn-Based", CategoryDescription = "Games where players take turns to make decisions or moves." },
    new Category { Id = 18, CategoryName = "Real-Time Strategy", CategoryDescription = "Strategy games where players make decisions in real-time." },
    new Category { Id = 19, CategoryName = "Tactical", CategoryDescription = "Games that emphasize careful planning and tactical decision-making." },
    new Category { Id = 20, CategoryName = "Educational", CategoryDescription = "Games designed to teach players about a specific subject or skill." },
    new Category { Id = 21, CategoryName = "Music", CategoryDescription = "Games focused on creating or performing music." },
    new Category { Id = 22, CategoryName = "Casual", CategoryDescription = "Games that are easy to learn and play." },
    new Category { Id = 23, CategoryName = "Artistic", CategoryDescription = "Games that prioritize artistic expression or creativity." },
    new Category { Id = 24, CategoryName = "Historical", CategoryDescription = "Games set in or inspired by historical events or periods." },
    new Category { Id = 25, CategoryName = "Fantasy", CategoryDescription = "Games set in fantastical or mythical worlds." },
    new Category { Id = 26, CategoryName = "Sci-Fi", CategoryDescription = "Games set in futuristic or science fiction settings." },
    new Category { Id = 27, CategoryName = "Cyberpunk", CategoryDescription = "Games that feature a dystopian future with advanced technology." },
    new Category { Id = 28, CategoryName = "Stealth", CategoryDescription = "Games that require players to avoid detection and complete objectives stealthily." },
    new Category { Id = 29, CategoryName = "Visual Novel", CategoryDescription = "Games characterized by narrative-driven storytelling and minimal gameplay." },
    new Category { Id = 30, CategoryName = "Dating Sim", CategoryDescription = "Games that focus on romantic relationships and dating." },
    new Category { Id = 31, CategoryName = "Virtual Reality", CategoryDescription = "Games designed to be experienced in virtual reality environments." },
    new Category { Id = 32, CategoryName = "Augmented Reality", CategoryDescription = "Games that blend virtual elements with real-world environments." },
    new Category { Id = 33, CategoryName = "Dungeon Crawler", CategoryDescription = "Games focused on exploring dungeons and defeating enemies." },
    new Category { Id = 34, CategoryName = "Tower Defense", CategoryDescription = "Games where players defend against waves of enemies using strategic placements." },
    new Category { Id = 35, CategoryName = "Idle", CategoryDescription = "Games where progress is made even when the player is not actively playing." },
    new Category { Id = 36, CategoryName = "Incremental", CategoryDescription = "Games where players gradually increase resources or abilities over time." },
    new Category { Id = 37, CategoryName = "Battle Royale", CategoryDescription = "Games where players compete to be the last one standing in a shrinking play area." },
    new Category { Id = 38, CategoryName = "Party", CategoryDescription = "Games designed for multiplayer parties or gatherings." },
    new Category { Id = 39, CategoryName = "Management", CategoryDescription = "Games that involve managing resources, businesses, or scenarios." },
    new Category { Id = 40, CategoryName = "Comedy", CategoryDescription = "Games focused on humor and comedic situations." },
    new Category { Id = 41, CategoryName = "Mystery", CategoryDescription = "Games that involve solving puzzles or uncovering secrets." },
    new Category { Id = 42, CategoryName = "Exploration", CategoryDescription = "Games focused on exploring vast environments or uncovering mysteries." },
    new Category { Id = 43, CategoryName = "Artificial Intelligence", CategoryDescription = "Games that explore the capabilities and implications of artificial intelligence." },
    new Category { Id = 44, CategoryName = "Environmental", CategoryDescription = "Games that emphasize environmental themes or challenges." },
    new Category { Id = 45, CategoryName = "Crafting", CategoryDescription = "Games that involve creating or crafting items or structures." },
    new Category { Id = 46, CategoryName = "Social", CategoryDescription = "Games designed for social interaction and communication." },
    new Category { Id = 47, CategoryName = "Historical Fiction", CategoryDescription = "Games that blend historical events with fictional elements." },
    new Category { Id = 48, CategoryName = "Psychological", CategoryDescription = "Games that explore psychological themes or challenges." },
    new Category { Id = 49, CategoryName = "Crime", CategoryDescription = "Games focused on criminal activities or investigations." },
    new Category { Id = 50, CategoryName = "Space", CategoryDescription = "Games set in outer space or involving space exploration." }
);


        }
    }
}
