using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectInstagram.Data.Entities;

namespace ProjectInstagram.Data.Configurations
{
    public class PostCfg : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.AccountId).IsRequired();
            builder.Property(x => x.MediaLinks).IsRequired();
            builder.Property(x => x.PostTime).IsRequired();

            builder.HasData(new[]
            {
                new Post { 
                    Id = 1, 
                    MediaLinks = new List<string>
                    {
                        "https://i.pinimg.com/564x/56/8e/6f/568e6f0325a2388fd335b4557033e568.jpg"
                    },
                    Description = "ждав покі зупиняться",
                    Likes = 43,
                    PostTime = new DateTime(2023, 9, 8),
                    IsAdvertised = true,
                    AccountId = 1
                },
                new Post { 
                    Id = 2, 
                    MediaLinks = new List<string>
                    {
                        "https://i.pinimg.com/564x/76/e6/0d/76e60df836cb6b224f4134f964681af5.jpg"
                    },
                    Description = "",
                    Likes = 30,
                    PostTime = new DateTime(2023, 8, 18),
                    IsAdvertised = true,
                    AccountId = 1
                },
                new Post { 
                    Id = 3, 
                    MediaLinks = new List<string>
                    {
                        "https://i.pinimg.com/564x/50/7d/f3/507df3fa48c321a0aea520b3a76a0603.jpg"
                    },
                    Description = "",
                    Likes = 30,
                    PostTime = new DateTime(2023, 8, 18),
                    IsAdvertised = false,
                    AccountId = 1
                }
            });
        }
    }
}
