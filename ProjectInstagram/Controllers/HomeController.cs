using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
using DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectInstagram.Models;
using System.Diagnostics;

namespace ProjectInstagram.Controllers
{
    public class HomeController : Controller
    {
        private readonly InstagramDbContext context;
        private readonly IPostsService postsService;
        private readonly IMapper mapper;

        public HomeController(InstagramDbContext context, IPostsService postsService, IMapper mapper)
        {
            this.context = context;
            this.postsService = postsService;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RemovePost(int id)
        {
            postsService.Delete(id);

            return RedirectToAction("PostList");
        }

        public IActionResult PostList()
        {
            var rawPosts = context.Posts.Include(x => x.Account).Include(x => x.Comments).ToList();
            var posts = mapper.Map<List<PostDto>>(rawPosts);

            return View(posts);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
