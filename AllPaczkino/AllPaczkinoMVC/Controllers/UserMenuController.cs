using Microsoft.AspNetCore.Mvc;

namespace AllPaczkinoMVC.Controllers
{
    public class UserMenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
