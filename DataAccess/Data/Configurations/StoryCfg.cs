using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectInstagram.Data.Entities;

namespace ProjectInstagram.Data.Configurations
{
    public class StoryCfg : IEntityTypeConfiguration<Story>
    {
        public void Configure(EntityTypeBuilder<Story> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.MediaLink).IsRequired();
            
        }
    }
}
