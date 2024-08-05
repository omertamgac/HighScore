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

            builder.HasData(
            new Item
            {
                Id = 1,
                Title = "The Legend of Zelda: Breath of the Wild",
                Description = "An action-adventure game developed and published by Nintendo.",
                RelaseDate = new DateTime(2017, 3, 3),
                UpdatedAt = DateTime.Now,
                photo = "1.jpg",
                Iframe = "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/zw47_q9wbBE\" title=\"The Legend of Zelda: Breath of the Wild - Nintendo Switch Presentation 2017 Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>"
            },
            new Item
            {
                Id = 2,
                Title = "Super Mario Odyssey",
                Description = "A platform game developed and published by Nintendo for the Nintendo Switch.",
                RelaseDate = new DateTime(2017, 10, 27),
                UpdatedAt = DateTime.Now,
                photo = "2.webp",
                Iframe = "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/5kcdRBHM7kM\" title=\"Super Mario Odyssey - Nintendo Switch Presentation 2017 Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>"
            },
            new Item
            {
                Id = 3,
                Title = "Red Dead Redemption 2",
                Description = "An action-adventure game developed and published by Rockstar Games.",
                RelaseDate = new DateTime(2018, 10, 26),
                UpdatedAt = DateTime.Now,
                photo = "3.jpg",
                Iframe = "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/HVRzx17WHVk\" title=\"Red Dead Redemption 2 Launch Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>"

            },
            new Item
            {
                Id = 4,
                Title = "God of War",
                Description = "An action-adventure game developed by Santa Monica Studio and published by Sony Interactive Entertainment.",
                RelaseDate = new DateTime(2018, 4, 20),
                UpdatedAt = DateTime.Now,
                photo = "4.jpg",
                Iframe = "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/Ty7WudwSKMA\" title=\"God of War: Ragnarok - Teaser Trailer | PS5 Showcase\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>"

            },
            new Item
            {
                Id = 5,
                Title = "The Witcher 3: Wild Hunt",
                Description = "An action role-playing game developed and published by CD Projekt.",
                RelaseDate = new DateTime(2015, 5, 19),
                Iframe = "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/c0i88t0Kacs\" title=\"The Witcher 3: Wild Hunt - Killing Monsters Cinematic Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>",
                UpdatedAt = DateTime.Now,
                photo = "5.jpg"
            },
            new Item
            {
                Id = 6,
                Title = "Cyberpunk 2077",
                Description = "An action role-playing game developed and published by CD Projekt.",
                RelaseDate = new DateTime(2020, 12, 10),
                Iframe = "<iframe width=\"930\" height=\"388\" src=\"https://www.youtube.com/embed/P99qJGrPNLs\" title=\"Cyberpunk 2077 Teaser Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>",
                UpdatedAt = DateTime.Now,
                photo = "6.jpg"
            },
            new Item
            {
                Id = 7,
                Title = "Minecraft",
                Description = "A sandbox video game developed by Mojang.",
                RelaseDate = new DateTime(2011, 11, 18),
                Iframe = "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/MmB9b5njVbA\" title=\"Official Minecraft Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>",
                UpdatedAt = DateTime.Now,
                photo = "7.jpg"
            },
            new Item
            {
                Id = 8,
                Title = "Fortnite",
                Description = "An online video game developed by Epic Games.",
                RelaseDate = new DateTime(2017, 7, 25),
                Iframe = "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/hHTE5xg9E-g\" title=\"Fortnite Teaser Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>",
                UpdatedAt = DateTime.Now,
                photo = "8.png"
            },
            new Item
            {
                Id = 9,
                Title = "The Elder Scrolls V: Skyrim",
                Description = "An action role-playing game developed by Bethesda Game Studios and published by Bethesda Softworks.",
                RelaseDate = new DateTime(2011, 11, 11),
                Iframe = "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/JSRtYpNRoN0\" title=\"The Elder Scrolls V: Skyrim - Official Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>",
                UpdatedAt = DateTime.Now,
                photo = "9.jpg"
            },
            new Item
            {
                Id = 10,
                Title = "Horizon Zero Dawn",
                Description = "An action role-playing game developed by Guerrilla Games and published by Sony Interactive Entertainment.",
                RelaseDate = new DateTime(2017, 2, 28),
                Iframe = "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/u4-FCsiF5x4\" title=\"Horizon Zero Dawn - E3 2016 Trailer I PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>",
                UpdatedAt = DateTime.Now,
                photo = "10.jpg"
            },


                new Item
                {
                    Id = 11,
                    Title = "Final Fantasy XV",
                    Description = "An action role-playing game developed and published by Square Enix.",
                    RelaseDate = new DateTime(2016, 11, 29),
                    Iframe = "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/CNM6o9um1dc\" title=\"FINAL FANTASY XV - Omen Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>",
                    UpdatedAt = DateTime.Now,
                    photo = "11.jpg"
                },
            new Item
            {
                Id = 12,
                Title = "Persona 5",
                Description = "A role-playing video game developed by Atlus.",
                RelaseDate = new DateTime(2016, 9, 15),
                Iframe = "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/QnDzJ9KzuV4\" title=\"Persona 5 | Launch Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>",
                UpdatedAt = DateTime.Now,
                photo = "12.png"
            },
            new Item
            {
                Id = 13,
                Title = "Dark Souls III",
                Description = "An action role-playing game developed by FromSoftware and published by Bandai Namco Entertainment.",
                RelaseDate = new DateTime(2016, 3, 24),
                Iframe = "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/cWBwFhUv1-8\" title=\"Dark Souls III – Launch Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>",
                UpdatedAt = DateTime.Now,
                photo = "13.jpg"
            },
            new Item
            {
                Id = 14,
                Title = "Bloodborne",
                Description = "An action role-playing game developed by FromSoftware and published by Sony Computer Entertainment.",
                RelaseDate = new DateTime(2015, 3, 24),
                Iframe = "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/G203e1HhixY\" title=\"Bloodborne Debut Trailer | Face Your Fears | PlayStation 4 Action RPG\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>",
                UpdatedAt = DateTime.Now,
                photo = "14.jpg"
            },
            new Item
            {
                Id = 15,
                Title = "Overwatch",
                Description = "A team-based multiplayer first-person shooter developed and published by Blizzard Entertainment.",
                RelaseDate = new DateTime(2016, 5, 24),
                Iframe = "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/IBIwGKDwnWY\" title=\"Overwatch Theatrical Teaser | &quot;We Are Overwatch&quot;\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>",
                UpdatedAt = DateTime.Now,
                photo = "15.jpg"
            },
            new Item
            {
                Id = 16,
                Title = "Sekiro: Shadows Die Twice",
                Description = "An action-adventure game developed by FromSoftware and published by Activision.",
                RelaseDate = new DateTime(2019, 3, 22),
                Iframe = "",
                UpdatedAt = DateTime.Now,
                photo = "16.jpg"
            },
            new Item
            {
                Id = 17,
                Title = "Nioh",
                Description = "An action role-playing game developed by Team Ninja and published by Koei Tecmo.",
                RelaseDate = new DateTime(2017, 2, 7),
                Iframe = "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/cHTtNdkDduQ\" title=\"Nioh 2 Reveal Teaser Trailer - E3 2018\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>",
                UpdatedAt = DateTime.Now,
                photo = "17.jpg"
            },
            new Item
            {
                Id = 18,
                Title = "Monster Hunter: World",
                Description = "An action role-playing game developed and published by Capcom.",
                RelaseDate = new DateTime(2018, 1, 26),
                Iframe = "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/xtxJtQa6VSw\" title=\"Resident Evil 2 – E3 2018 Announcement Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>",
                UpdatedAt = DateTime.Now,
                photo = "18.png"
            },
            new Item
            {
                Id = 19,
                Title = "Resident Evil 2",
                Description = "A survival horror game developed and published by Capcom.",
                RelaseDate = new DateTime(2019, 1, 25),
                Iframe = "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/xtxJtQa6VSw\" title=\"Resident Evil 2 – E3 2018 Announcement Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>",
                UpdatedAt = DateTime.Now,
                photo = "19.jpg"
            },
            new Item
            {
                Id = 20,
                Title = "Ghost of Tsushima",
                Description = "An action-adventure game developed by Sucker Punch Productions and published by Sony Interactive Entertainment.",
                RelaseDate = new DateTime(2020, 7, 17),
                Iframe = "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/RcWk08PBe7k\" title=\"Ghost of Tsushima - A Storm is Coming Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>",
                UpdatedAt = DateTime.Now,
                photo = "20.jpg"
            },
            new Item
            {
                Id = 21,
                Title = "Assassin's Creed Valhalla",
                Description = "An action role-playing video game developed by Ubisoft Montreal and published by Ubisoft.",
                RelaseDate = new DateTime(2020, 11, 10),
                Iframe = "<iframe width=\"930\" height=\"390\" src=\"https://www.youtube.com/embed/rKjUAWlbTJk\" title=\"Assassin’s Creed Valhalla: Cinematic World Premiere Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>",
                UpdatedAt = DateTime.Now,
                photo = "21.jpg"
            },
            new Item
            {
                Id = 22,
                Title = "The Last of Us Part II",
                Description = "An action-adventure game developed by Naughty Dog and published by Sony Interactive Entertainment.",
                RelaseDate = new DateTime(2020, 6, 19),
                Iframe = "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/W2Wnvvj33Wo\" title=\"The Last of Us Part II - PlayStation Experience 2016: Reveal Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>",
                UpdatedAt = DateTime.Now,
                photo = "22.jpg"
            },
            new Item
            {
                Id = 23,
                Title = "Control",
                Description = "An action-adventure game developed by Remedy Entertainment and published by 505 Games.",
                RelaseDate = new DateTime(2019, 8, 27),
                Iframe = "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/w6bE11FrSFM\" title=\"Control - Ultimate Edition Announcement Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>",
                UpdatedAt = DateTime.Now,
                photo = "23.jpg"
            },
            new Item
            {
                Id = 24,
                Title = "Hades",
                Description = "A roguelike action dungeon crawler video game developed and published by Supergiant Games.",
                RelaseDate = new DateTime(2020, 9, 17),
                Iframe = "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/91t0ha9x0AE\" title=\"Hades - Official Animated Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>",
                UpdatedAt = DateTime.Now,
                photo = "24.png"
            },
            new Item
            {
                Id = 25,
                Title = "Doom Eternal",
                Description = "A first-person shooter game developed by id Software and published by Bethesda Softworks.",
                RelaseDate = new DateTime(2020, 3, 20),
                Iframe = "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/_oVwrpfo_QA\" title=\"DOOM Eternal – Official E3 Teaser\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>",
                UpdatedAt = DateTime.Now,
                photo = "25.jpg"
            },
            new Item
            {
                Id = 26,
                Title = "Genshin Impact",
                Description = "An action role-playing game developed and published by miHoYo.",
                RelaseDate = new DateTime(2020, 9, 28),
                Iframe = "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/HLUY1nICQRY\" title=\"Genshin Impact - Official Launch Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>",
                UpdatedAt = DateTime.Now,
                photo = "26.jpg"
            },
            new Item
            {
                Id = 27,
                Title = "Death Stranding",
                Description = "An action game developed by Kojima Productions and published by Sony Interactive Entertainment.",
                RelaseDate = new DateTime(2019, 11, 8),
                Iframe = "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/H2Hy96sOnq8\" title=\"Death Stranding - Teaser Trailer - TGA 2016 - 4K\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>",
                UpdatedAt = DateTime.Now,
                photo = "27.jpg"
            },
            new Item
            {
                Id = 28,
                Title = "Marvel's Spider-Man",
                Description = "An action-adventure game developed by Insomniac Games and published by Sony Interactive Entertainment.",
                RelaseDate = new DateTime(2018, 9, 7),
                Iframe = "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/q4GdJVvdxss\" title=\"Marvel’s Spider-Man – Be Greater Extended Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>",
                UpdatedAt = DateTime.Now,
                photo = "28.jpg"
            },
            new Item
            {
                Id = 29,
                Title = "Half-Life: Alyx",
                Description = "A virtual reality first-person shooter developed and published by Valve.",
                RelaseDate = new DateTime(2020, 3, 23),
                Iframe = "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/O2W0N3uKXmo\" title=\"Half-Life: Alyx Announcement Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>",
                UpdatedAt = DateTime.Now,
                photo = "29.webp"
            },

            new Item
            {
                Id = 30,
                Title = "Mount and Blade II: Bannerlord",
                Description = "An action role-playing game developed and published by TaleWorlds Entertainment. Bannerlord is a prequel to Mount & Blade: Warband, a stand-alone expansion pack for the 2008 game Mount & Blade.",
                RelaseDate = new DateTime(2020, 3, 30),
                Iframe = "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/yCk6Jk7DvrA\" title=\"Mount &amp; Blade II: Bannerlord Early Access Announcement\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>",
                UpdatedAt = DateTime.Now,
                photo = "30.jpg"
            },


    new Item
    {
        Id = 31,
        Title = "Batman: Arkham Asylum",
        Description = "Explore the depths of Arkham Asylum as Batman, unraveling a sinister plot orchestrated by his arch-nemesis, the Joker.",
        RelaseDate = new DateTime(2009, 8, 25),
        Iframe = "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/bVk9jW9EzD0\" title=\"Batman: Arkham Asylum Teaser Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>",
        UpdatedAt = DateTime.Now,
        photo = "31.jpg"
    },
    new Item
    {
        Id = 32,
        Title = "Batman: Arkham City",
        Description = "Gotham City is transformed into a sprawling prison, and Batman must navigate its dangerous streets to uncover a new threat.",
        RelaseDate = new DateTime(2011, 10, 18),
        Iframe = "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/pcaFdTCiz4U\" title=\"Batman: Arkham City - Teaser\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>",
        UpdatedAt = DateTime.Now,
        photo = "32.jpg"
    },
    new Item
    {
        Id = 33,
        Title = "Batman: Arkham Knight",
        Description = "The Dark Knight faces the ultimate threat to Gotham City as the Scarecrow unites Batman's foes to destroy him once and for all.",
        RelaseDate = new DateTime(2015, 6, 23),
        Iframe = "<iframe width=\"560\" height=\"315\" src=\"https://www.youtube.com/embed/wsf78BS9VE0\" title=\"YouTube video player\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" allowfullscreen></iframe>\r\n",
        UpdatedAt = DateTime.Now,
        photo = "33.jpg"
    }
        );
        }





    }
}

