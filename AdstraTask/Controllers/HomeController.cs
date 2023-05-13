using AdstraTask.Data;
using AdstraTask.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AdstraTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
         UserManager<IdentityUser> _userManager;
        RoleManager<IdentityRole> _roleManager;
        ApplicationDbContext _identity;

        public HomeController(ILogger<HomeController> logger , UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager, ApplicationDbContext identity)
        {
            _logger = logger;
            _userManager = userManager;
            _roleManager = roleManager;
            _roleManager = roleManager;
            _identity = identity;

        }

        public IActionResult Index()
        {
            //if (_identity.Roles.FirstOrDefault(x => x.Name == "Admin") == null)
            //{
            //    _identity.Roles.Add(new IdentityRole { Name = "Admin", NormalizedName = "Admin" });
            //    _identity.SaveChanges();
            //}

            //if (_identity.Roles.FirstOrDefault(x => x.Name == "User") == null)
            //{
            //    _identity.Roles.Add(new IdentityRole { Name = "User", NormalizedName = "User" });
            //    _identity.SaveChanges();
            //}



            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        public IActionResult ShowUsersInfo()
        {
            var users = _userManager.Users.ToList();
            return View(users);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}