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
    }
}
