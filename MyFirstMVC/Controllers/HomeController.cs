using Microsoft.AspNetCore.Mvc;
using MyFirstMVC.Models;
using Services;
using System.Diagnostics;

namespace MyFirstMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ICoolLists service = null;

        public HomeController(ILogger<HomeController> logger, ICoolLists service)
        {
            _logger = logger;
            this.service = service; 
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MyPage()
        {
            ViewData["Title"] = "Quan's Page";

            var vm = new vmMyPage();
            vm.Latin = service.LatinSentences.Take(5).ToList();
            return View("MyPage", vm);
        }

        [HttpGet]
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
