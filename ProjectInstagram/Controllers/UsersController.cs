using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
using DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ProjectInstagram.Controllers
{
    public class UsersController : Controller
    {
        private readonly InstagramDbContext context;
        private readonly IUsersService userService;
        private readonly IMapper mapper;

        public UsersController(InstagramDbContext context, IUsersService userService, IMapper mapper)
        {
            this.context = context;
            this.userService = userService;
            this.mapper = mapper;
        }

        public IActionResult Profile(string id)
        {
            return View(userService.Get(id));
        }
    }
}
