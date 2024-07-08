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

        }

    }
}
