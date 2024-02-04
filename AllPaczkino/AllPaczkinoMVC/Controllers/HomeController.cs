using AllPaczkino.Models;
using AllPaczkinoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using AllPaczkino.View;
using AllPaczkino.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;
using AllPaczkinoLogic.Repositories;
using Newtonsoft.Json;

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
            // Read JSON data from the file
            string json = System.IO.File.ReadAllText("DAL/parcellockers.json");

            // Deserialize JSON data into ParcelLockerData
            ParcelLockerList parcelLockerList = JsonConvert.DeserializeObject<ParcelLockerList>(json);
            // Create a new list with only the "city" parameter
            List<string> cities = parcelLockerList?.parcel_lockers?.Select(x => x.city).Distinct().OrderBy(x=>x).ToList();

            var viewModel = new ParcelLockerViewModel
            {
                Cities = new SelectList(cities),
                ParcelLockersInSelectedCity = new SelectList(new List<string>()) // Initialize with an empty list
            };

            return View(viewModel);
        }

        public JsonResult GetParcelLockersInSelectedCity(string city)
        {
            // Read JSON data from the file
            string json = System.IO.File.ReadAllText("DAL/parcellockers.json");

            // Deserialize JSON data into ParcelLockerData
            ParcelLockerList parcelLockerList = JsonConvert.DeserializeObject<ParcelLockerList>(json);

            // Assuming parcelLockerData is the instance of ParcelLockerList and viewModel is the instance of ParcelLockerViewModel
            List<ParcelLocker> parcelLockersInSelectedCity = parcelLockerList?.parcel_lockers?.Where(x => x.city == city).ToList();

            return Json(parcelLockersInSelectedCity);
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