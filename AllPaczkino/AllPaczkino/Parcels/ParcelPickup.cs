using AllPaczkino.DAL;
using AllPaczkino.Models;
using AllPaczkino.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPaczkino.Parcels
{
    public class ParcelPickup
    {
        ConsoleKeyInfo key;
        public void ParcelPickupValidatoin()
        {
            var parcelsFakeList = CreateFakeData();
            {
                do
                {
                    Console.WriteLine(" Podaj nr paczki: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal parcelNumberId))
                    {
                        var searchedParcelState = parcelsFakeList.FirstOrDefault(p => p.ParcelNumber == parcelNumberId);

                        Console.WriteLine(
                           searchedParcelState != null
                               ? $"For parcel with id {parcelNumberId} actual state is:     {searchedParcelState.parcelStatus}."
                               : $"Parcel with id {parcelNumberId} not found, check the number!");


                        //if parcel is ready for collection
                        if (searchedParcelState.parcelStatus == ParcelStatus.ReadyToCollection)
                        {

                            Console.WriteLine("Do you want to collect parcel? Y/N?");
                            var collect = Console.ReadLine();
                            if (collect == "Y" || collect == "y")
                            {
                                Console.WriteLine("Enter collection code");
                                var confirmationCode = Console.ReadLine();
                                if (confirmationCode == "1234")
                                {
                                    searchedParcelState.parcelStatus = ParcelStatus.Received;
                                    var packageRepository = new PackageRepository();

                                    packageRepository.SaveAll(new List<Package>
                                                {
                                                    new Package
                                                    {
                                                        ParcelStatus = searchedParcelState.parcelStatus,
                                                        PackageNumber = searchedParcelState.ParcelNumber,
                                        }
                                                });
                                    Console.WriteLine("Parcel collected");
                                    continue;
                                }
                                else if (confirmationCode! == "1234")
                                {
                                    Console.WriteLine("Wrong code. Please enter correct collection code.");
                                }
                                continue;
                            }
                            else if (collect == "N" || collect == "n")
                            {
                                Console.WriteLine("Quitting to main menu");
                            }
                        }
                    }
                    continue;

                } while (key.Key != ConsoleKey.Spacebar);
            }
            static List<Parcel> CreateFakeData()
            {
                //fake data
                Console.WriteLine("Fake data for tests:"); ;
                Parcel parcel1 = new Parcel();
                Console.WriteLine($"ID parcel 1: {parcel1.ParcelNumber}"); ;
                Parcel parcel2 = new Parcel();
                parcel2.parcelStatus = ParcelStatus.ReadyToCollection;
                Console.WriteLine($"ID parcel 2: {parcel2.ParcelNumber}"); ;
                Parcel parcel3 = new Parcel();
                parcel3.parcelStatus = ParcelStatus.InDelivery;
                Console.WriteLine($"ID parcel 3: {parcel3.ParcelNumber}"); ;
                List<Parcel> parcelsFakeList = new List<Parcel>();
                parcelsFakeList.Add(parcel1);
                parcelsFakeList.Add(parcel2);
                parcelsFakeList.Add(parcel3);
                return parcelsFakeList;
            }
        }
    }
}
