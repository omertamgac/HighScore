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
            //  builder.Property(g => g.ItemCategories).IsRequired();






            builder.HasData(
            new Item
            {
                Id = 1,
                Title = "The Legend of Zelda: Breath of the Wild",
                Description = "An action-adventure game developed and published by Nintendo.",
                RelaseDate = new DateTime(2017, 3, 3),
                UpdatedAt = DateTime.Now,
                photo = "1.jpg"

            },
            new Item
            {
                Id = 2,
                Title = "Super Mario Odyssey",
                Description = "A platform game developed and published by Nintendo for the Nintendo Switch.",
                RelaseDate = new DateTime(2017, 10, 27),

                UpdatedAt = DateTime.Now,
                photo = "2.webp"
            },
            new Item
            {
                Id = 3,
                Title = "Red Dead Redemption 2",
                Description = "An action-adventure game developed and published by Rockstar Games.",
                RelaseDate = new DateTime(2018, 10, 26),
                UpdatedAt = DateTime.Now,
                photo = "3.jpg"

            },
            new Item
            {
                Id = 4,
                Title = "God of War",
                Description = "An action-adventure game developed by Santa Monica Studio and published by Sony Interactive Entertainment.",
                RelaseDate = new DateTime(2018, 4, 20),
                UpdatedAt = DateTime.Now,
                photo = "4.jpg"

            },
            new Item
            {
                Id = 5,
                Title = "The Witcher 3: Wild Hunt",
                Description = "An action role-playing game developed and published by CD Projekt.",
                RelaseDate = new DateTime(2015, 5, 19),

                UpdatedAt = DateTime.Now,
                photo = "5.jpg"
            },
            new Item
            {
                Id = 6,
                Title = "Cyberpunk 2077",
                Description = "An action role-playing game developed and published by CD Projekt.",
                RelaseDate = new DateTime(2020, 12, 10),

                UpdatedAt = DateTime.Now,
                photo = "6.jpg"
            },
            new Item
            {
                Id = 7,
                Title = "Minecraft",
                Description = "A sandbox video game developed by Mojang.",
                RelaseDate = new DateTime(2011, 11, 18),

                UpdatedAt = DateTime.Now,
                photo = "7.jpg"
            },
            new Item
            {
                Id = 8,
                Title = "Fortnite",
                Description = "An online video game developed by Epic Games.",
                RelaseDate = new DateTime(2017, 7, 25),

                UpdatedAt = DateTime.Now,
                photo = "8.png"
            },
            new Item
            {
                Id = 9,
                Title = "The Elder Scrolls V: Skyrim",
                Description = "An action role-playing game developed by Bethesda Game Studios and published by Bethesda Softworks.",
                RelaseDate = new DateTime(2011, 11, 11),

                UpdatedAt = DateTime.Now,
                photo = "9.jpg"
            },
            new Item
            {
                Id = 10,
                Title = "Horizon Zero Dawn",
                Description = "An action role-playing game developed by Guerrilla Games and published by Sony Interactive Entertainment.",
                RelaseDate = new DateTime(2017, 2, 28),

                UpdatedAt = DateTime.Now,
                photo = "10.jpg"
            },


                new Item
                {
                    Id = 11,
                    Title = "Final Fantasy XV",
                    Description = "An action role-playing game developed and published by Square Enix.",
                    RelaseDate = new DateTime(2016, 11, 29),

                    UpdatedAt = DateTime.Now,
                    photo = "11.jpg"
                },
            new Item
            {
                Id = 12,
                Title = "Persona 5",
                Description = "A role-playing video game developed by Atlus.",
                RelaseDate = new DateTime(2016, 9, 15),

                UpdatedAt = DateTime.Now,
                photo = "12.png"
            },
            new Item
            {
                Id = 13,
                Title = "Dark Souls III",
                Description = "An action role-playing game developed by FromSoftware and published by Bandai Namco Entertainment.",
                RelaseDate = new DateTime(2016, 3, 24),

                UpdatedAt = DateTime.Now,
                photo = "13.jpg"
            },
            new Item
            {
                Id = 14,
                Title = "Bloodborne",
                Description = "An action role-playing game developed by FromSoftware and published by Sony Computer Entertainment.",
                RelaseDate = new DateTime(2015, 3, 24),

                UpdatedAt = DateTime.Now,
                photo = "14.jpg"
            },
            new Item
            {
                Id = 15,
                Title = "Overwatch",
                Description = "A team-based multiplayer first-person shooter developed and published by Blizzard Entertainment.",
                RelaseDate = new DateTime(2016, 5, 24),

                UpdatedAt = DateTime.Now,
                photo = "15.jpg"
            },
            new Item
            {
                Id = 16,
                Title = "Sekiro: Shadows Die Twice",
                Description = "An action-adventure game developed by FromSoftware and published by Activision.",
                RelaseDate = new DateTime(2019, 3, 22),

                UpdatedAt = DateTime.Now,
                photo = "16.jpg"
            },
            new Item
            {
                Id = 17,
                Title = "Nioh",
                Description = "An action role-playing game developed by Team Ninja and published by Koei Tecmo.",
                RelaseDate = new DateTime(2017, 2, 7),

                UpdatedAt = DateTime.Now,
                photo = "17.jpg"
            },
            new Item
            {
                Id = 18,
                Title = "Monster Hunter: World",
                Description = "An action role-playing game developed and published by Capcom.",
                RelaseDate = new DateTime(2018, 1, 26),

                UpdatedAt = DateTime.Now,
                photo = "18.png"
            },
            new Item
            {
                Id = 19,
                Title = "Resident Evil 2",
                Description = "A survival horror game developed and published by Capcom.",
                RelaseDate = new DateTime(2019, 1, 25),

                UpdatedAt = DateTime.Now,
                photo = "19.jpg"
            },
            new Item
            {
                Id = 20,
                Title = "Ghost of Tsushima",
                Description = "An action-adventure game developed by Sucker Punch Productions and published by Sony Interactive Entertainment.",
                RelaseDate = new DateTime(2020, 7, 17),

                UpdatedAt = DateTime.Now,
                photo = "20.jpg"
            },
            new Item
            {
                Id = 21,
                Title = "Assassin's Creed Valhalla",
                Description = "An action role-playing video game developed by Ubisoft Montreal and published by Ubisoft.",
                RelaseDate = new DateTime(2020, 11, 10),

                UpdatedAt = DateTime.Now,
                photo = "21.jpg"
            },
            new Item
            {
                Id = 22,
                Title = "The Last of Us Part II",
                Description = "An action-adventure game developed by Naughty Dog and published by Sony Interactive Entertainment.",
                RelaseDate = new DateTime(2020, 6, 19),

                UpdatedAt = DateTime.Now,
                photo = "22.jpg"
            },
            new Item
            {
                Id = 23,
                Title = "Control",
                Description = "An action-adventure game developed by Remedy Entertainment and published by 505 Games.",
                RelaseDate = new DateTime(2019, 8, 27),

                UpdatedAt = DateTime.Now,
                photo = "23.jpg"
            },
            new Item
            {
                Id = 24,
                Title = "Hades",
                Description = "A roguelike action dungeon crawler video game developed and published by Supergiant Games.",
                RelaseDate = new DateTime(2020, 9, 17),

                UpdatedAt = DateTime.Now,
                photo = "24.png"
            },
            new Item
            {
                Id = 25,
                Title = "Doom Eternal",
                Description = "A first-person shooter game developed by id Software and published by Bethesda Softworks.",
                RelaseDate = new DateTime(2020, 3, 20),

                UpdatedAt = DateTime.Now,
                photo = "25.jpg"
            },
            new Item
            {
                Id = 26,
                Title = "Genshin Impact",
                Description = "An action role-playing game developed and published by miHoYo.",
                RelaseDate = new DateTime(2020, 9, 28),

                UpdatedAt = DateTime.Now,
                photo = "26.jpg"
            },
            new Item
            {
                Id = 27,
                Title = "Death Stranding",
                Description = "An action game developed by Kojima Productions and published by Sony Interactive Entertainment.",
                RelaseDate = new DateTime(2019, 11, 8),

                UpdatedAt = DateTime.Now,
                photo = "27.jpg"
            },
            new Item
            {
                Id = 28,
                Title = "Marvel's Spider-Man",
                Description = "An action-adventure game developed by Insomniac Games and published by Sony Interactive Entertainment.",
                RelaseDate = new DateTime(2018, 9, 7),

                UpdatedAt = DateTime.Now,
                photo = "28.jpg"
            },
            new Item
            {
                Id = 29,
                Title = "Half-Life: Alyx",
                Description = "A virtual reality first-person shooter developed and published by Valve.",
                RelaseDate = new DateTime(2020, 3, 23),

                UpdatedAt = DateTime.Now,
                photo = "29.webp"
            },

            new Item
            {
                Id = 30,
                Title = "Mount and Blade II: Bannerlord",
                Description = "An action role-playing game developed and published by TaleWorlds Entertainment. Bannerlord is a prequel to Mount & Blade: Warband, a stand-alone expansion pack for the 2008 game Mount & Blade.",
                RelaseDate = new DateTime(2020, 3, 30),

                UpdatedAt = DateTime.Now,
                photo = "30.jpg"
            },


    new Item
    {
        Id = 31,
        Title = "Batman: Arkham Asylum",
        Description = "Explore the depths of Arkham Asylum as Batman, unraveling a sinister plot orchestrated by his arch-nemesis, the Joker.",
        RelaseDate = new DateTime(2009, 8, 25),

        UpdatedAt = DateTime.Now,
        photo = "31.jpg"
    },
    new Item
    {
        Id = 32,
        Title = "Batman: Arkham City",
        Description = "Gotham City is transformed into a sprawling prison, and Batman must navigate its dangerous streets to uncover a new threat.",
        RelaseDate = new DateTime(2011, 10, 18),

        UpdatedAt = DateTime.Now,
        photo = "32.jpg"
    },
    new Item
    {
        Id = 33,
        Title = "Batman: Arkham Knight",
        Description = "The Dark Knight faces the ultimate threat to Gotham City as the Scarecrow unites Batman's foes to destroy him once and for all.",
        RelaseDate = new DateTime(2015, 6, 23),

        UpdatedAt = DateTime.Now,
        photo = "33.jpg"
    }


        );
        }





    }
}

