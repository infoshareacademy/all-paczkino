using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcels.Parcels;
using AllPaczkino.Models;
using Newtonsoft.Json;

namespace AllPaczkino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ParcelSize> parcels = new List<ParcelSize>();

            ParcelSize smallParcel = new ParcelSize("Small Parcel", 10, 20, 30, 5, 7.99);
            ParcelSize mediumParcel = new ParcelSize("Medium Parcel", 20, 30, 50, 10, 10.99);
            ParcelSize largeParcel = new ParcelSize("Large Parcel", 40, 40, 70, 20, 14.99);

            parcels.Add(smallParcel);
            parcels.Add(mediumParcel);
            parcels.Add(largeParcel);

            Console.WriteLine("Choose your parcel size by typing S, M or L: ");

            foreach (ParcelSize parcelSize in parcels)
            {
                Console.WriteLine(parcelSize.Name + " max length: " + parcelSize.Length + " cm, max width: " +
                                  parcelSize.Width + " cm, max height: " + parcelSize.Height + " cm, max weight " +
                                  parcelSize.Weight + " kg, Price: " + parcelSize.Price);
            }

            string jsonPath = "DAL\\parcellockers.json";
            string jsonContent = File.ReadAllText(jsonPath);
            ParcelLockerList parcelLockerList = JsonConvert.DeserializeObject<ParcelLockerList>(jsonContent);
            Console.WriteLine("Press 'L' to display the list of parcel lockers.");
            Console.WriteLine("Press 'M' to find a suggested parcel locker based on the recipient's city name.");
            Console.WriteLine("Press 'N' to select a parcel locker by number.");
            Console.WriteLine("Press 'C' to create a parcel locker by number.");
            Console.WriteLine("Press 'E' to edit a parcel locker by number.");
            Console.WriteLine("Press 'D' to delete a parcel locker by number.");

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(intercept: true);

                switch (key.Key)
                {
                    case ConsoleKey.L:
                        {
                            Console.WriteLine("List of parcel lockers:");
                            foreach (var parcelLocker in parcelLockerList.parcel_lockers)
                            {
                                Console.WriteLine(
                                    $"{parcelLocker.id}. {parcelLocker.city}, {parcelLocker.postal_code} - {parcelLocker.address}");
                            }

                            break;
                        }
                    case ConsoleKey.M:
                        {
                            Console.Write("Enter the recipient's city name: ");
                            string cityName = Console.ReadLine();

                            var matchingParcelLockers = parcelLockerList.parcel_lockers.FindAll(p => p.city.ToLower() == cityName.ToLower());

                            if (matchingParcelLockers.Count > 0)
                            {
                                Console.WriteLine($"Parcel lockers for the city '{cityName}':");
                                foreach (var parcelLocker in matchingParcelLockers)
                                {
                                    Console.WriteLine($"{parcelLocker.id}. {parcelLocker.city}, {parcelLocker.postal_code} - {parcelLocker.address}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("No parcel lockers found for the given city.");
                            }

                            break;
                        }
                    case ConsoleKey.N:
                        {
                            Console.Write("Enter a parcel locker number: ");
                            if (int.TryParse(Console.ReadLine(), out int selectedNumber))
                            {
                                var selectedParcelLocker = parcelLockerList.parcel_lockers.Find(p => p.id == selectedNumber);
                                Console.WriteLine(
                                    selectedParcelLocker != null
                                        ? $"Selected parcel locker: {selectedParcelLocker.city}, {selectedParcelLocker.postal_code} - {selectedParcelLocker.address}"
                                        : $"Parcel locker with the number {selectedNumber} was not found.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid number.");
                            }

                            break;
                        }
                    case ConsoleKey.E:
                        {
                            Console.Write("Enter a parcel locker number to edit: ");
                            if (int.TryParse(Console.ReadLine(), out int selectedNumber))
                            {
                                var selectedParcelLocker = parcelLockerList.parcel_lockers.Find(p => p.id == selectedNumber);
                                if (selectedParcelLocker != null)
                                {
                                    Console.WriteLine($"Editing parcel locker {selectedNumber}:");
                                    Console.Write("Enter new city: ");
                                    selectedParcelLocker.city = Console.ReadLine();
                                    Console.Write("Enter new postal code: ");
                                    selectedParcelLocker.postal_code = Console.ReadLine();
                                    Console.Write("Enter new address: ");
                                    selectedParcelLocker.address = Console.ReadLine();
                                    Console.WriteLine("Parcel locker updated.");
                                    string updatedJsonContent = JsonConvert.SerializeObject(parcelLockerList, Formatting.Indented);
                                    File.WriteAllText(jsonPath, updatedJsonContent);
                                }
                                else
                                {
                                    Console.WriteLine($"Parcel locker with the number {selectedNumber} was not found.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid number.");
                            }

                            break;
                        }
                    case ConsoleKey.D:
                        {
                            Console.Write("Enter a parcel locker number to delete: ");
                            if (int.TryParse(Console.ReadLine(), out int selectedNumber))
                            {
                                var selectedParcelLocker = parcelLockerList.parcel_lockers.Find(p => p.id == selectedNumber);
                                if (selectedParcelLocker != null)
                                {
                                    parcelLockerList.parcel_lockers.Remove(selectedParcelLocker);
                                    Console.WriteLine($"Parcel locker {selectedNumber} has been deleted.");
                                    string updatedJsonContent = JsonConvert.SerializeObject(parcelLockerList, Formatting.Indented);
                                    File.WriteAllText(jsonPath, updatedJsonContent);
                                }
                                else
                                {
                                    Console.WriteLine($"Parcel locker with the number {selectedNumber} was not found.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid number.");
                            }

                            break;
                        }
                    case ConsoleKey.C:
                        CreateParcelLocker(parcelLockerList);
                        break;
                }
                static void CreateParcelLocker(ParcelLockerList parcelLockerList)
                {
                    Console.WriteLine("Creating a new parcel locker:");
                    Console.Write("Enter city: ");
                    string city = Console.ReadLine();
                    Console.Write("Enter postal code: ");
                    string postalCode = Console.ReadLine();
                    Console.Write("Enter address: ");
                    string address = Console.ReadLine();

                    int newId = FindFirstAvailableId(parcelLockerList);
                    ParcelLocker newParcelLocker = new ParcelLocker
                    {
                        id = newId,
                        city = city,
                        postal_code = postalCode,
                        address = address
                    };

                    parcelLockerList.parcel_lockers.Add(newParcelLocker);
                    Console.WriteLine($"New parcel locker with ID {newId} has been created.");
                    string jsonPath = "DAL\\parcellockers.json";
                    string updatedJsonContent = JsonConvert.SerializeObject(parcelLockerList, Formatting.Indented);
                    File.WriteAllText(jsonPath, updatedJsonContent);
                }

                static int FindFirstAvailableId(ParcelLockerList parcelLockerList)
                {
                    int newId = 1;
                    foreach (var parcelLocker in parcelLockerList.parcel_lockers)
                    {
                        if (parcelLocker.id == newId)
                            newId++;
                        else
                            break;
                    }
                    return newId;
                }
            }
        }
    }
}
