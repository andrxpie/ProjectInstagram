using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class PostDto
    {
        public int Id { get; set; }
        public string MediaLink { get; set; }
        public string Description { get; set; }
        public int AccountId { get; set; }
        public AccountDto Account { get; set; }
        public ICollection<AccountDto> Likes { get; set; }
        public ICollection<AccountDto> Saves{ get; set; }
        public ICollection<CommentDto> Comments { get; set; }
        public DateTime PostTime { get; set; }
    }
}
