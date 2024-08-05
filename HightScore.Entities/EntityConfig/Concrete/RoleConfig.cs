using HightScore.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HightScore.Entities.EntityConfig.Concrete
{
    public class RoleConfig : IEntityTypeConfiguration<Role>
    {


        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(
                new Role { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
                new Role { Id = "2", Name = "User", NormalizedName = "USER" }

            );
        }


    }



}
