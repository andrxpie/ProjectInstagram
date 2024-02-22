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
    public class AccountsService : IAccountService
    {
        private readonly IMapper mapper;
        private readonly InstagramDbContext context;

        public AccountsService(IMapper mapper, InstagramDbContext context)
        {
            this.mapper = mapper;
            this.context = context;
        }

        public void Create(AccountDto account)
        {
            context.Accounts.Add(mapper.Map<Account>(account));
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var account = context.Accounts.Find(id);


            if(account == null) return;

            context.Accounts.Remove(account);
            context.SaveChanges();
        }

        public AccountDto? Get(int id)
        {
            var account = context.Accounts.Find(id);
            if(account == null) return null;

            context.Entry(account).Collection(x => x.Subscribers).Load();
            context.Entry(account).Collection(x => x.Subscribes).Load();
            context.Entry(account).Collection(x => x.Posts).Load();
            context.Entry(account).Collection(x => x.LikedPosts).Load();
            context.Entry(account).Collection(x => x.SavedPosts).Load();
            context.Entry(account).Collection(x => x.Comments).Load();
            
            var dto = mapper.Map<AccountDto>(account);

            return dto;
        }

        public IEnumerable<AccountDto> GetAll()
        {
            return mapper.Map<List<AccountDto>>(context.Accounts
                .Include(x => x.Subscribers)
                .Include(x => x.Subscribes)
                .Include(x => x.Posts)
                .Include(x => x.LikedPosts)
                .Include(x => x.SavedPosts)
                .Include(x => x.Comments)
                .ToList());
        }

        public void Update(AccountDto account)
        {
            context.Accounts.Update(mapper.Map<Account>(account));
            context.SaveChanges();
        }
    }
}
