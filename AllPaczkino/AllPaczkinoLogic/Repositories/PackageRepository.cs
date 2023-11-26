using AllPaczkino.DAL;
using Newtonsoft.Json;

namespace AllPaczkino.Repositories
{
    public class PackageRepository
    {
        public List<Package> GetAll()
        {
            string jsonPath = "DAL\\packages.json";
            string jsonContent = File.ReadAllText(jsonPath);
            List<Package> items = JsonConvert.DeserializeObject<List<Package>>(jsonContent);
            return items;
        }

        public void SaveAll(List<Package> items)
        {
            string jsonPath = "DAL\\packages.json";
            string updatedJsonContent = JsonConvert.SerializeObject(items, Formatting.Indented);
            File.WriteAllText(jsonPath, updatedJsonContent);
        }
    }
}
