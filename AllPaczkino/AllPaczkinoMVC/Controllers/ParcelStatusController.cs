using AllPaczkino.Models;
using AllPaczkino.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AllPaczkinoMVC.Controllers
{
    using AllPaczkino.Models;
    using AllPaczkino.Repositories;
    using Microsoft.AspNetCore.Mvc;

    namespace AllPaczkinoMVC.Controllers
    {
        public class ParcelStatusController : Controller
        {
            private readonly ParcelsRepository parcelRepository;

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

				return parcel == null ? NotFound() : View(parcel);

                //if (id.HasValue)
                //{
                //    // If ID has a value, use it as ID
                //    var parcelData = parcelRepository.GetById(id.Value);
                //    return View(parcelData);
                //}
                //if (!string.IsNullOrEmpty(name))
                //{
                //    // If Name is not empty, treat it as a name
                //    var parcelData = parcelRepository.GetByName(name);
                //    return View(parcelData);
                //}
                //else if (!string.IsNullOrEmpty(name))
                //{
                //    // If Name is not empty, treat it as a name
                //    var parcelsWithSameName = parcelRepository.GetAllByName(name);
                //    return View(parcelsWithSameName);
                //}
                
                //{
                //    // Handle other cases or provide an error response
                //    return View();
                //}
            }

            
        }
    }
}

