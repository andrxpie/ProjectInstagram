using Microsoft.EntityFrameworkCore;
using DataAccess.Data.Configurations;
using DataAccess.Data.Entities;

namespace DataAccess.Data
{
    public class InstagramDbContext : DbContext
    {
        public InstagramDbContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var str = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataAccess;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            optionsBuilder.UseSqlServer(str);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new AccountCfg());
            modelBuilder.ApplyConfiguration(new PostCfg());
            modelBuilder.ApplyConfiguration(new StoryCfg());
            modelBuilder.ApplyConfiguration(new HashtagCfg());
            modelBuilder.ApplyConfiguration(new CommentCfg());
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Story> Stories { get; set; }
        public DbSet<Hashtag> Hashtags { get; set; }
    }
}
