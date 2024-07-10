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


            builder.HasData(
    new MediaReview
    {
        Id = 1,
        ItemId = 1,
        MediaId = 21,
        Rating = 85,
        Comment = "Great game with stunning graphics and engaging gameplay."
    },
    new MediaReview
    {
        Id = 2,
        ItemId = 2,
        MediaId = 22,
        Rating = 70,
        Comment = "Interesting storyline but could improve on the controls."
    },
    new MediaReview
    {
        Id = 3,
        ItemId = 3,
        MediaId = 23,
        Rating = 95,
        Comment = "Fantastic multiplayer experience, highly recommended!"
    },
    new MediaReview
    {
        Id = 4,
        ItemId = 4,
        MediaId = 24,
        Rating = 60,
        Comment = "Average game, had high expectations but it fell short."
    },
    new MediaReview
    {
        Id = 5,
        ItemId = 5,
        MediaId = 25,
        Rating = 75,
        Comment = "Good game overall, but needs some bug fixes."
    },
    new MediaReview
    {
        Id = 6,
        ItemId = 6,
        MediaId = 26,
        Rating = 80,
        Comment = "Very enjoyable game with lots of content."
    },
    new MediaReview
    {
        Id = 7,
        ItemId = 7,
        MediaId = 27,
        Rating = 90,
        Comment = "One of the best games I've played this year!"
    },
    new MediaReview
    {
        Id = 8,
        ItemId = 8,
        MediaId = 28,
        Rating = 65,
        Comment = "Decent game but lacks depth in some areas."
    },
    new MediaReview
    {
        Id = 9,
        ItemId = 9,
        MediaId = 29,
        Rating = 78,
        Comment = "Solid game with good mechanics and storyline."
    },
    new MediaReview
    {
        Id = 10,
        ItemId = 10,
        MediaId = 30,
        Rating = 88,
        Comment = "Great game, would recommend to all RPG fans."
    }
);




        }
    }
}
