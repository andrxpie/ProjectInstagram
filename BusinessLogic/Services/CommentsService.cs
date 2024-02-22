using AutoMapper;
using BusinessLogic.DTOs;
using DataAccess.Data.Entities;
using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BusinessLogic.Interfaces;

namespace BusinessLogic.Services
{
    internal class CommentsService : ICommentsService
    {
        private readonly IMapper mapper;
        private readonly InstagramDbContext context;

        public CommentsService(IMapper mapper, InstagramDbContext context)
        {
            this.mapper = mapper;
            this.context = context;
        }

        public void Create(int id, string text)
        {
            var comment = new Comment { AccountId = 1, Date = DateTime.Now, PostId = id, Text = text };

            context.Comments.Add(comment);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var comment = context.Comments.Find(id);

            if (comment == null) return;

            context.Remove(comment);
            context.SaveChanges();
        }

        public CommentDto? Get(int id)
        {
            var comment = context.Comments.Find(id);
            if (comment == null) return null;

            context.Entry(comment).Reference(x => x.Account).Load();
            context.Entry(comment).Reference(x => x.Post).Load();

            var dto = mapper.Map<CommentDto>(comment);

            return dto;
        }

        public IEnumerable<CommentDto> GetAll()
        {
            var comment = context.Comments.Include(x => x.Account).Include(x => x.Post);

            return mapper.Map<List<CommentDto>>(comment);
        }

        public void Update(CommentDto comment)
        {
            context.Comments.Update(mapper.Map<Comment>(comment));
            context.SaveChanges();
        }
    }
}
