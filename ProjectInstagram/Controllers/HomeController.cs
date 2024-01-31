using AutoMapper;
using BusinessLogic.DTOs;
using DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using ProjectInstagram.Models;
using System.Diagnostics;

namespace ProjectInstagram.Controllers
{
    public class HomeController : Controller
    {
        private readonly InstagramDbContext context;
        private readonly IMapper mapper;

        public HomeController(InstagramDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Adverts()
        {
            var adverts = mapper.Map<List<PostDto>>(context.Posts.ToList());

            return View(adverts);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
