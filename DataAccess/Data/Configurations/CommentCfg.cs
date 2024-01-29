using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectInstagram.Data.Entities;

namespace ProjectInstagram.Data.Configurations
{
    public class CommentCfg : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Text).IsRequired();
            builder.Property(x => x.Text).IsRequired();
            builder.Property(x => x.AccountId).IsRequired();
            builder.Property(x => x.PostId).IsRequired();

            builder.HasOne(x => x.Account).WithMany(x => x.Comments).HasForeignKey(x => x.AccountId);
            builder.HasOne(x => x.Post).WithMany(x => x.Comments).HasForeignKey(x => x.PostId).OnDelete(DeleteBehavior.NoAction);

            builder.HasData(new[]
            {
                new Comment { Id = 1, Text = "Superoffo", AccountId = 1, PostId = 1 },
                new Comment { Id = 2, Text = "Poganoffo", AccountId = 1, PostId = 1 },
                new Comment { Id = 3, Text = "Positiffno", AccountId = 2, PostId = 1 },
                new Comment { Id = 4, Text = "Negatiffno", AccountId = 2, PostId = 1 }
            });
        }
    }
}
