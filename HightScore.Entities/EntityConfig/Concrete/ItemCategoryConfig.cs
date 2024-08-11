using HightScore.Entities.EntityConfig.Abstract;
using HightScore.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HightScore.Entities.EntityConfig.Concrete
{
    public class ItemCategoryConfig : BaseConfig<ItemCategory>
    {
        public override void Configure(EntityTypeBuilder<ItemCategory> builder)
        {
            base.Configure(builder);

            builder.HasKey(ur => new { ur.itemId, ur.categoryId });

            builder
                .HasOne(ur => ur.category)
                .WithMany(u => u.ItemCategories)
                .HasForeignKey(ur => ur.categoryId);

            builder
                .HasOne(ur => ur.items)
                .WithMany(r => r.ItemCategories)
                .HasForeignKey(ur => ur.itemId);

            var random = new Random();
            var itemCategories = new List<ItemCategory>();
            int idCounter = 1;

            for (int itemId = 1; itemId <= 33; itemId++)
            {
                var categoryIds = Enumerable.Range(1, 50).OrderBy(x => random.Next()).Take(4).ToList();

                foreach (var categoryId in categoryIds)
                {
                    itemCategories.Add(new ItemCategory
                    {
                        Id = idCounter++,
                        itemId = itemId,
                        categoryId = categoryId,
                    });
                }
            }

            builder.HasData(itemCategories);
        }
    }
}
