using HightScore.Entities.EntityConfig.Abstract;
using HightScore.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HightScore.Entities.EntityConfig.Concrete
{
    public class ItemsConfig : BaseConfig<Item>
    {
        public override void Configure(EntityTypeBuilder<Item> builder)
        {
            base.Configure(builder);

            builder.Property(g => g.Title).IsRequired().HasMaxLength(80);
            builder.Property(g => g.Description).HasMaxLength(800);
            builder.Property(g => g.RelaseDate).IsRequired();

            // Relationships
            builder.HasMany(g => g.Categroies)
                   .WithMany(c => c.items);


            builder.HasMany(g => g.Platforms)
                   .WithMany(p => p.items);




            builder.HasData(
            new Item
            {
                Id = 1,
                Title = "The Legend of Zelda: Breath of the Wild",
                Description = "An action-adventure game developed and published by Nintendo.",
                RelaseDate = new DateTime(2017, 3, 3),
                UserAverageRating = 9.5m,
                MediaAverageRating = 9.8m,
                UpdatedAt = DateTime.Now
            },
            new Item
            {
                Id = 2,
                Title = "Super Mario Odyssey",
                Description = "A platform game developed and published by Nintendo for the Nintendo Switch.",
                RelaseDate = new DateTime(2017, 10, 27),
                UserAverageRating = 9.3m,
                MediaAverageRating = 9.7m,
                UpdatedAt = DateTime.Now
            },
            new Item
            {
                Id = 3,
                Title = "Red Dead Redemption 2",
                Description = "An action-adventure game developed and published by Rockstar Games.",
                RelaseDate = new DateTime(2018, 10, 26),
                UserAverageRating = 9.6m,
                MediaAverageRating = 9.8m,
                UpdatedAt = DateTime.Now
            },
            new Item
            {
                Id = 4,
                Title = "God of War",
                Description = "An action-adventure game developed by Santa Monica Studio and published by Sony Interactive Entertainment.",
                RelaseDate = new DateTime(2018, 4, 20),
                UserAverageRating = 9.4m,
                MediaAverageRating = 9.6m,
                UpdatedAt = DateTime.Now
            },
            new Item
            {
                Id = 5,
                Title = "The Witcher 3: Wild Hunt",
                Description = "An action role-playing game developed and published by CD Projekt.",
                RelaseDate = new DateTime(2015, 5, 19),
                UserAverageRating = 9.7m,
                MediaAverageRating = 9.9m,
                UpdatedAt = DateTime.Now
            },
            new Item
            {
                Id = 6,
                Title = "Cyberpunk 2077",
                Description = "An action role-playing game developed and published by CD Projekt.",
                RelaseDate = new DateTime(2020, 12, 10),
                UserAverageRating = 8.5m,
                MediaAverageRating = 8.9m,
                UpdatedAt = DateTime.Now
            },
            new Item
            {
                Id = 7,
                Title = "Minecraft",
                Description = "A sandbox video game developed by Mojang.",
                RelaseDate = new DateTime(2011, 11, 18),
                UserAverageRating = 9.2m,
                MediaAverageRating = 9.5m,
                UpdatedAt = DateTime.Now
            },
            new Item
            {
                Id = 8,
                Title = "Fortnite",
                Description = "An online video game developed by Epic Games.",
                RelaseDate = new DateTime(2017, 7, 25),
                UserAverageRating = 8.8m,
                MediaAverageRating = 9.0m,
                UpdatedAt = DateTime.Now
            },
            new Item
            {
                Id = 9,
                Title = "The Elder Scrolls V: Skyrim",
                Description = "An action role-playing game developed by Bethesda Game Studios and published by Bethesda Softworks.",
                RelaseDate = new DateTime(2011, 11, 11),
                UserAverageRating = 9.4m,
                MediaAverageRating = 9.7m,
                UpdatedAt = DateTime.Now
            },
            new Item
            {
                Id = 10,
                Title = "Horizon Zero Dawn",
                Description = "An action role-playing game developed by Guerrilla Games and published by Sony Interactive Entertainment.",
                RelaseDate = new DateTime(2017, 2, 28),
                UserAverageRating = 9.3m,
                MediaAverageRating = 9.5m,
                UpdatedAt = DateTime.Now
            },


                new Item
                {
                    Id = 11,
                    Title = "Final Fantasy XV",
                    Description = "An action role-playing game developed and published by Square Enix.",
                    RelaseDate = new DateTime(2016, 11, 29),
                    UserAverageRating = 8.6m,
                    MediaAverageRating = 8.8m,
                    UpdatedAt = DateTime.Now
                },
            new Item
            {
                Id = 12,
                Title = "Persona 5",
                Description = "A role-playing video game developed by Atlus.",
                RelaseDate = new DateTime(2016, 9, 15),
                UserAverageRating = 9.5m,
                MediaAverageRating = 9.6m,
                UpdatedAt = DateTime.Now
            },
            new Item
            {
                Id = 13,
                Title = "Dark Souls III",
                Description = "An action role-playing game developed by FromSoftware and published by Bandai Namco Entertainment.",
                RelaseDate = new DateTime(2016, 3, 24),
                UserAverageRating = 9.1m,
                MediaAverageRating = 9.3m,
                UpdatedAt = DateTime.Now
            },
            new Item
            {
                Id = 14,
                Title = "Bloodborne",
                Description = "An action role-playing game developed by FromSoftware and published by Sony Computer Entertainment.",
                RelaseDate = new DateTime(2015, 3, 24),
                UserAverageRating = 9.3m,
                MediaAverageRating = 9.4m,
                UpdatedAt = DateTime.Now
            },
            new Item
            {
                Id = 15,
                Title = "Overwatch",
                Description = "A team-based multiplayer first-person shooter developed and published by Blizzard Entertainment.",
                RelaseDate = new DateTime(2016, 5, 24),
                UserAverageRating = 8.9m,
                MediaAverageRating = 9.1m,
                UpdatedAt = DateTime.Now
            },
            new Item
            {
                Id = 16,
                Title = "Sekiro: Shadows Die Twice",
                Description = "An action-adventure game developed by FromSoftware and published by Activision.",
                RelaseDate = new DateTime(2019, 3, 22),
                UserAverageRating = 9.2m,
                MediaAverageRating = 9.5m,
                UpdatedAt = DateTime.Now
            },
            new Item
            {
                Id = 17,
                Title = "Nioh",
                Description = "An action role-playing game developed by Team Ninja and published by Koei Tecmo.",
                RelaseDate = new DateTime(2017, 2, 7),
                UserAverageRating = 8.7m,
                MediaAverageRating = 8.9m,
                UpdatedAt = DateTime.Now
            },
            new Item
            {
                Id = 18,
                Title = "Monster Hunter: World",
                Description = "An action role-playing game developed and published by Capcom.",
                RelaseDate = new DateTime(2018, 1, 26),
                UserAverageRating = 9.0m,
                MediaAverageRating = 9.2m,
                UpdatedAt = DateTime.Now
            },
            new Item
            {
                Id = 19,
                Title = "Resident Evil 2",
                Description = "A survival horror game developed and published by Capcom.",
                RelaseDate = new DateTime(2019, 1, 25),
                UserAverageRating = 9.3m,
                MediaAverageRating = 9.5m,
                UpdatedAt = DateTime.Now
            },
            new Item
            {
                Id = 20,
                Title = "Ghost of Tsushima",
                Description = "An action-adventure game developed by Sucker Punch Productions and published by Sony Interactive Entertainment.",
                RelaseDate = new DateTime(2020, 7, 17),
                UserAverageRating = 9.4m,
                MediaAverageRating = 9.5m,
                UpdatedAt = DateTime.Now
            },
            new Item
            {
                Id = 21,
                Title = "Assassin's Creed Valhalla",
                Description = "An action role-playing video game developed by Ubisoft Montreal and published by Ubisoft.",
                RelaseDate = new DateTime(2020, 11, 10),
                UserAverageRating = 8.8m,
                MediaAverageRating = 9.0m,
                UpdatedAt = DateTime.Now
            },
            new Item
            {
                Id = 22,
                Title = "The Last of Us Part II",
                Description = "An action-adventure game developed by Naughty Dog and published by Sony Interactive Entertainment.",
                RelaseDate = new DateTime(2020, 6, 19),
                UserAverageRating = 9.6m,
                MediaAverageRating = 9.8m,
                UpdatedAt = DateTime.Now
            },
            new Item
            {
                Id = 23,
                Title = "Control",
                Description = "An action-adventure game developed by Remedy Entertainment and published by 505 Games.",
                RelaseDate = new DateTime(2019, 8, 27),
                UserAverageRating = 8.9m,
                MediaAverageRating = 9.1m,
                UpdatedAt = DateTime.Now
            },
            new Item
            {
                Id = 24,
                Title = "Hades",
                Description = "A roguelike action dungeon crawler video game developed and published by Supergiant Games.",
                RelaseDate = new DateTime(2020, 9, 17),
                UserAverageRating = 9.5m,
                MediaAverageRating = 9.7m,
                UpdatedAt = DateTime.Now
            },
            new Item
            {
                Id = 25,
                Title = "Doom Eternal",
                Description = "A first-person shooter game developed by id Software and published by Bethesda Softworks.",
                RelaseDate = new DateTime(2020, 3, 20),
                UserAverageRating = 9.1m,
                MediaAverageRating = 9.3m,
                UpdatedAt = DateTime.Now
            },
            new Item
            {
                Id = 26,
                Title = "Genshin Impact",
                Description = "An action role-playing game developed and published by miHoYo.",
                RelaseDate = new DateTime(2020, 9, 28),
                UserAverageRating = 8.6m,
                MediaAverageRating = 8.8m,
                UpdatedAt = DateTime.Now
            },
            new Item
            {
                Id = 27,
                Title = "Death Stranding",
                Description = "An action game developed by Kojima Productions and published by Sony Interactive Entertainment.",
                RelaseDate = new DateTime(2019, 11, 8),
                UserAverageRating = 8.7m,
                MediaAverageRating = 8.9m,
                UpdatedAt = DateTime.Now
            },
            new Item
            {
                Id = 28,
                Title = "Marvel's Spider-Man",
                Description = "An action-adventure game developed by Insomniac Games and published by Sony Interactive Entertainment.",
                RelaseDate = new DateTime(2018, 9, 7),
                UserAverageRating = 9.2m,
                MediaAverageRating = 9.3m,
                UpdatedAt = DateTime.Now
            },
            new Item
            {
                Id = 29,
                Title = "Half-Life: Alyx",
                Description = "A virtual reality first-person shooter developed and published by Valve.",
                RelaseDate = new DateTime(2020, 3, 23),
                UserAverageRating = 9.4m,
                MediaAverageRating = 9.6m,
                UpdatedAt = DateTime.Now
            },

            new Item
            {
                Id = 30,
                Title = "Mount and Blade II: Bannerlord",
                Description = "An action role-playing game developed and published by TaleWorlds Entertainment. Bannerlord is a prequel to Mount & Blade: Warband, a stand-alone expansion pack for the 2008 game Mount & Blade.",
                RelaseDate = new DateTime(2020, 3, 30),
                UserAverageRating = 8.5m,
                MediaAverageRating = 8.7m,
                UpdatedAt = DateTime.Now
            },


    new Item
    {
        Id = 31,
        Title = "Batman: Arkham Asylum",
        Description = "Explore the depths of Arkham Asylum as Batman, unraveling a sinister plot orchestrated by his arch-nemesis, the Joker.",
        RelaseDate = new DateTime(2009, 8, 25),
        UserAverageRating = 9.0m,
        MediaAverageRating = 9.2m,
        UpdatedAt = DateTime.Now
        // Platforms = new List<Platform> { new Platform { Id = 1, Name = "PlayStation 3" }, new Platform { Id = 2, Name = "Xbox 360" }, new Platform { Id = 3, Name = "Microsoft Windows" } }
    },
    new Item
    {
        Id = 32,
        Title = "Batman: Arkham City",
        Description = "Gotham City is transformed into a sprawling prison, and Batman must navigate its dangerous streets to uncover a new threat.",
        RelaseDate = new DateTime(2011, 10, 18),
        UserAverageRating = 9.1m,
        MediaAverageRating = 9.3m,
        UpdatedAt = DateTime.Now
        // Platforms = new List<Platform> { new Platform { Id = 1, Name = "PlayStation 3" }, new Platform { Id = 2, Name = "Xbox 360" }, new Platform { Id = 3, Name = "Microsoft Windows" } }
    },
    new Item
    {
        Id = 33,
        Title = "Batman: Arkham Knight",
        Description = "The Dark Knight faces the ultimate threat to Gotham City as the Scarecrow unites Batman's foes to destroy him once and for all.",
        RelaseDate = new DateTime(2015, 6, 23),
        UserAverageRating = 8.9m,
        MediaAverageRating = 9.0m,
        UpdatedAt = DateTime.Now
        // Platforms = new List<Platform> { new Platform { Id = 1, PlatformName = "PlayStation 4" }, new Platform { Id = 2, PlatformName = "Xbox One" }, new Platform { Id = 3, PlatformName = "Microsoft Windows" } }
    }




        );
        }





    }
}

