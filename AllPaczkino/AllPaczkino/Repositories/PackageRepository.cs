using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using AllPaczkino.DAL;
using AllPaczkino.Models;
using Newtonsoft.Json;

namespace AllPaczkino.Repositories
{
    internal class PackageRepository
    {
        public List<Package> GetAll()
        {
            string jsonPath = "DAL\\pacgages.json";
            string jsonContent = File.ReadAllText(jsonPath);
            List<Package> items = JsonConvert.DeserializeObject<List<Package>>(jsonContent);
            return items;
        }

        public void SaveAll(List<Package> items)
        {
            string jsonPath = "DAL\\pacgages.json";
            string updatedJsonContent = JsonConvert.SerializeObject(items, Formatting.Indented);
            File.WriteAllText(jsonPath, updatedJsonContent);
        }
    }
}
