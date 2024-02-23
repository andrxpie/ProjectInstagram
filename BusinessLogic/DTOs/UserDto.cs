using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class UserDto
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string AvatartLink { get; set; }
        public string Bio { get; set; }
        public ICollection<UserDto> Subscribers { get; set; }
        public ICollection<UserDto> Subscribes { get; set; }
        public ICollection<PostDto> Posts { get; set; }
        public ICollection<PostDto> LikedPosts { get; set; }
        public ICollection<PostDto> SavedPosts { get; set; }
        public ICollection<CommentDto> Comments { get; set; }
    }
}
