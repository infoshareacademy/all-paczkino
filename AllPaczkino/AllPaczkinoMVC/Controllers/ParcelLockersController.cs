using AllPaczkino.Models;
using AllPaczkino.Repositories;
using AllPaczkinoLogic.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AllPaczkinoMVC.Controllers
{
    public class ParcelLockersController : Controller
    {

        ParcelLockersRepository parcelLockersRepository = new();
        List<ParcelLocker> parcelLockerList;

        // GET: ParcelLockers
        public ActionResult Index()
        {
            parcelLockerList = parcelLockersRepository.GetAll();
            return View(parcelLockerList);
        }

        // GET: ParcelLockers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ParcelLockers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ParcelLockers/Create
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

        // GET: ParcelLockers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ParcelLockers/Edit/5
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

        // GET: ParcelLockers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ParcelLockers/Delete/5
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
