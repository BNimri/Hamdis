using Hamdi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Diagnostics;

namespace Hamdi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HamdiDbContext _context;


        public HomeController(HamdiDbContext context, ILogger<HomeController> logger)
        {
            _logger = logger;
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult infoHead()
        {
            return View();
        }

        public IActionResult infoMembers()
        {
            return View();
        }

        public IActionResult infoMembersFounders()
        {
            return View();
        }

        public IActionResult servicesMembers()
        {
            return View();

        }

        public IActionResult signupForms()
        {
            return View();
        }

        [HttpPost]
        public IActionResult signupForms(personModel model)
        {
            int calcAge = CalculateAge(model.BirthDate);

            if (ModelState.IsValid)
            {
                _context.People.Add(model);
                _context.SaveChanges();
                return RedirectToAction("DisplayData");
            }

            return View(model);
        }

        public IActionResult DisplayData()
        {
            var people = _context.People.ToList();
            return View(people);
        }

        public IActionResult internalSystem()
        {
            return View();

        }

        public IActionResult contactUs()
        {
            return View();

        }

        private int CalculateAge(DateOnly birthDate)
        {
            DateTime currentDate = DateTime.Today;
            int age = currentDate.Year - birthDate.Year;

            if (currentDate.Month < birthDate.Month || (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
            {
                age--;
            }

            return age;
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