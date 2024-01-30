using DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ProjectInstagram.Controllers
{
    public class PostsController : Controller
    {
        private readonly InstagramDbContext context;

        public PostsController(InstagramDbContext context)
        {
            this.context = context;
        }

        public IActionResult Details(int id)
        {
            var checkIsNull = context.Posts.Find(id);

            if (checkIsNull == null) return NotFound();

            var post = context.Posts.Where(x => x.Id == id).Include(x => x.Account).Include(x => x.Comments).First();

            return View(post);
        }
    }
}
