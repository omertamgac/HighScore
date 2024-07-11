using HightScore.Entities.EntityConfig.Abstract;
using HightScore.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HightScore.Entities.EntityConfig.Concrete
{
    public class UsersConfig : BaseConfig<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.HasIndex(u => u.UserName).IsUnique();
            builder.HasIndex(u => u.Email).IsUnique();
            builder.HasIndex(u => u.NickName).IsUnique();

            builder.Property(u => u.UserName).IsRequired().HasMaxLength(50);
            builder.Property(u => u.Email).IsRequired().HasMaxLength(50);

            builder.Property(u => u.Password).IsRequired();
            builder.Property(u => u.Phone).HasMaxLength(20);


            builder.HasData
                   (
        new User { Id = 1, UserName = "user1", Email = "user1@example.com", Password = "hashed_password", Phone = "1234567890", NickName = "UserOne" },
        new User { Id = 2, UserName = "user2", Email = "user2@example.com", Password = "hashed_password", Phone = "1234567891", NickName = "UserTwo" },
        new User { Id = 3, UserName = "user3", Email = "user3@example.com", Password = "hashed_password", Phone = "1234567892", NickName = "UserThree" },
        new User { Id = 4, UserName = "user4", Email = "user4@example.com", Password = "hashed_password", Phone = "1234567893", NickName = "UserFour" },
        new User { Id = 5, UserName = "user5", Email = "user5@example.com", Password = "hashed_password", Phone = "1234567894", NickName = "UserFive" },
        new User { Id = 6, UserName = "user6", Email = "user6@example.com", Password = "hashed_password", Phone = "1234567895", NickName = "UserSix" },
        new User { Id = 7, UserName = "user7", Email = "user7@example.com", Password = "hashed_password", Phone = "1234567896", NickName = "UserSeven" },
        new User { Id = 8, UserName = "user8", Email = "user8@example.com", Password = "hashed_password", Phone = "1234567897", NickName = "UserEight" },
        new User { Id = 9, UserName = "user9", Email = "user9@example.com", Password = "hashed_password", Phone = "1234567898", NickName = "UserNine" },
        new User { Id = 10, UserName = "user10", Email = "user10@example.com", Password = "hashed_password", Phone = "1234567899", NickName = "UserTen" },
        new User { Id = 11, UserName = "user11", Email = "user11@example.com", Password = "hashed_password", Phone = "2234567890", NickName = "UserEleven" },
        new User { Id = 12, UserName = "user12", Email = "user12@example.com", Password = "hashed_password", Phone = "2234567891", NickName = "UserTwelve" },
        new User { Id = 13, UserName = "user13", Email = "user13@example.com", Password = "hashed_password", Phone = "2234567892", NickName = "UserThirteen" },
        new User { Id = 14, UserName = "user14", Email = "user14@example.com", Password = "hashed_password", Phone = "2234567893", NickName = "UserFourteen" },
        new User { Id = 15, UserName = "user15", Email = "user15@example.com", Password = "hashed_password", Phone = "2234567894", NickName = "UserFifteen" },
        new User { Id = 16, UserName = "user16", Email = "user16@example.com", Password = "hashed_password", Phone = "2234567895", NickName = "UserSixteen" },
        new User { Id = 17, UserName = "user17", Email = "user17@example.com", Password = "hashed_password", Phone = "2234567896", NickName = "UserSeventeen" },
        new User { Id = 18, UserName = "user18", Email = "user18@example.com", Password = "hashed_password", Phone = "2234567897", NickName = "UserEighteen" },
        new User { Id = 19, UserName = "user19", Email = "user19@example.com", Password = "hashed_password", Phone = "2234567898", NickName = "UserNineteen" },
        new User { Id = 20, UserName = "user20", Email = "user20@example.com", Password = "hashed_password", Phone = "2234567899", NickName = "UserTwenty" }

                   );





        }
    }
}
