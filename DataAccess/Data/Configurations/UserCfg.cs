using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Data.Entities;
using System.Reflection.Emit;

namespace DataAccess.Data.Configurations
{
    public class UserCfg : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasMany(x => x.Posts).WithOne(x => x.User).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(x => x.Comments).WithOne(x => x.User).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(x => x.Subscribes).WithMany(x => x.Subscribers);
            builder.HasMany(x => x.Subscribers).WithMany(x => x.Subscribes);

            builder.HasMany(x => x.LikedPosts)
                .WithMany(x => x.Likes)
                .UsingEntity<Dictionary<string, object>>(
                    "UserPost",
                    j => j
                        .HasOne<Post>()
                        .WithMany()
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.NoAction),
                    j => j
                        .HasOne<User>()
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction));

            builder.HasMany(x => x.SavedPosts)
                .WithMany(x => x.Saves)
                .UsingEntity<Dictionary<string, object>>(
                    "UserPost",
                    j => j
                        .HasOne<Post>()
                        .WithMany()
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.NoAction),
                    j => j
                        .HasOne<User>()
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction));

            builder.HasData(new[]{
                new User { 
                    Id = "1",
                    UserName = "andrxpie",
                    AvatartLink = "/avatars/photo_2023-12-05_20-40-36.jpg",
                    Bio = "ILoveLeopard2A8",
                    Subscribers = new List<User>(),
                    Subscribes = new List<User>(),
                    Posts = new List<Post>(),
                    LikedPosts = new List<Post>(),
                    SavedPosts = new List<Post>() },
                new User { 
                    Id = "2",
                    UserName = "noshkalyuk",
                    AvatartLink = "/avatars/408538791_661498132822961_4968475449854852744_n.jpg",
                    Bio = "Student of RPC NULESU",
                    Subscribers = new List<User>(),
                    Subscribes = new List<User>(),
                    Posts = new List<Post>(),
                    LikedPosts = new List<Post>(),
                    SavedPosts = new List<Post>() }
            });
        }
    }
}
