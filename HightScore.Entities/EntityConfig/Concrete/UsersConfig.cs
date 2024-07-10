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
            builder.Property(u => u.Role).IsRequired();

            builder.Property(u => u.Password).IsRequired();
            builder.Property(u => u.Phone).HasMaxLength(20);


            builder.HasData(
    // Admin Users
    new User
    {
        Id = 1,
        UserName = "admin1",
        Email = "admin1@example.com",
        Password = "admin1_password",
        Role = "Admin",
        Phone = "+90-555-000-0001",
        NickName = "AdminOne"
    },
    new User
    {
        Id = 2,
        UserName = "admin2",
        Email = "admin2@example.com",
        Password = "admin2_password",
        Role = "Admin",
        Phone = "+90-555-000-0002",
        NickName = "AdminTwo"
    },

    new User
    {
        Id = 3,
        UserName = "editor1",
        Email = "editor1@example.com",
        Password = "editor1_password",
        Role = "Editor",
        Phone = "+90-555-000-0003",
        NickName = "EditorOne"
    },
    new User
    {
        Id = 4,
        UserName = "editor2",
        Email = "editor2@example.com",
        Password = "editor2_password",
        Role = "Editor",
        Phone = "+90-555-000-0004",
        NickName = "EditorTwo"
    },
    new User
    {
        Id = 5,
        UserName = "editor3",
        Email = "editor3@example.com",
        Password = "editor3_password",
        Role = "Editor",
        Phone = "+90-555-000-0005",
        NickName = "EditorThree"
    },
    new User
    {
        Id = 6,
        UserName = "editor4",
        Email = "editor4@example.com",
        Password = "editor4_password",
        Role = "Editor",
        Phone = "+90-555-000-0006",
        NickName = "EditorFour"
    },
    new User
    {
        Id = 7,
        UserName = "editor5",
        Email = "editor5@example.com",
        Password = "editor5_password",
        Role = "Editor",
        Phone = "+90-555-000-0007",
        NickName = "EditorFive"
    },

    new User
    {
        Id = 8,
        UserName = "user1",
        Email = "user1@example.com",
        Password = "user1_password",
        Role = "User",
        Phone = "+90-555-000-0008",
        NickName = "UserOne"
    },
    new User
    {
        Id = 9,
        UserName = "user2",
        Email = "user2@example.com",
        Password = "user2_password",
        Role = "User",
        Phone = "+90-555-000-0009",
        NickName = "UserTwo"
    },
    new User
    {
        Id = 10,
        UserName = "user3",
        Email = "user3@example.com",
        Password = "user3_password",
        Role = "User",
        Phone = "+90-555-000-0010",
        NickName = "UserThree"
    },
    new User
    {
        Id = 11,
        UserName = "user4",
        Email = "user4@example.com",
        Password = "user4_password",
        Role = "User",
        Phone = "+90-555-000-0011",
        NickName = "UserFour"
    },
    new User
    {
        Id = 12,
        UserName = "user5",
        Email = "user5@example.com",
        Password = "user5_password",
        Role = "User",
        Phone = "+90-555-000-0012",
        NickName = "UserFive"
    },
    new User
    {
        Id = 13,
        UserName = "user6",
        Email = "user6@example.com",
        Password = "user6_password",
        Role = "User",
        Phone = "+90-555-000-0013",
        NickName = "UserSix"
    },
    new User
    {
        Id = 14,
        UserName = "user7",
        Email = "user7@example.com",
        Password = "user7_password",
        Role = "User",
        Phone = "+90-555-000-0014",
        NickName = "UserSeven"
    },
    new User
    {
        Id = 15,
        UserName = "user8",
        Email = "user8@example.com",
        Password = "user8_password",
        Role = "User",
        Phone = "+90-555-000-0015",
        NickName = "UserEight"
    },
    new User
    {
        Id = 16,
        UserName = "user9",
        Email = "user9@example.com",
        Password = "user9_password",
        Role = "User",
        Phone = "+90-555-000-0016",
        NickName = "UserNine"
    },
    new User
    {
        Id = 17,
        UserName = "user10",
        Email = "user10@example.com",
        Password = "user10_password",
        Role = "User",
        Phone = "+90-555-000-0017",
        NickName = "UserTen"
    },
    new User
    {
        Id = 18,
        UserName = "user11",
        Email = "user11@example.com",
        Password = "user11_password",
        Role = "User",
        Phone = "+90-555-000-0018",
        NickName = "UserEleven"
    },
    new User
    {
        Id = 19,
        UserName = "user12",
        Email = "user12@example.com",
        Password = "user12_password",
        Role = "User",
        Phone = "+90-555-000-0019",
        NickName = "UserTwelve"
    },
    new User
    {
        Id = 20,
        UserName = "user13",
        Email = "user13@example.com",
        Password = "user13_password",
        Role = "User",
        Phone = "+90-555-000-0020",
        NickName = "UserThirteen"
    },
    new User
    {
        Id = 21,
        UserName = "user14",
        Email = "user14@example.com",
        Password = "user14_password",
        Role = "User",
        Phone = "+90-555-000-0021",
        NickName = "UserFourteen"
    },
    new User
    {
        Id = 22,
        UserName = "user15",
        Email = "user15@example.com",
        Password = "user15_password",
        Role = "User",
        Phone = "+90-555-000-0022",
        NickName = "UserFifteen"
    },
    new User
    {
        Id = 23,
        UserName = "user16",
        Email = "user16@example.com",
        Password = "user16_password",
        Role = "User",
        Phone = "+90-555-000-0023",
        NickName = "UserSixteen"
    },
    new User
    {
        Id = 24,
        UserName = "user17",
        Email = "user17@example.com",
        Password = "user17_password",
        Role = "User",
        Phone = "+90-555-000-0024",
        NickName = "UserSeventeen"
    },
    new User
    {
        Id = 25,
        UserName = "user18",
        Email = "user18@example.com",
        Password = "user18_password",
        Role = "User",
        Phone = "+90-555-000-0025",
        NickName = "UserEighteen"
    },
    new User
    {
        Id = 26,
        UserName = "user19",
        Email = "user19@example.com",
        Password = "user19_password",
        Role = "User",
        Phone = "+90-555-000-0026",
        NickName = "UserNineteen"
    },
    new User
    {
        Id = 27,
        UserName = "user20",
        Email = "user20@example.com",
        Password = "user20_password",
        Role = "User",
        Phone = "+90-555-000-0027",
        NickName = "UserTwenty"
    },
    new User
    {
        Id = 28,
        UserName = "user21",
        Email = "user21@example.com",
        Password = "user21_password",
        Role = "User",
        Phone = "+90-555-000-0028",
        NickName = "UserTwentyOne"
    },
    new User
    {
        Id = 29,
        UserName = "user22",
        Email = "user22@example.com",
        Password = "user22_password",
        Role = "User",
        Phone = "+90-555-000-0029",
        NickName = "UserTwentyTwo"
    },
    new User
    {
        Id = 30,
        UserName = "user23",
        Email = "user23@example.com",
        Password = "user23_password",
        Role = "User",
        Phone = "+90-555-000-0030",
        NickName = "UserTwentyThree"
    },
    new User
    {
        Id = 31,
        UserName = "user24",
        Email = "user24@example.com",
        Password = "user24_password",
        Role = "User",
        Phone = "+90-555-000-0031",
        NickName = "UserTwentyFour"
    },
    new User
    {
        Id = 32,
        UserName = "user25",
        Email = "user25@example.com",
        Password = "user25_password",
        Role = "User",
        Phone = "+90-555-000-0032",
        NickName = "UserTwentyFive"
    },
    new User
    {
        Id = 33,
        UserName = "user26",
        Email = "user26@example.com",
        Password = "user26_password",
        Role = "User",
        Phone = "+90-555-000-0033",
        NickName = "UserTwentySix"
    },
    new User
    {
        Id = 34,
        UserName = "user27",
        Email = "user27@example.com",
        Password = "user27_password",
        Role = "User",
        Phone = "+90-555-000-0034",
        NickName = "UserTwentySeven"
    },
    new User
    {
        Id = 35,
        UserName = "user28",
        Email = "user28@example.com",
        Password = "user28_password",
        Role = "User",
        Phone = "+90-555-000-0035",
        NickName = "UserTwentyEight"
    },
    new User
    {
        Id = 36,
        UserName = "user29",
        Email = "user29@example.com",
        Password = "user29_password",
        Role = "User",
        Phone = "+90-555-000-0036",
        NickName = "UserTwentyNine"
    },
    new User
    {
        Id = 37,
        UserName = "user30",
        Email = "user30@example.com",
        Password = "user30_password",
        Role = "User",
        Phone = "+90-555-000-0037",
        NickName = "UserThirty"
    }
);




        }
    }
}
