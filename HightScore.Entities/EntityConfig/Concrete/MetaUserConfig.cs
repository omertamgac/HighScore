using HightScore.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HightScore.Entities.EntityConfig.Concrete
{
    public class MetaUserConfig : IEntityTypeConfiguration<MetaUser>
    {
        public void Configure(EntityTypeBuilder<MetaUser> builder)
        {

        }
    }
}
