using HightScore.Entities.EntityConfig.Abstract;
using HightScore.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HightScore.Entities.EntityConfig.Concrete
{
    public class PlatformsConfig : BaseConfig<Platform>
    {
        public override void Configure(EntityTypeBuilder<Platform> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.PlatformName).IsRequired().HasMaxLength(150);
            builder.HasIndex(p => p.PlatformName).IsUnique();

            builder.HasData(
            new Platform { Id = 1, PlatformName = "PlayStation 5" },
            new Platform { Id = 2, PlatformName = "Xbox Series X" },
            new Platform { Id = 3, PlatformName = "Nintendo Switch" },
            new Platform { Id = 4, PlatformName = "PlayStation 4" },
            new Platform { Id = 5, PlatformName = "Xbox One" },
            new Platform { Id = 6, PlatformName = "PC" },
            new Platform { Id = 7, PlatformName = "PlayStation Vita" },
            new Platform { Id = 8, PlatformName = "Nintendo 3DS" },
            new Platform { Id = 9, PlatformName = "Stadia" },
            new Platform { Id = 10, PlatformName = "Oculus Quest 2" },
            new Platform { Id = 11, PlatformName = "Nintendo Wii U" },
            new Platform { Id = 12, PlatformName = "PlayStation 3" },
            new Platform { Id = 13, PlatformName = "Xbox 360" },
            new Platform { Id = 14, PlatformName = "Nintendo Wii" },
            new Platform { Id = 15, PlatformName = "PlayStation Portable (PSP)" },
            new Platform { Id = 16, PlatformName = "Game Boy Advance" },
            new Platform { Id = 17, PlatformName = "Sega Dreamcast" },
            new Platform { Id = 18, PlatformName = "Super Nintendo Entertainment System (SNES)" },
            new Platform { Id = 19, PlatformName = "Sega Genesis" },
            new Platform { Id = 20, PlatformName = "Atari 2600" },
            new Platform { Id = 21, PlatformName = "PlayStation 2" },
            new Platform { Id = 22, PlatformName = "PlayStation 1" }

            );




        }
    }
}
