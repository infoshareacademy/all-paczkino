using AllPaczkino.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AllPaczkinoMVC.Controllers
{
    [Authorize(Roles = "User, Admin")]

    public class ParcelStatusController : Controller
    {
        ParcelsRepository parcelRepository = new();

        public ParcelStatusController()
        {
            parcelRepository = new ParcelsRepository();

        }

        // GET: ParcelStatus
        public IActionResult Index()
        {
            return View();
        }

        // POST: ParcelStatus/Details
        [HttpPost]
        public ActionResult Details(string nameOrId)
        {

            var parcel = parcelRepository.GetByName(nameOrId);

            if (parcel == null && int.TryParse(nameOrId, out var parsedId))
                parcel = parcelRepository.GetById(parsedId);
            if (User.IsInRole("Admin"))
            {
                return View(parcel);
            }
            if (parcel != null &&(parcel.Sender.ContactData.Email == User.Identity.Name || parcel.Receiver.ContactData.Email == User.Identity.Name))
            {
                return View(parcel);
            }
            return View();

        }
    }
}


