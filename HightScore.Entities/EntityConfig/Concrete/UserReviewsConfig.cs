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

            builder.HasData(
    new UserReview
    {
        Id = 1,
        ItemId = 1,
        UserId = 8,
        UserRating = 8,
        Comment = "Great game, enjoyed playing it!"
    },
    new UserReview
    {
        Id = 2,
        ItemId = 2,
        UserId = 9,
        UserRating = 7,
        Comment = "Interesting game but needs better controls."
    },
    new UserReview
    {
        Id = 3,
        ItemId = 3,
        UserId = 10,
        UserRating = 9,
        Comment = "Absolutely loved this game, couldn't stop playing."
    },
    new UserReview
    {
        Id = 4,
        ItemId = 4,
        UserId = 11,
        UserRating = 6,
        Comment = "Decent game, but could use more content."
    },
    new UserReview
    {
        Id = 5,
        ItemId = 5,
        UserId = 12,
        UserRating = 7,
        Comment = "Good game overall, enjoyed the storyline."
    },
    new UserReview
    {
        Id = 6,
        ItemId = 6,
        UserId = 13,
        UserRating = 8,
        Comment = "Very immersive experience, would recommend."
    },
    new UserReview
    {
        Id = 7,
        ItemId = 7,
        UserId = 14,
        UserRating = 9,
        Comment = "One of my favorite games, highly recommended."
    },
    new UserReview
    {
        Id = 8,
        ItemId = 8,
        UserId = 15,
        UserRating = 6,
        Comment = "Liked the game, but could be more challenging."
    },
    new UserReview
    {
        Id = 9,
        ItemId = 9,
        UserId = 16,
        UserRating = 7,
        Comment = "Solid gameplay mechanics, enjoyable experience."
    },
    new UserReview
    {
        Id = 10,
        ItemId = 10,
        UserId = 17,
        UserRating = 8,
        Comment = "Great RPG game, loved the customization options."
    }
);



        }


    }
}
