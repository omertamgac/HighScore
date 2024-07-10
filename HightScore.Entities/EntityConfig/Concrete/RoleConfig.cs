using HightScore.Entities.EntityConfig.Abstract;
using HightScore.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HightScore.Entities.EntityConfig.Concrete
{
    public class RoleConfig : BaseConfig<Role>
    {
        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            base.Configure(builder);

            builder.HasIndex(p => p.Roles).IsUnique();

            builder.HasData
                (
                    new Role { Id = 1, Roles = "Admin" },
                    new Role { Id = 2, Roles = "Editor" },
                    new Role { Id = 3, Roles = "User" }
                );

        }
    }
}
