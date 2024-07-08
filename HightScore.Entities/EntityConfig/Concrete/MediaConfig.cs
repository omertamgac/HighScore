using HightScore.Entities.EntityConfig.Abstract;
using HightScore.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HightScore.Entities.EntityConfig.Concrete
{
    public class MediaConfig : BaseConfig<Media>
    {
        public override void Configure(EntityTypeBuilder<Media> builder)
        {
            base.Configure(builder);

            builder.Property(i => i.UserName).IsRequired().HasMaxLength(50);
            builder.Property(i => i.Password).IsRequired().HasMaxLength(100);
            builder.Property(i => i.Country).IsRequired().HasMaxLength(100);
            builder.Property(i => i.City).IsRequired().HasMaxLength(100);
            builder.Property(i => i.Email).IsRequired().HasMaxLength(70);
            builder.Property(i => i.phone).IsRequired().HasMaxLength(30);
            builder.Property(i => i.TaxIdNumber).IsRequired();
            builder.Property(i => i.MediaName).IsRequired().HasMaxLength(50);


            builder.HasIndex(i => i.UserName).IsUnique();
            builder.HasIndex(i => i.Email).IsUnique();
            builder.HasIndex(i => i.phone).IsUnique();
            builder.HasIndex(i => i.TaxIdNumber).IsUnique();
            builder.HasIndex(i => i.MediaName).IsUnique();



        }
    }
}
