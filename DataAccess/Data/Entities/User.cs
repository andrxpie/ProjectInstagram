using Microsoft.AspNetCore.Identity;

namespace DataAccess.Data.Entities
{
    public class User : IdentityUser
    {
        public string AvatartLink { get; set; }
        public string Bio { get; set; }
        public ICollection<User> Subscribers { get; set; }
        public ICollection<User> Subscribes { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<Post> LikedPosts { get; set; }
        public ICollection<Post> SavedPosts { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
