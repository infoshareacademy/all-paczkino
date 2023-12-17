using AllPaczkino.Models;
using AllPaczkino.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AllPaczkinoMVC.Controllers
{
    public class ParcelStatusController : Controller
    {
        ParcelsRepository parcelRepository = new();
        List<Parcel> parcelsData;

        // GET: ParcelsControler
        public ActionResult Index()
        {
            parcelsData = parcelRepository.GetAll();

            return View(parcelsData);
        }
        // GET: ParcelStatusController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ParcelStatusController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ParcelStatusController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: ParcelStatusController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ParcelStatusController/Edit/5
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

        // GET: ParcelStatusController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ParcelStatusController/Delete/5
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
