using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
using DataAccess.Data;
using DataAccess.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class UsersService : IUsersService
    {
        private readonly IMapper mapper;
        private readonly InstagramDbContext context;

        public UsersService(IMapper mapper, InstagramDbContext context)
        {
            this.mapper = mapper;
            this.context = context;
        }

        public void Create(UserDto user)
        {
            context.Users.Add(mapper.Map<User>(user));
            context.SaveChanges();
        }

        public void Delete(string id)
        {
            var user = context.Users.Find(id);


            if(user == null) return;

            context.Users.Remove(user);
            context.SaveChanges();
        }

        public UserDto? Get(string id)
        {
            var user = context.Users.Find(id);
            if(user == null) return null;

            context.Entry(user).Collection(x => x.Subscribers).Load();
            context.Entry(user).Collection(x => x.Subscribes).Load();
            context.Entry(user).Collection(x => x.Posts).Load();
            context.Entry(user).Collection(x => x.LikedPosts).Load();
            context.Entry(user).Collection(x => x.SavedPosts).Load();
            context.Entry(user).Collection(x => x.Comments).Load();
            
            var dto = mapper.Map<UserDto>(user);

            return dto;
        }

        public IEnumerable<UserDto> GetAll()
        {
            return mapper.Map<List<UserDto>>(context.Users
                .Include(x => x.Subscribers)
                .Include(x => x.Subscribes)
                .Include(x => x.Posts)
                .Include(x => x.LikedPosts)
                .Include(x => x.SavedPosts)
                .Include(x => x.Comments)
                .ToList());
        }

        public void Update(UserDto user)
        {
            context.Users.Update(mapper.Map<User>(user));
            context.SaveChanges();
        }
    }
}
