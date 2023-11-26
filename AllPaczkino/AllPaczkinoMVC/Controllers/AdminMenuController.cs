using Microsoft.AspNetCore.Mvc;

namespace AllPaczkinoMVC.Controllers
{
    public class AdminMenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
