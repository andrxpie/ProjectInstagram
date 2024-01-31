using AutoMapper;
using DataAccess.Data;
using Microsoft.AspNetCore.Mvc;

namespace ProjectInstagram.Controllers
{
    public class AccountsController : Controller
    {
        private readonly InstagramDbContext context;
        private readonly IMapper mapper;

        public AccountsController(InstagramDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
