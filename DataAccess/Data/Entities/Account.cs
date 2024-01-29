namespace ProjectInstagram.Data.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string AvatartLink { get; set; }
        public string Bio { get; set; }
        public List<Story> SavedStories { get; set; }
        public List<Account> Subscribers { get; set; }
        public List<Account> Subscribes { get; set; }
        public List<Post> Posts { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
