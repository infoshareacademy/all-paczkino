using AllPaczkino.Models;
using AllPaczkino.Repositories;
using AllPaczkinoLogic.Repositories;
using AllPaczkinoMVC.DTO;
using AllPaczkinoMVC.Mappers;
using AllPaczkinoPersistance.Models;
using AllPaczkinoPersistance.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace AllPaczkinoMVC.Controllers
{

    [Authorize(Roles = "User, Admin")]

    public class ParcelsController : Controller
    {
        private IParcelLockersRepository _parcelLockersRepository;
        //private ParcelLockersRepository parcelLockersRepository1 = new();
        private IParcelsRepository _parcelsRepository;

        //ParcelsRepository parcelRepository = new();
        List<Parcel> parcelsData;
        private ParcelMapper parcelMapper;
        private readonly UserManager<IdentityUser> _userManager;

		public ParcelsController(UserManager<IdentityUser> userManager, IParcelLockersRepository parcelLockersRepository, IParcelsRepository parcelsRepository)
		{
			parcelMapper = new ParcelMapper(parcelLockersRepository);
			_userManager = userManager;
			_parcelLockersRepository = parcelLockersRepository;
			_parcelsRepository = parcelsRepository;
		}

		// GET: ParcelsControler
		public ActionResult Index(string sortOrder, string searchString)
        {
            List<ParcelDb> parcelsDbData = _parcelsRepository.GetAll();
            var parcelsData = parcelsDbData.Select(parcelDb => parcelMapper.MapToParcel(parcelDb));
            if (User.IsInRole("User"))
            {
                parcelsData = parcelsData.Where(parcel => parcel.Sender.ContactData.Email == User.Identity.Name).ToList();
            }
            if (!String.IsNullOrEmpty(searchString))
            {
                searchString = searchString.ToLower();
                parcelsData = parcelsData.Where(s =>
             (s.Name != null && s.Name.ToLower().Contains(searchString)) ||
             (s.ParcelNumber != null && s.ParcelNumber.ToString().Contains(searchString)) ||
             (s.ReceiveTime != null && s.ReceiveTime.ToString().Contains(searchString)) ||
             s.SendTime.ToString().Contains(searchString) ||
             (s.Sender?.ContactData?.Name != null && s.Sender.ContactData.Name.ToLower().Contains(searchString)) ||
             (s.Sender?.ContactData?.Email != null && s.Sender.ContactData.Email.ToLower().Contains(searchString)) ||
             (s.Sender?.ContactData?.PhoneNumber != null && s.Sender.ContactData.PhoneNumber.Contains(searchString)) ||
             (s.SenderLocker?.postal_code != null && s.SenderLocker.postal_code.Contains(searchString)) ||
             (s.SenderLocker?.city != null && s.SenderLocker.city.ToLower().Contains(searchString)) ||
             (s.SenderLocker?.address != null && s.SenderLocker.address.ToLower().Contains(searchString)) ||
             (s.Receiver?.ContactData?.Name != null && s.Receiver.ContactData.Name.ToLower().Contains(searchString)) ||
             (s.Receiver?.ContactData?.Email != null && s.Receiver.ContactData.Email.ToLower().Contains(searchString)) ||
             (s.Receiver?.ContactData?.PhoneNumber != null && s.Receiver.ContactData.PhoneNumber.Contains(searchString)) ||
             (s.ReceiverLocker?.postal_code != null && s.ReceiverLocker.postal_code.Contains(searchString)) ||
             (s.ReceiverLocker?.city != null && s.ReceiverLocker.city.ToLower().Contains(searchString)) ||
             (s.ReceiverLocker?.address != null && s.ReceiverLocker.address.ToLower().Contains(searchString)) ||
             (s.ParcelSize?.Name != null && s.ParcelSize.Name.ToLower().Contains(searchString))
         ).ToList();

            }
            ViewBag.NameSortParam = sortOrder == "Name" ? "Name_desc" : "Name";
            ViewBag.ParcelNumberParam = sortOrder == "parcelnumber" ? "parcelnumber_desc" : "parcelnumber";
            ViewBag.SendTimeParam = sortOrder == "SendTime" ? "SendTime_desc" : "SendTime";
            ViewBag.ReceiveTimeParam = sortOrder == "ReceiveTime" ? "ReceiveTime_desc" : "ReceiveTime";
            ViewBag.ParcelStatusParam = sortOrder == "ParcelStatus" ? "ParcelStatus_desc" : "ParcelStatus";
            ViewBag.SenderParam = sortOrder == "Sender" ? "Sender_desc" : "Sender";
            ViewBag.SenderLockerParam = sortOrder == "SenderLocker" ? "SenderLocker_desc" : "SenderLocker";
            ViewBag.ReceiverParam = sortOrder == "Receiver" ? "Receiver_desc" : "Receiver";
            ViewBag.ReceiverLockerParam = sortOrder == "ReceiverLocker" ? "ReceiverLocker_desc" : "ReceiverLocker";
            ViewBag.ParcelSizeParam = sortOrder == "ParcelSize" ? "ParcelSize_desc" : "ParcelSize";
            switch (sortOrder)
            {
                case "Name_desc":
                    parcelsData = parcelsData.OrderByDescending(s => s.Name).ToList();
                    break;
                case "Name":
                    parcelsData = parcelsData.OrderBy(s => s.Name).ToList();
                    break;
                case "parcelnumber_desc":
                    parcelsData = parcelsData.OrderByDescending(s => s.ParcelNumber).ToList();
                    break;
                case "parcelnumber":
                    parcelsData = parcelsData.OrderBy(s => s.ParcelNumber).ToList();
                    break;
                case "SendTime_desc":
                    parcelsData = parcelsData.OrderByDescending(s => s.SendTime).ToList();
                    break;
                case "SendTime":
                    parcelsData = parcelsData.OrderBy(s => s.SendTime).ToList();
                    break;
                case "ReceiveTime_desc":
                    parcelsData = parcelsData.OrderByDescending(s => s.ReceiveTime).ToList();
                    break;
                case "ReceiveTime":
                    parcelsData = parcelsData.OrderBy(s => s.ReceiveTime).ToList();
                    break;
                case "ParcelStatus_desc":
                    parcelsData = parcelsData.OrderByDescending(s => s.ParcelStatus).ToList();
                    break;
                case "ParcelStatus":
                    parcelsData = parcelsData.OrderBy(s => s.ParcelStatus).ToList();
                    break;
                case "Sender_desc":
                    parcelsData = parcelsData.OrderByDescending(s => s.Sender.ContactData.Name).ToList();
                    break;
                case "Sender":
                    parcelsData = parcelsData.OrderBy(s => s.Sender.ContactData.Name).ToList();
                    break;
                case "SenderLocker_desc":
                    parcelsData = parcelsData.OrderByDescending(s => s.SenderLocker.postal_code).ToList();
                    break;
                case "SenderLocker":
                    parcelsData = parcelsData.OrderBy(s => s.SenderLocker.postal_code).ToList();
                    break;
                case "Receiver_desc":
                    parcelsData = parcelsData.OrderByDescending(s => s.Receiver.ContactData.Name).ToList();
                    break;
                case "Receiver":
                    parcelsData = parcelsData.OrderBy(s => s.Receiver.ContactData.Name).ToList();
                    break;
                case "ReceiverLocker_desc":
                    parcelsData = parcelsData.OrderByDescending(s => s.ReceiverLocker.postal_code).ToList();
                    break;
                case "ReceiverLocker":
                    parcelsData = parcelsData.OrderBy(s => s.ReceiverLocker.postal_code).ToList();
                    break;
                case "ParcelSize_desc":
                    parcelsData = parcelsData.OrderByDescending(s => s.ParcelSize.Name).ToList();
                    break;
                case "ParcelSize":
                    parcelsData = parcelsData.OrderBy(s => s.ParcelSize.Name).ToList();
                    break;
                default:
                    parcelsData = parcelsData.OrderBy(s => s.ID).ToList();
                    break;
            }

            return View(parcelsData);
        }


        // GET: ParcelsControler/Details/5
        public ActionResult Details(int id)
        {
            var parcelDb = _parcelsRepository.GetById(id);
			var parcel = parcelMapper.MapToParcel(parcelDb);
			return View(parcel);
        }

		// GET: ParcelsControler/Create
		public ActionResult Create()
		{
			var parcelLockers = _parcelLockersRepository.GetAll().ToList();
			List<string> cities = parcelLockers?.Select(x => x.City)
												.Distinct()
												.OrderBy(x => x)
												.ToList();

			var viewModel = new ParcelCreationRequest
			{
				Cities = new SelectList(cities ?? new List<string>()),
				ParcelLockersInSelectedSenderCity = new SelectList(new List<ParcelLockerDb>()), // Initialize with an empty list
				ParcelLockersInSelectedReceiverCity = new SelectList(new List<ParcelLockerDb>()) // Initialize with an empty list
			};

			return View(viewModel);
		}

		public JsonResult GetParcelLockersInSelectedSenderCity(string city)
        {
            var parcelLockers = _parcelLockersRepository.GetAll().ToList();

            List<ParcelLockerDb> parcelLockersInSelectedSenderCity = parcelLockers?.Where(x => x.City == city).ToList();

            return Json(parcelLockersInSelectedSenderCity);
        }

		public JsonResult GetParcelLockersInSelectedReceiverCity(string city)
		{
			var parcelLockers = _parcelLockersRepository.GetAll().ToList();

			List<ParcelLockerDb> parcelLockersInSelectedReceiverCity = parcelLockers?.Where(x => x.City == city).ToList();

			return Json(parcelLockersInSelectedReceiverCity);
		}

		// POST: ParcelsControler/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(ParcelCreationRequest parcelRequest)
		{
			try
			{
				if (!ModelState.IsValid)
				{
					// Repopulate dropdown lists and return the view
					var parcelLockers = _parcelLockersRepository.GetAll().ToList();
					List<string> cities = parcelLockers?.Select(x => x.City)
														.Distinct()
														.OrderBy(x => x)
														.ToList();

					parcelRequest.Cities = new SelectList(cities);
					parcelRequest.ParcelLockersInSelectedSenderCity = new SelectList(new List<ParcelLockerDb>()); // Initialize with an empty list
					parcelRequest.ParcelLockersInSelectedReceiverCity = new SelectList(new List<ParcelLockerDb>()); // Initialize with an empty list

					return View(parcelRequest);
				}

				var parcel = parcelMapper.MapToParcel(parcelRequest);
                var parcelDb = parcelMapper.MapToParcelDb(parcel);
				_parcelsRepository.Create(parcelDb);

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
            var parcelDbDetails = _parcelsRepository.GetById(id);
            var parcelDetails = parcelMapper.MapToParcel(parcelDbDetails);
            return View(parcelDetails);
        }

        // POST: ParcelsControler/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Parcel editedParcel)
        {
            try
            {
                var editedDbParcel = parcelMapper.MapToParcelDb(editedParcel);
                _parcelsRepository.Update(id, editedDbParcel);
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
            var parcelDbToDelete = _parcelsRepository.GetById(id);
            var parcelToDelete = parcelMapper.MapToParcel(parcelDbToDelete);
            return View(parcelToDelete);
        }

        // POST: ParcelsControler/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _parcelsRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
