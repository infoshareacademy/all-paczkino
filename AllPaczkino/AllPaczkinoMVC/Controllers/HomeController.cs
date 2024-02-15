using AllPaczkino.Models;
using AllPaczkinoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using AllPaczkino.View;
using AllPaczkino.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;
using AllPaczkinoLogic.Repositories;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;

namespace AllPaczkinoMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

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