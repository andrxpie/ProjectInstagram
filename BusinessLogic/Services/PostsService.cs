using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
using DataAccess.Data;
using DataAccess.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class PostsService : IPostsService
    {
        private readonly IMapper mapper;
        private readonly InstagramDbContext context;

        public PostsService(IMapper mapper, InstagramDbContext context)
        {
            this.mapper = mapper;
            this.context = context;
        }

        public void Create(PostDto post)
        {
            context.Posts.Add(mapper.Map<Post>(post));
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var post = context.Posts.Find(id);

            if (post == null) return;

            context.Remove(post);
            context.SaveChanges();
        }

        public PostDto? Get(int id)
        {
            var post = context.Posts.Find(id);
            if (post == null) return null;

            context.Entry(post).Reference(x => x.Account).Load();
            context.Entry(post).Collection(x => x.Comments).Query().Include(x => x.Account).Load();

            var dto = mapper.Map<PostDto>(post);

            return dto;
        }

        public IEnumerable<PostDto> GetAll()
        {
            return mapper.Map<List<PostDto>>(context.Posts
                .Include(x => x.Account)
                .Include(x => x.Comments)
                .ThenInclude(x => x.Account)
                .ToList());
        }

        public void Update(PostDto post)
        {
            context.Posts.Update(mapper.Map<Post>(post));
            context.SaveChanges();
        }
    }
}
