using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace ProjectInstagram.Data.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public List<string> MediaLinks { get; set; }
        public string Description { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; }
        public DateTime PostTime { get; set; }
        public bool IsAdvertised { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public List<Hashtag> Hashtags { get; set; }
    }
}
