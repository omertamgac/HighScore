using HightScore.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HightScore.Entities.EntityConfig.Concrete
{
    public class MetaUserConfig : IEntityTypeConfiguration<MetaUser>
    {
        public void Configure(EntityTypeBuilder<MetaUser> builder)
        {





            builder.HasData(
                new MetaUser
                {
                    Id = new Guid().ToString(),
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    Email = "admin@example.com",
                    NormalizedEmail = "ADMIN@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = "AQAAAAEAACcQAAAAEFj6FZQ6ew2o4PjB5HbjZc2P6A0EHkD3OXizZrj0LxG8B8el1omRZcU/lY8qdJWpWw==", // Example hashed password
                    SecurityStamp = "JZTQQKJ3CQCXYN4AWFLARBLI4NXY2FYW",
                    ConcurrencyStamp = "d4a7ff6f-2000-44ea-8b82-9c191c2f87c1"
                }

            );
        }
    }
}
