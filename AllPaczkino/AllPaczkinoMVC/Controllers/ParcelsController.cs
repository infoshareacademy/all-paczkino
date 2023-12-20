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
            //ViewBag.NameSortParam = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "name_desc";
            ViewBag.IdSortParam = sortOrder == "id" ? "id_desc" : "";
            ViewBag.SendTimeSortParam = sortOrder == "SendTime" ? "sendTimeDesc" : "";
            ViewBag.ParcelStatusParm = sortOrder == "ParcelStatus" ? "ParcelStatusDesc" : "";

            List<Parcel> parcelsData = parcelRepository.GetAll();
            if (!String.IsNullOrEmpty(searchString))
            {
                searchString = searchString.ToLower();
                parcelsData = parcelsData.Where(s => s.Name.ToLower().Contains(searchString) ||
                s.ID.ToString().Contains(searchString) ||
                s.ParcelNumber.ToString().Contains(searchString) ||
                s.ReceiveTime.ToString().Contains(searchString) ||
                s.SendTime.ToString().Contains(searchString) ||
                s.Sender.ContactData.Name.ToLower().Contains(searchString) ||
                s.Sender.ContactData.Email.ToLower().Contains(searchString) ||
                s.Sender.ContactData.PhoneNumber.Contains(searchString) ||
                s.SenderLocker.postal_code.Contains(searchString) ||
                s.SenderLocker.city.ToLower().Contains(searchString) ||
                s.SenderLocker.address.ToLower().Contains(searchString) ||
                s.Receiver.ContactData.Name.ToLower().Contains(searchString) ||
                s.Receiver.ContactData.Email.ToLower().Contains(searchString) ||
                s.Receiver.ContactData.PhoneNumber.Contains(searchString) ||
                s.ReceiverLocker.postal_code.Contains(searchString) ||
                s.ReceiverLocker.city.ToLower().Contains(searchString) ||
                s.ReceiverLocker.address.ToLower().Contains(searchString) ||
                s.ParcelSize.Name.ToLower().Contains(searchString) 
                ).ToList();
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
                case "ParcelStatusDesc":
                    parcelsData = parcelsData.OrderByDescending(s => s.ParcelStatus).ToList();
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
