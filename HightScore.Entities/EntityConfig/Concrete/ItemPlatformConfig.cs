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

            var random = new Random();
            var itemPlatforms = new List<ItemPlatform>();
            int idCounter = 1;

            for (int itemId = 1; itemId <= 33; itemId++)
            {
                var platformIds = Enumerable.Range(1, 22).OrderBy(x => random.Next()).Take(4).ToList();

                foreach (var platformId in platformIds)
                {
                    itemPlatforms.Add(new ItemPlatform
                    {
                        Id = idCounter++,
                        itemId = itemId,
                        platformId = platformId,
                    });
                }
            }

            builder.HasData(itemPlatforms);
        }
    }
}
