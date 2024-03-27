using AllPaczkino.Models;
using AllPaczkino.Repositories;
using AllPaczkinoLogic.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AllPaczkinoMVC.Controllers
{
    [Authorize]

    public class SendParcel : Controller
    {
        ParcelsRepository parcelRepository = new();
        List<Parcel> parcelsData;

		ParcelLockersRepository parcelLockersRepository = new();
        List<ParcelLocker> parcelLockersData;

		// GET: SendParcelControler
		public ActionResult Index()
        {
			return View();
		}

        // GET: SendParcel/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SendParcel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SendParcel/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Parcel parcel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(parcel);
                }
                parcelRepository.Create(parcel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SendParcel/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SendParcel/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SendParcel/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SendParcel/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

	}
}
