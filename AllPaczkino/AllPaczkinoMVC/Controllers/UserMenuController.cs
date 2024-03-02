using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AllPaczkinoMVC.Controllers
{
    [Authorize(Roles = "User, Admin")]
    public class UserMenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
