using HightScore.Entities.EntityConfig.Abstract;
using HightScore.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HightScore.Entities.EntityConfig.Concrete
{
    public class UserRolesConfig : BaseConfig<UserRole>
    {
        public override void Configure(EntityTypeBuilder<UserRole> builder)
        {
            base.Configure(builder);

            builder.HasKey(ur => new { ur.UserId, ur.RoleId });

            builder
                .HasOne(ur => ur.user)
                .WithMany(u => u.UserRoles)
            .HasForeignKey(ur => ur.UserId);

            builder
                .HasOne(ur => ur.role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.RoleId);

            builder.HasData
        (
            new UserRole { Id = 1, UserId = 1, RoleId = 1 },
            new UserRole { Id = 2, UserId = 1, RoleId = 2 },
            new UserRole { Id = 3, UserId = 1, RoleId = 3 }
        );

        }

    }
}
