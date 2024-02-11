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

        List<ParcelLockerDb> parcelLockerList;
        private IParcelLockersRepository _parcelLockersRepository;

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
            var parcelLocker = _parcelLockersRepository.GetById(id);
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
        public async Task<ActionResult> Create(ParcelLockerDb parcelLocker)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(parcelLocker);
                }
                await _parcelLockersRepository.Create(parcelLocker);
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
            var lockerToEdit = _parcelLockersRepository.GetById(id);
            return View(lockerToEdit);
        }

        // POST: ParcelLockers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, ParcelLockerDb lockerToEdit)
        {
            try
            {
              await _parcelLockersRepository.Update(id, lockerToEdit);
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
            var lockerToDelete = _parcelLockersRepository.GetById(id);
            return View(lockerToDelete);
        }

        // POST: ParcelLockers/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, ParcelLockerDb lockerToDelete)
        {
            try
            {
                await _parcelLockersRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
