using HightScore.Entities.EntityConfig.Abstract;
using HightScore.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HightScore.Entities.EntityConfig.Concrete
{
    public class ItemPlatformConfig : BaseConfig<ItemPlatform>
    {
        public override void Configure(EntityTypeBuilder<ItemPlatform> builder)
        {
            base.Configure(builder);

            builder.HasKey(x => new { x.itemId, x.platformId });

            builder.HasOne(x => x.platform)
                .WithMany(x => x.ItemPlatforms)
                .HasForeignKey(x => x.platformId);

            builder.HasOne(x => x.Item)
                .WithMany(x => x.ItemPlatforms)
                .HasForeignKey(x => x.itemId);

            builder.HasData
                (
                new ItemPlatform { Id = 1, itemId = 1, platformId = 3 },
                new ItemPlatform { Id = 2, itemId = 1, platformId = 11 },
                new ItemPlatform { Id = 3, itemId = 6, platformId = 1 },
                new ItemPlatform { Id = 4, itemId = 6, platformId = 2 },
                new ItemPlatform { Id = 5, itemId = 6, platformId = 4 },
                new ItemPlatform { Id = 6, itemId = 6, platformId = 5 },
                new ItemPlatform { Id = 7, itemId = 6, platformId = 6 }
                );


        }
    }
}
