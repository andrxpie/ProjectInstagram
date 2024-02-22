using AutoMapper;
using BusinessLogic.Interfaces;
using DataAccess.Data;
using Microsoft.AspNetCore.Mvc;

namespace ProjectInstagram.Controllers
{
    public class AccountsController : Controller
    {
        private readonly IAccountService accountService;
        private readonly IMapper mapper;

        public AccountsController(IAccountService accountService, IMapper mapper)
        {
            this.accountService = accountService;
            this.mapper = mapper;
        }

        public IActionResult Index(int id)
        {
            return View(accountService.Get(id));
        }
    }
}
