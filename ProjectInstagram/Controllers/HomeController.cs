using DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using ProjectInstagram.Models;
using System.Diagnostics;

namespace ProjectInstagram.Controllers
{
    public class HomeController : Controller
    {
        private readonly InstagramDbContext context;

        public HomeController(InstagramDbContext context)
        {
            this.context = context;
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
            return View(this.context.Posts.ToList());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
