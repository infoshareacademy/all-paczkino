using AllPaczkino.DAL;
using AllPaczkino.Models;
using AllPaczkino.Repositories;
using AllPaczkino.View;
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
            {
                // do uzupełnienia
                var parcelsFakeList = CreateFakeData();
                //for (int i = 0; i < 10; i++)
                {
                    do
                    {
                        //Console.WriteLine("                                        ");
                        //Console.WriteLine("Enter parcel number you want to collect: ");
                        //if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                        //{
                        //    Console.WriteLine("                      ");
                        //    Console.WriteLine("Exitting to Main Menu.");
                        //    Console.WriteLine("                      ");
                        //    LoginMenu exitToMenu = new LoginMenu();
                        //    exitToMenu.ShowLoginMenu();
                        //}
                        if (decimal.TryParse(Console.ReadLine(), out decimal parcelNumberId))
                        {
                            var searchedParcelState = parcelsFakeList.FirstOrDefault(p => p.ParcelNumber == parcelNumberId);

                            //if (searchedParcelState != null)
                            //{
                            //    Console.WriteLine(searchedParcelState != null
                            //? $"For parcel with id {parcelNumberId} actual state is: {searchedParcelState.parcelStatus}."
                            //: $"Parcel with id {parcelNumberId} not found, check the number!"
                            //   );
                            //}
                            if (searchedParcelState.ParcelStatus == ParcelStatus.CollectedByCourier)
                            { continue; };

                            if (searchedParcelState.ParcelStatus == ParcelStatus.Registered)
                            { continue; };

                            if (searchedParcelState.ParcelStatus == ParcelStatus.InDelivery)
                            { continue; };

                            if (searchedParcelState.ParcelStatus == ParcelStatus.Returned)
                            { continue; };

                            if (searchedParcelState.ParcelStatus == ParcelStatus.Received)
                            { continue; };

                            //CollectedByCourier,
                            //InDelivery,
                            //Registered,
                            //Returned,
                            //Received,
                            //if parcel is //ReadyToCollect
                            if (searchedParcelState.ParcelStatus == ParcelStatus.ReadyToCollect)
                            {
                                //Console.WriteLine("                                        ");
                                //Console.WriteLine("Do you want to collect this parcel? Y/N?");
                                //var collect = Console.ReadLine();
                                //if (collect == "Y" || collect == "y")
                                {
                                    do
                                    {
                                        //Console.WriteLine("                             ");
                                        //Console.WriteLine("Enter parcel collectoin code:");
                                        var confirmationCode = Console.ReadLine();


                                        if (confirmationCode == "1234")
                                        {
                                            searchedParcelState.ParcelStatus = ParcelStatus.Received;
                                            var packageRepository = new ParcelsRepository();

                                            packageRepository.SaveAll(new List<Parcel>
                                                    {
                                                        new Parcel
                                                        {
                                                            ParcelStatus = searchedParcelState.ParcelStatus,
                                                            ParcelNumber = searchedParcelState.ParcelNumber,
                                                        }
                                                    });
                                            //Console.WriteLine("Parcel collected!");
                                            //Console.WriteLine("                 ");
                                            //Console.WriteLine("Press X to collect another parcel or SPACEBAR to exit to Main Menu.");
                                            //if (Console.ReadKey(true).Key == ConsoleKey.X)
                                            //{
                                            //    break;
                                            //}

                                        }
                                        //else
                                        //{
                                        //    Console.WriteLine("                                                ");
                                        //    Console.WriteLine("Wrong collection code! Please enter correct one!");
                                        //}
                                    } while (true);
                                }
                                //else if (collect == "N" || collect == "n")
                                //{
                                //    Console.WriteLine("                                   ");
                                //    Console.WriteLine("Press X to collect another parcel or SPACEBAR to exit to Main Menu.");

                                //    if (Console.ReadKey(true).Key == ConsoleKey.X)
                                //    {
                                //        break;
                                //    }

                                //}

                            }

                            //if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                            //{
                            //    Console.WriteLine("                      ");
                            //    Console.WriteLine("Exitting to Main Menu.");
                            //    Console.WriteLine("                      ");
                            //    LoginMenu exitToMenu = new LoginMenu();
                            //    exitToMenu.ShowLoginMenu();
                            //}
                        }
                    } while (true);

                    //continue;
                }

            };

        }
        private List<Parcel> CreateFakeData()
        {

            //fake data
            Console.WriteLine("Fake data for tests:");
            Parcel parcel1 = new Parcel();
            Console.WriteLine($"ID parcel 1: {parcel1.ParcelNumber}");
            Parcel parcel2 = new Parcel();
            parcel2.ParcelStatus = ParcelStatus.ReadyToCollect;
            Console.WriteLine($"ID parcel 2: {parcel2.ParcelNumber}");
            Parcel parcel3 = new Parcel();
            parcel3.ParcelStatus = ParcelStatus.InDelivery;
            Console.WriteLine($"ID parcel 3: {parcel3.ParcelNumber}");
            List<Parcel> parcelsFakeList = new List<Parcel>();
            parcelsFakeList.Add(parcel1);
            parcelsFakeList.Add(parcel2);
            parcelsFakeList.Add(parcel3);
            return parcelsFakeList;
        }
    }
}