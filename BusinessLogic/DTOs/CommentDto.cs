﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class CommentDto
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public string UserId { get; set; }
        public UserDto User { get; set; }
        public int PostId { get; set; }
        public PostDto Post { get; set; }
    }
}
