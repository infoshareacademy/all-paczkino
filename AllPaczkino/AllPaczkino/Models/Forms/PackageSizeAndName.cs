

using Microsoft.Graph;

namespace AllPaczkino.Models.Forms
{
    public class PackageSizeAndName
    {
        static void Main()
        {
            Console.WriteLine("Wybierz rozmiar paczki:");
            Console.WriteLine("Y - Mała paczka");
            Console.WriteLine("X - Średnia paczka");
            Console.WriteLine("Z - Duża paczka");


            var response = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            var packageSize = GetPackageSize(response);

            if (!string.IsNullOrEmpty(packageSize))
            {
                Console.WriteLine("Podaj nazwę paczki:");
                var packageName = Console.ReadLine();
                while (!string.IsNullOrEmpty(packageName))
                {
                    Console.WriteLine("Pusta nazwa niedozwolona. Popraw:");
                    packageName = Console.ReadLine();
                }

                var package = new Package(packageName, packageSize);

                Console.WriteLine($"Nazwa paczki: {package.Name}");
                Console.WriteLine($"Data nadania: {package.ShippingDate}");
                Console.WriteLine($"ID paczki: {package.Id}");
            }
            else 
            {
                Console.WriteLine("Nieprawidłowy wybór.");
            }
        }

        static string? GetPackageSize(char response)
        {
            switch (response)
            {
                case 'Y':
                    return "Mała paczka";
                case 'X':
                    return "Średnia paczka";
                case 'Z':
                    return "Duża paczka";
                default:
                    return null;
            }
        }
    }

    class Package
    {
        public string Id { get; }
        public string Name { get; }
        public string Size { get; }
        public DateTime ShippingDate { get; }

        public Package(string name, string size)
        {
            Id = GeneratePackageId();
            Name = name;
            Size = size;
            ShippingDate = DateTime.Now;
        }

        private string GeneratePackageId()
        {

            return $"{DateTime.Now:yyyyMMddHHmmssfff}-{new Random().Next(1000, 9999)}";
        }
    }

}


class PackageList
{
    static void Main()
    {

        List<object> packageList = new List<object>();

        var myPackage = new
        {
            Name = "PrzykładowaNazwaPackage"

        };

        packageList.Add(myPackage);


        foreach (var package in packageList)
        {

            var packageName = ((dynamic)package).Name;

            Console.WriteLine($"Name: {packageName}");
        }
    }
}







