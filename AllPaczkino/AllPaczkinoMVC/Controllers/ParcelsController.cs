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

        // GET: ParcelsControler
        public ActionResult Index(string sortOrder, string searchString)
        {
            //ViewBag.NameSortParam = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "name";
            ViewBag.IdSortParam = sortOrder == "id" ? "id_desc" : "";
            ViewBag.SendTimeSortParam = sortOrder == "SendTime" ? "sendTimeDesc" : "sendTime";

            List<Parcel> parcelsData = parcelRepository.GetAll();
            if (!String.IsNullOrEmpty(searchString))
            {
                parcelsData = parcelsData.Where(s => s.Name.Contains(searchString)).ToList();
            }
            switch (sortOrder)
            {
                case "name_desc":
                    parcelsData = parcelsData.OrderByDescending(s => s.Name).ToList();
                    break;
                case "id_desc":
                    parcelsData = parcelsData.OrderByDescending(s => s.ID).ToList();
                    break;
                case "name":
                    parcelsData = parcelsData.OrderBy(s => s.Name).ToList();
                    break;
                case "sendTimeDesc":
                    parcelsData = parcelsData.OrderByDescending(s => s.SendTime).ToList();
                    break;
                case "sendTime":
                    parcelsData = parcelsData.OrderBy(s => s.SendTime).ToList();
                    break;
                default:
                    sortOrder = "name";
                    parcelsData = parcelsData.OrderBy(s => s.ID).ToList();
                    break;
            }
            ViewBag.NameSortParam = sortOrder;
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
        public ActionResult Edit(int id, Parcel editedParcel)
        {
            try
            {
                parcelRepository.Update(id, editedParcel);
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
