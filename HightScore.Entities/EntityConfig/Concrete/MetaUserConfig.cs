using HighScore.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HighScore.Entities.EntityConfig.Concrete
{
    public class MetaUserConfig : IEntityTypeConfiguration<MetaUser>
    {
        public void Configure(EntityTypeBuilder<MetaUser> builder)
        {

        }
    }
}
