using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Data.Entities;

namespace DataAccess.Data.Configurations
{
    public class PostCfg : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.MediaLink).IsRequired();
            builder.Property(x => x.PostTime).IsRequired();

            builder.HasMany(x => x.Comments).WithOne(x => x.Post).HasForeignKey(x => x.PostId).OnDelete(DeleteBehavior.NoAction);

            builder.HasData(new[]
            {
                new Post { 
                    Id = 1, 
                    MediaLink = "/posts/photo_2024-01-25_00-09-45.jpg",
                    Description = "ждав покі зупиняться",
                    Likes = new List<User>(),
                    PostTime = new DateTime(2023, 9, 8),
                    UserId = "1"
                },
                new Post { 
                    Id = 2, 
                    MediaLink = "/posts/340656768_598090112368658_7050585686128996291_n.jpg",
                    Description = "college",
                    Likes = new List<User>(),
                    PostTime = new DateTime(2023, 8, 18),
                    UserId = "2"
                },
                new Post { 
                    Id = 3, 
                    MediaLink = "/posts/366512302_125839730594002_8033459135314310563_n.jpg",
                    Description = "not college",
                    Likes = new List<User>(),
                    PostTime = new DateTime(2023, 8, 18),
                    UserId = "2"
                },
                new Post { 
                    Id = 4, 
                    MediaLink = "/posts/387268421_221214574082002_7262488253037406921_n.jpg",
                    Description = "ждав покі зупиняться",
                    Likes = new List<User>(),
                    PostTime = new DateTime(2023, 9, 8),
                    UserId = "1"
                },
            });
        }
    }
}
