using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
using DataAccess.Data;
using DataAccess.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace ProjectInstagram.Controllers
{
    [Authorize]
    public class UsersController : Controller
    {
        private readonly InstagramDbContext context;
        private readonly IUsersService userService;
        private readonly IMapper mapper;
        private string? activeUserId => User.FindFirstValue(ClaimTypes.NameIdentifier);
        private UserDto activeUser;

        public UsersController(InstagramDbContext context, IUsersService userService, IMapper mapper)
        {
            this.context = context;
            this.userService = userService;
            this.mapper = mapper;
            activeUser = userService.Get(activeUserId);
        }

        public IActionResult Profile(string id)
        {
            ViewBag.Active = activeUser;
            return View(userService.Get(id));
        }

        public IActionResult ToggleSubscribe(string profileId)
        {
            if (activeUser.Subscribes.Contains(userService.Get(profileId)))
            {
                activeUser.Subscribes.Remove(userService.Get(profileId));
            }
            else
            {
                activeUser.Subscribes.Add(userService.Get(profileId));
            }

            context.SaveChanges();

            return View(userService.Get(profileId));
        }
    }
}
