using AllPaczkino.Models;
using AllPaczkino.Repositories;
using AllPaczkinoLogic.Repositories;
using AllPaczkinoPersistance.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AllPaczkinoMVC.Controllers
{
    public class ParcelLockersController : Controller
    {

        ParcelLockersRepository parcelLockersRepository = new();
        List<ParcelLockerDb> parcelLockerList;
        private readonly IParcelLockersRepository _parcelLockersRepository;

        public ParcelLockersController(IParcelLockersRepository parcelLockersRepository)
        {
            _parcelLockersRepository = parcelLockersRepository;
        }
        // GET: ParcelLockers
        public ActionResult Index()
        {
            parcelLockerList = _parcelLockersRepository.GetAll();
            return View(parcelLockerList);
        }

        // GET: ParcelLockers/Details/5
        public ActionResult Details(int id)
        {
            var parcelLocker = parcelLockersRepository.GetById(id);
            return View(parcelLocker);
        }

        // GET: ParcelLockers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ParcelLockers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ParcelLocker parcelLocker)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(parcelLocker);
                }
                parcelLockersRepository.Create(parcelLocker);
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
            var lockerToEdit = parcelLockersRepository.GetById(id);
            return View(lockerToEdit);
        }

        // POST: ParcelLockers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ParcelLocker lockerToEdit)
        {
            try
            {
              parcelLockersRepository.Update(id, lockerToEdit);
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
            var lockerToDelete = parcelLockersRepository.GetById(id);
            return View(lockerToDelete);
        }

        // POST: ParcelLockers/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ParcelLocker lockerToDelete)
        {
            try
            {
                parcelLockersRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
