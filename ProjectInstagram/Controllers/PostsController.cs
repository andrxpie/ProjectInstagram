using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
using DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace ProjectInstagram.Controllers
{
    public class PostsController : Controller
    {
        private readonly IPostsService postService;
        private readonly IMapper mapper;

        public PostsController(IPostsService postService, IMapper mapper)
        {
            this.postService = postService;
            this.mapper = mapper;
        }

        public IActionResult Details(int id)
        {
            return View(postService.Get(id));
        }
    }
}
