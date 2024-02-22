using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Data.Entities;
using System.Reflection.Emit;

namespace DataAccess.Data.Configurations
{
    public class AccountCfg : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Login).IsRequired();

            builder.HasMany(x => x.Posts).WithOne(x => x.Account).HasForeignKey(x => x.AccountId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(x => x.Comments).WithOne(x => x.Account).HasForeignKey(x => x.AccountId).OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(x => x.Subscribes).WithMany(x => x.Subscribers);
            builder.HasMany(x => x.Subscribers).WithMany(x => x.Subscribes);

            builder.HasMany(x => x.LikedPosts)
                .WithMany(x => x.Likes)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountPost",
                    j => j
                        .HasOne<Post>()
                        .WithMany()
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.NoAction),
                    j => j
                        .HasOne<Account>()
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.NoAction));

            builder.HasMany(x => x.SavedPosts)
                .WithMany(x => x.Saves)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountPost",
                    j => j
                        .HasOne<Post>()
                        .WithMany()
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.NoAction),
                    j => j
                        .HasOne<Account>()
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.NoAction));

            builder.HasData(new[]{
                new Account { 
                    Id = 1,
                    Login = "andrxpie",
                    AvatartLink = "/avatars/photo_2023-12-05_20-40-36.jpg",
                    Bio = "STEP student",
                    Subscribers = new List<Account>(),
                    Subscribes = new List<Account>(),
                    Posts = new List<Post>(),
                    LikedPosts = new List<Post>(),
                    SavedPosts = new List<Post>() },
                new Account { 
                    Id = 2,
                    Login = "noshkalyuk",
                    AvatartLink = "/avatars/408538791_661498132822961_4968475449854852744_n.jpg",
                    Bio = "Student of RPC NULESU",
                    Subscribers = new List<Account>(),
                    Subscribes = new List<Account>(),
                    Posts = new List<Post>(),
                    LikedPosts = new List<Post>(),
                    SavedPosts = new List<Post>() }
            });
        }
    }
}
