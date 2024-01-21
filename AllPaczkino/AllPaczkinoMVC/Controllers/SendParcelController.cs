using AllPaczkino.Models;
using AllPaczkino.Repositories;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AllPaczkinoMVC.Controllers
{
    public class SendParcel : Controller
    {
        ParcelsRepository parcelRepository = new();
        List<Parcel> parcelsData;

        // GET: SendParcelControler
        public ActionResult Index()
        {
            parcelsData = parcelRepository.GetAll();

            return View(parcelsData);
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
