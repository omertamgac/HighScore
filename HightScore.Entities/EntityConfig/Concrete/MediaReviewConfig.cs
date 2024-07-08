using HightScore.Entities.EntityConfig.Abstract;
using HightScore.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HightScore.Entities.EntityConfig.Concrete
{
    public class MediaReviewConfig : BaseConfig<MediaReview>
    {
        public override void Configure(EntityTypeBuilder<MediaReview> builder)
        {
            base.Configure(builder);

            builder.Property(i => i.Comment).IsRequired();
            builder.Property(i => i.ItemId).IsRequired();
            builder.Property(i => i.MediaId).IsRequired();
            builder.Property(i => i.Rating).IsRequired();


        }
    }
}
