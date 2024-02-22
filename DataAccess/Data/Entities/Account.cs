namespace DataAccess.Data.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string AvatartLink { get; set; }
        public string Bio { get; set; }
        public ICollection<Account> Subscribers { get; set; }
        public ICollection<Account> Subscribes { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<Post> LikedPosts { get; set; }
        public ICollection<Post> SavedPosts { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
