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
    public class ParcelPickup : Parcel
    {
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
                        if (searchedParcelState.parcelStatus == ParcelStatus.ReadyToCollect)
                        {

                            Console.WriteLine("Do you want to collect the parcel? Y/N?");
                            var collect = Console.ReadLine()?.Trim(); // Trim to remove leading/trailing spaces

                            if (collect == "Y" || collect == "y")
                            {
                                Console.WriteLine("Enter the collection code");
                                var confirmationCode = Console.ReadLine();

                                try
                                {
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
                                    }
                                    else
                                    {
                                        Console.WriteLine("Wrong code. Please enter the correct collection code.");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"An error occurred: {ex.Message}");
                                }
                            }
                            else if (collect == "N" || collect == "n")
                            {
                                Console.WriteLine("Quitting to main menu");
                            }
                        }
                    }
                    continue;

                } while (true);
            }
            static List<Parcel> CreateFakeData()
            {
                //fake data
                Console.WriteLine("Fake data for tests:"); ;
                Parcel parcel1 = new Parcel();
                Console.WriteLine($"ID parcel 1: {parcel1.ParcelNumber}"); ;
                Parcel parcel2 = new Parcel();
                parcel2.parcelStatus = ParcelStatus.ReadyToCollect;
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