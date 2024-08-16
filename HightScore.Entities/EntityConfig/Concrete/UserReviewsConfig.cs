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

            // builder.Property(i => i.ItemId).IsRequired();
            builder.Property(i => i.UserRating).IsRequired();
            builder.Property(i => i.Comment).IsRequired().HasMaxLength(800);

            builder.HasKey(p => new { p.ItemId, p.UserId });
            builder.HasOne(p => p.user).WithMany(p => p.UserReviews).HasForeignKey(p => p.UserId);
            builder.HasOne(p => p.Item).WithMany(p => p.userReviews).HasForeignKey(p => p.ItemId);


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
            var uniqueCombinations = new HashSet<(int ItemId, string UserId)>();

            for (int itemId = 1; itemId <= 33; itemId++)
            {
                for (int i = 0; i < 20; i++)
                {
                    string userId;
                    do
                    {
                        userId = random.Next(1, 21).ToString();
                    } while (!uniqueCombinations.Add((itemId, userId)));

                    var userRating = random.Next(30, 101);
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
