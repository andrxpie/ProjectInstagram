﻿using AutoMapper;
using BusinessLogic.DTOs;
using DataAccess.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Profiles
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            CreateMap<AccountDto, Account>()
                .ForMember(x => x.SavedStories, opt => opt.Ignore())
                .ForMember(x => x.Subscribers, opt => opt.Ignore())
                .ForMember(x => x.Subscribes, opt => opt.Ignore())
                .ForMember(x => x.Posts, opt => opt.Ignore())
                .ForMember(x => x.Comments, opt => opt.Ignore());

            CreateMap<Account, AccountDto>();

            CreateMap<CommentDto, Comment>()
                .ForMember(x => x.Account, opt => opt.Ignore())
                .ForMember(x => x.Post, opt => opt.Ignore());

            CreateMap<Comment, CommentDto>();

            CreateMap<HashtagDto, Hashtag>()
                .ForMember(x => x.Posts, opt => opt.Ignore());

            CreateMap<Hashtag, HashtagDto>();

            CreateMap<PostDto, Post>()
                .ForMember(x => x.Comments, opt => opt.Ignore())
                .ForMember(x => x.Account, opt => opt.Ignore())
                .ForMember(x => x.Hashtags, opt => opt.Ignore());

            CreateMap<Post, PostDto>();

            CreateMap<StoryDto, Story>()
                .ForMember(x => x.Account, opt => opt.Ignore());

            CreateMap<Story, StoryDto>();
        }
    }
}
