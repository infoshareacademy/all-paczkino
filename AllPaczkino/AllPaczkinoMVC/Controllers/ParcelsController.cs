using AllPaczkino.Models;
using AllPaczkino.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace AllPaczkinoMVC.Controllers
{
    public class ParcelsController : Controller
    {
        ParcelsRepository parcelRepository = new();
        List<Parcel> parcelsData ;

        // GET: ParcelsControler
        public ActionResult Index()
        {
            parcelsData = parcelRepository.GetAll();
            
            return View(parcelsData);
        }

        // GET: ParcelsControler/Details/5
        public ActionResult Details(int id)
        {
            var parcelData = parcelRepository.GetById(id);
            return View(parcelData);
        }

        // GET: ParcelsControler/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ParcelsControler/Create
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

        // GET: ParcelsControler/Edit/5
        public ActionResult Edit(int id)
        {
            var parcelDetails = parcelRepository.GetById(id);
            return View(parcelDetails);
        }

        // POST: ParcelsControler/Edit/5
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

        // GET: ParcelsControler/Delete/5
        public ActionResult Delete(int id)
        {
            var parcelToDelete = parcelRepository.GetById(id);
            return View(parcelToDelete);
        }

        // POST: ParcelsControler/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                parcelRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
