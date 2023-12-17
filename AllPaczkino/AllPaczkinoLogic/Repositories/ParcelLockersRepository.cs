using AllPaczkino.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPaczkinoLogic.Repositories
{
	public class ParcelLockersRepository
	{
		public List<ParcelLocker> GetAll()
		{
			try
			{
				string jsonPath = "DAL\\Parcellockers.json";
				string jsonContent = File.ReadAllText(jsonPath);
				ParcelLockerList parcelLockerList = JsonConvert.DeserializeObject<ParcelLockerList>(jsonContent);
				List<ParcelLocker> items = parcelLockerList.parcel_lockers;
				return items;
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error reading JSON file: {ex.Message}");
				return new List<ParcelLocker>();
			}
		}

		public void SaveAll(List<ParcelLocker> items)
		{
			var x = new ParcelLockerList()
			{
				parcel_lockers = items
			};
			string jsonPath = "DAL\\Parcellockers.json";
			string updatedJsonContent = JsonConvert.SerializeObject(x, Formatting.Indented);
			File.WriteAllText(jsonPath, updatedJsonContent);

		}
		public ParcelLocker GetById(int id)
		{
			List<ParcelLocker> items = GetAll();
			return items.FirstOrDefault(x => x.id == id);
		}
		public void Create(ParcelLocker newParcelLocker)
		{
			if (newParcelLocker != null)
			{
				List<ParcelLocker> items = GetAll();
				var id = items.Max(x => x.id) + 1;
				newParcelLocker.id = id;
				items.Add(newParcelLocker);
				SaveAll(items);
			}
			else
			{
				Console.WriteLine("Invalid ParcelLocker data");
			}
		}
		public void Delete(int id)
		{
			List<ParcelLocker> items = GetAll();
			var ParcelLockerToDelete = GetById(id);
			if (ParcelLockerToDelete != null)
			{
				List<ParcelLocker> updatedParcelLockerList = items.Where(ParcelLocker => ParcelLocker.id != ParcelLockerToDelete.id).ToList();
				SaveAll(updatedParcelLockerList);
			}
		}
		public void Update(int id, ParcelLocker editedParcelLocker)
		{
			List<ParcelLocker> items = GetAll();
			var ParcelLockerToUpdate = GetById(id);
			if (ParcelLockerToUpdate != null)
			{
				ParcelLockerToUpdate.city = editedParcelLocker.city;
				ParcelLockerToUpdate.postal_code = editedParcelLocker.postal_code;
				ParcelLockerToUpdate.address = editedParcelLocker.address;

				SaveAll(items);
			}
		}
	}
}

