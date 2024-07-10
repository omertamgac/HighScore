using HightScore.Entities.EntityConfig.Abstract;
using HightScore.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HightScore.Entities.EntityConfig.Concrete
{
    public class AdminActionConfig : BaseConfig<AdminAction>
    {
        public override void Configure(EntityTypeBuilder<AdminAction> builder)
        {
            base.Configure(builder);

            builder.Property(i => i.ActionType).IsRequired();
            builder.Property(i => i.AdminId).IsRequired();
            builder.Property(i => i.Description).IsRequired();


            builder.HasData(
    new AdminAction
    {
        Id = 1,
        AdminId = 1,
        ActionType = "User Management",
        Description = "Created new user roles."
    },
    new AdminAction
    {
        Id = 2,
        AdminId = 2,
        ActionType = "Content Management",
        Description = "Published new articles."
    },
    new AdminAction
    {
        Id = 3,
        AdminId = 3,
        ActionType = "System Maintenance",
        Description = "Performed database backup."
    },
    new AdminAction
    {
        Id = 4,
        AdminId = 1,
        ActionType = "User Management",
        Description = "Updated user permissions."
    },
    new AdminAction
    {
        Id = 5,
        AdminId = 2,
        ActionType = "Content Management",
        Description = "Reviewed and edited user-submitted content."
    }
);



        }

    }
}
