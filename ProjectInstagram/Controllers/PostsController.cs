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
        private readonly ICommentsService commentService;
        private readonly IPostsService postService;
        private readonly IMapper mapper;

        public PostsController(IPostsService postService, ICommentsService commentService, IMapper mapper)
        {
            this.postService = postService;
            this.commentService = commentService;
            this.mapper = mapper;
        }

        public IActionResult Details(int id)
        {
            return View(postService.Get(id));
        }

        public IActionResult AddComment(string userId, int postId, [FromForm]string text)
        {
            commentService.Create(userId, postId, text);

            return RedirectToAction("Details", new { Id = postId });
        }

        public IActionResult RemoveComment(int id, int postId)
        {
            commentService.Delete(id);

            return RedirectToAction("Details", new { Id = postId });
        }
    }
}
