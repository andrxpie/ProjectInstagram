﻿using Microsoft.Identity.Client;

namespace DataAccess.Data.Entities
{
    public class Hashtag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Likes { get; set; }
        public List<Post> Posts { get; set; }
    }
}
