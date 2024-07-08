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

        }
    }
}
