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
        public List<string> MediaLinks { get; set; }
        public string Description { get; set; }
        public int Likes { get; set; }
        public List<CommentDto> Comments { get; set; }
        public DateTime PostTime { get; set; }
        public bool IsAdvertised { get; set; }
        public int AccountId { get; set; }
        public AccountDto Account { get; set; }
    }
}
