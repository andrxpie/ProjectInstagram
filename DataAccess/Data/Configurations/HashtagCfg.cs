using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectInstagram.Data.Entities;

namespace ProjectInstagram.Data.Configurations
{
    public class HashtagCfg : IEntityTypeConfiguration<Hashtag>
    {
        public void Configure(EntityTypeBuilder<Hashtag> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.HasMany(x => x.Posts).WithMany(x => x.Hashtags);

            builder.HasData(new[]
            {
                new Hashtag { Id = 1, Name = "#ukraine" },
                new Hashtag { Id = 2, Name = "#war" },
                new Hashtag { Id = 3, Name = "#gym" },
                new Hashtag { Id = 4, Name = "#usa" },
                new Hashtag { Id = 5, Name = "#train" },
                new Hashtag { Id = 6, Name = "#nowadays" },
                new Hashtag { Id = 7, Name = "#news" },
                new Hashtag { Id = 8, Name = "#it" },
                new Hashtag { Id = 9, Name = "#programm" },
            });
        }
    }
}
