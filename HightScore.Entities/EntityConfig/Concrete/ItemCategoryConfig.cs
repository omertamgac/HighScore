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


            builder.HasData(

                new ItemCategory { Id = 1, itemId = 1, categoryId = 1 },
                new ItemCategory { Id = 2, itemId = 1, categoryId = 2 },
                new ItemCategory { Id = 3, itemId = 6, categoryId = 1 },
                new ItemCategory { Id = 4, itemId = 6, categoryId = 2 },
                new ItemCategory { Id = 5, itemId = 6, categoryId = 3 },
                new ItemCategory { Id = 6, itemId = 6, categoryId = 14 }



                );


        }


    }
}
