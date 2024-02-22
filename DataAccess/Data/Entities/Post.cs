using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace DataAccess.Data.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string MediaLink { get; set; }
        public string Description { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public ICollection<Account> Likes { get; set; }
        public ICollection<Account> Saves { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public DateTime PostTime { get; set; }
    }
}
