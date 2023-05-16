using AdstraTask.Data;
using AdstraTask.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using AdstraTask.Models;

namespace AdstraTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            List<Contact> contactsList = _context.Contacts.ToList(); 
            List<ContactDto> contactsDto = new List<ContactDto>();

            foreach (var item in contactsList)
            {

                contactsDto.Add(Mapping.Mapper.Map<ContactDto>(item));
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}