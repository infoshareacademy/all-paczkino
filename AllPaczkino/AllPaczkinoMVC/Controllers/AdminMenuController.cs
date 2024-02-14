using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AllPaczkinoMVC.Controllers
{
    [Authorize]
    public class AdminMenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
