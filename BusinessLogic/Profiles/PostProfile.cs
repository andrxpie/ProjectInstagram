using AutoMapper;
using BusinessLogic.DTOs;
using DataAccess.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Profiles
{
    public class PostProfile : Profile
    {
        public PostProfile()
        {
            CreateMap<UserDto, User>()
                .ForMember(x => x.Subscribers, opt => opt.Ignore())
                .ForMember(x => x.Subscribes, opt => opt.Ignore())
                .ForMember(x => x.Posts, opt => opt.Ignore())
                .ForMember(x => x.LikedPosts, opt => opt.Ignore())
                .ForMember(x => x.SavedPosts, opt => opt.Ignore())
                .ForMember(x => x.Comments, opt => opt.Ignore());

            CreateMap<User, UserDto>().ReverseMap();

            CreateMap<CommentDto, Comment>()
                .ForMember(x => x.User, opt => opt.Ignore())
                .ForMember(x => x.Post, opt => opt.Ignore());

            CreateMap<Comment, CommentDto>().ReverseMap();

            CreateMap<PostDto, Post>()
                .ForMember(x => x.Comments, opt => opt.Ignore())
                .ForMember(x => x.User, opt => opt.Ignore());

            CreateMap<Post, PostDto>().ReverseMap();
        }
    }
}
