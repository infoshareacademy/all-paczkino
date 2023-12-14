using AllPaczkino.DAL;
using AllPaczkino.Models;
using Newtonsoft.Json;

namespace AllPaczkino.Repositories
{
    public class ParcelsRepository
    {
        public List<Parcel> GetAll()
        {
            string jsonPath = "DAL\\parcels.json";
            string jsonContent = File.ReadAllText(jsonPath);
            List<Parcel> items = JsonConvert.DeserializeObject<List<Parcel>>(jsonContent);
            return items;
        }

        public void SaveAll(List<Parcel> items)
        {
            string jsonPath = "DAL\\parcels.json";
            string updatedJsonContent = JsonConvert.SerializeObject(items, Formatting.Indented);
            File.WriteAllText(jsonPath, updatedJsonContent);
        }
        public Parcel GetById(int id)
        {        
            List<Parcel> items = GetAll();
            return items.FirstOrDefault(x => x.ID == id);
        }
        public void Create(Parcel newParcel)
        {
            List<Parcel> items = GetAll();
            items.Add(newParcel);
            SaveAll(items);
        }
        public void Delete(int id)
        {
            List<Parcel> items = GetAll();
            var parcelToDelete = GetById(id);
            if (parcelToDelete != null)
            {
                List<Parcel> updatedParcelList = items.Where(parcel => parcel.ID != parcelToDelete.ID).ToList();
                SaveAll(updatedParcelList);
            }
        }
    }
}
