using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Data.Entities;

namespace DataAccess.Data.Configurations
{
    public class CommentCfg : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Text).IsRequired();
            builder.Property(x => x.Text).IsRequired();
            builder.Property(x => x.AccountId).IsRequired(false);
            builder.Property(x => x.PostId).IsRequired();

            builder.HasData(new[]
            {
                new Comment { Id = 1, Text = "Superoffo", AccountId = 1, PostId = 1, Date = new DateTime(2024, 2, 1) },
                new Comment { Id = 2, Text = "Poganoffo", AccountId = 1, PostId = 1, Date = new DateTime(2024, 1, 15) },
                new Comment { Id = 3, Text = "Positiffno", AccountId = 2, PostId = 1, Date = new DateTime(2024, 4, 29) },
                new Comment { Id = 4, Text = "Negatiffno", AccountId = 2, PostId = 1, Date = new DateTime(2024, 6, 12) }
            });
        }
    }
}
