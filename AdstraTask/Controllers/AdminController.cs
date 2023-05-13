using AdstraTask.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace AdstraTask.Controllers
{
    public class AdminController : Controller
    {

       
        UserManager<IdentityUser> _userManager;
       
        

        public AdminController( UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

       

   
        public ActionResult Index()
        {
            return View();
        }

 
        public IActionResult ShowUsersInfo()
        {
            var users = _userManager.Users.ToList();   
            return View(users);
        }

    }
}
