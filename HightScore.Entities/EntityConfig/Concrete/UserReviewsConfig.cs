using HightScore.Entities.EntityConfig.Abstract;
using HightScore.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HightScore.Entities.EntityConfig.Concrete
{
    public class UserReviewsConfig : BaseConfig<UserReview>
    {
        public override void Configure(EntityTypeBuilder<UserReview> builder)
        {
            base.Configure(builder);

            builder.Property(i => i.ItemId).IsRequired();
            builder.Property(i => i.UserRating).IsRequired();
            builder.Property(i => i.Comment).IsRequired();


        }


    }
}
