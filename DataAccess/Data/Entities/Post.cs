using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace DataAccess.Data.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string MediaLink { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public ICollection<User> Likes { get; set; }
        public ICollection<User> Saves { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public DateTime PostTime { get; set; }
    }
}
