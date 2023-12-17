using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AllPaczkinoMVC.Controllers
{
    public class ParcelStatusContoller : Controller
    {
        // GET: ParcelStatus
        public IActionResult Index()
        {
            return View();
        }
    }
}
