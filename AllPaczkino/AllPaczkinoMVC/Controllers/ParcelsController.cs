using AllPaczkino.Models;
using AllPaczkino.Repositories;
using AllPaczkinoLogic.Repositories;
using AllPaczkinoMVC.DTO;
using AllPaczkinoMVC.Mappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using Parcels.Parcels;
using System.Reflection;

namespace AllPaczkinoMVC.Controllers
{
    [Authorize]

    public class ParcelsController : Controller
    {
        ParcelsRepository parcelRepository = new();
        ParcelLockersRepository parcelLockersRepository = new();
        List<Parcel> parcelsData ;
		private ParcelMapper parcelMapper;

		public ParcelsController()
        {
            parcelMapper = new ParcelMapper(parcelLockersRepository);
		}

        // GET: ParcelsControler
        public ActionResult Index(string sortOrder, string searchString)
        {
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
            ViewBag.IdSortParam = string.IsNullOrEmpty(sortOrder) ? "id_desc" : "";
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
                case "id_desc":
                    parcelsData = parcelsData.OrderByDescending(s => s.ID).ToList();
                    break;
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
            var parcelData = parcelRepository.GetById(id);
            return View(parcelData);
        }

        // GET: ParcelsControler/Create
        public ActionResult Create()
        {
				string json = System.IO.File.ReadAllText("DAL/parcellockers.json");

				ParcelLockerList parcelLockerList = JsonConvert.DeserializeObject<ParcelLockerList>(json);
	
				List<string> cities = parcelLockerList?.parcel_lockers?.Select(x => x.city).Distinct().OrderBy(x => x).ToList();

				var viewModel = new ParcelCreationRequest
				{
					Cities = new SelectList(cities),
					ParcelLockersInSelectedCity = new SelectList(new List<string>()) // Initialize with an empty list
				};

				return View(viewModel);
		}

        public JsonResult GetParcelLockersInSelectedCity(string city)
        {
            string json = System.IO.File.ReadAllText("DAL/parcellockers.json");

            ParcelLockerList parcelLockerList = JsonConvert.DeserializeObject<ParcelLockerList>(json);

            List<ParcelLocker> parcelLockersInSelectedCity = parcelLockerList?.parcel_lockers?.Where(x => x.city == city).ToList();

            return Json(parcelLockersInSelectedCity);
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
					return View(parcelRequest);
				}

				var parcel = parcelMapper.MapToParcel(parcelRequest);
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
