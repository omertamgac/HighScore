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
            builder.Property(i => i.Comment).IsRequired().HasMaxLength(800);

            // Seed data
            var comments = new[]
            {
                "Great game, really enjoyed it!",
                "Not bad, could be better.",
                "I didn't like this game much.",
                "Fantastic experience, highly recommend!",
                "Quite boring and repetitive.",
                "Average game, nothing special.",
                "Loved the graphics and storyline.",
                "Gameplay was not very engaging.",
                "A must-play for all gamers!",
                "Disappointing, had high expectations."
            };

            var random = new Random();
            var userReviews = new List<UserReview>();

            for (int itemId = 1; itemId <= 33; itemId++)
            {
                for (int i = 0; i < 3; i++)
                {
                    var userId = random.Next(1, 21);
                    var userRating = random.Next(1, 11);
                    var comment = comments[random.Next(comments.Length)];

                    userReviews.Add(new UserReview
                    {
                        Id = itemId * 3 + i,
                        ItemId = itemId,
                        UserId = userId,
                        UserRating = userRating,
                        Comment = comment,
                    });
                }
            }

            builder.HasData(userReviews);
        }
    }
}
