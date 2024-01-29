using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectInstagram.Data.Entities;

namespace ProjectInstagram.Data.Configurations
{
    public class AccountCfg : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Login).IsRequired();

            builder.HasMany(x => x.Posts).WithOne(x => x.Account).HasForeignKey(x => x.AccountId);
            builder.HasMany(x => x.SavedStories).WithOne(x => x.Account).HasForeignKey(x => x.AccountId);
            builder.HasMany(x => x.Subscribes).WithMany(x => x.Subscribers);
            builder.HasMany(x => x.Subscribers).WithMany(x => x.Subscribes);

            builder.HasData(new[]{
                new Account { 
                    Id = 1,
                    Login = "andrxpie",
                    AvatartLink = "https://i2-prod.mirror.co.uk/incoming/article11890336.ece/ALTERNATES/s1227b/Screen-Shot-2018-01-21-at-122505JPG.jpg",
                    Bio = "STEP student",
                    SavedStories = new List<Story>(),
                    Subscribers = new List<Account>(),
                    Subscribes = new List<Account>(),
                    Posts = new List<Post>() },
                new Account { 
                    Id = 2,
                    Login = "dgmnkk",
                    AvatartLink = "https://i2-prod.mirror.co.uk/incoming/article11890336.ece/ALTERNATES/s1227b/Screen-Shot-2018-01-21-at-122505JPG.jpg",
                    Bio = "University student",
                    SavedStories = new List<Story>(),
                    Subscribers = new List<Account>(),
                    Subscribes = new List<Account>(),
                    Posts = new List<Post>() }
            });
        }
    }
}
