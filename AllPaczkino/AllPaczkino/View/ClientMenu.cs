using AllPaczkino.Clients;
using AllPaczkino.DAL;
using AllPaczkino.Models;
using AllPaczkino.Repositories;
using AngleSharp.Css;

namespace AllPaczkino.View
{
    public class ClientMenu
    {
        ConsoleKeyInfo key;
        PackageRepository packageRepository = new PackageRepository();

        public void ShowClientMenu()
        {
            //var parcelsFakeList = CreateFakeData();
            Console.WriteLine("CLIENT MAIN MENU:\n");
            Console.WriteLine("Press A to create and send new parcel.");
            Console.WriteLine("Press P to pickup parcel.");
            Console.WriteLine("Press S to get parcel current status.");
            Console.WriteLine("Press Spacebar to go back to login menu.");
            Console.WriteLine("Press Esc to quit.\n");
            do
            {
                key = Console.ReadKey(intercept: true);
                switch (key.Key)
                {
                    case ConsoleKey.A: // formularz nadania paczki
                        {

                            Console.WriteLine(" Wypełnij pola niezbędne do nadania paczki: ");
                            Console.WriteLine("aaddin fake package");
                            Package package = new Package()
                            {
                                ID = "2",
                                Name = "TestPackage2",
                                Address = new Clients.ContactInfo.Adress("street Name ", 666, "City Name", "cos", "05-500"),
                                SenderLocker = new ParcelLocker(),
                                ReceiverLocker = new ParcelLocker(),
                                SendTime = DateTime.Now,
                                ReceiveTime = DateTime.Now.AddDays(30),
                                ParcelStatus = ParcelStatus.Registered
                            };
                            var packages = packageRepository.GetAll();
                            packages.Add(package);
                            packageRepository.SaveAll(packages);
                            Console.WriteLine($"Fake package with ID: {package.ID} and Name: {package.Name} saved!");
                            break;
                        };

                    case ConsoleKey.P: // formularz odbioru paczki
                        {
                            // do uzupełnienia
                            var parcelsFakeList = CreateFakeData();
                            for (int i = 0; i < 10; i++)
                            {
                                do
                                {
                                    Console.WriteLine("                                        ");
                                    Console.WriteLine("Enter parcel number you want to collect: ");
                                    if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                                    {
                                        Console.WriteLine("                      ");
                                        Console.WriteLine("Exitting to Main Menu.");
                                        Console.WriteLine("                      ");
                                        LoginMenu exitToMenu = new LoginMenu();
                                        exitToMenu.ShowLoginMenu();
                                    }
                                    if (decimal.TryParse(Console.ReadLine(), out decimal parcelNumberId))
                                    {
                                        var searchedParcelState = parcelsFakeList.FirstOrDefault(p => p.ParcelNumber == parcelNumberId);

                                        if (searchedParcelState != null)
                                        {
                                            Console.WriteLine( searchedParcelState != null
                                        ? $"For parcel with id {parcelNumberId} actual state is: {searchedParcelState.parcelStatus}."
                                        : $"Parcel with id {parcelNumberId} not found, check the number!"
                                           );
                                        }
                                        if (searchedParcelState.parcelStatus == ParcelStatus.CollectedByCourier)
                                        { continue; };

                                        if (searchedParcelState.parcelStatus == ParcelStatus.Registered)
                                        { continue; };

                                        if (searchedParcelState.parcelStatus == ParcelStatus.InDelivery)
                                        { continue; };

                                        if (searchedParcelState.parcelStatus == ParcelStatus.Returned)
                                        { continue; };
                                        
                                        if (searchedParcelState.parcelStatus == ParcelStatus.Received)
                                        { continue; };

                                        //CollectedByCourier,
                                        //InDelivery,
                                        //Registered,
                                        //Returned,
                                        //Received,
                                        //if parcel is //ReadyToCollect
                                        if (searchedParcelState.parcelStatus == ParcelStatus.ReadyToCollect)
                                        {
                                            Console.WriteLine("                                        ");
                                            Console.WriteLine("Do you want to collect this parcel? Y/N?");
                                            var collect = Console.ReadLine();
                                            if (collect == "Y" || collect == "y")
                                            {
                                                do
                                                {
                                                    Console.WriteLine("                             ");
                                                    Console.WriteLine("Enter parcel collectoin code:");
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
                                                        Console.WriteLine("Parcel collected!");
                                                        Console.WriteLine("                 ");
                                                        Console.WriteLine("Press X to collect another parcel or SPACEBAR to exit to Main Menu.");
                                                        if (Console.ReadKey(true).Key == ConsoleKey.X)
                                                        {
                                                            break;
                                                        }
                                                        
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("                                                ");
                                                        Console.WriteLine("Wrong collection code! Please enter correct one!");
                                                    }
                                                } while (true);
                                            }
                                            else if (collect == "N" || collect == "n")
                                            {
                                                Console.WriteLine("                                   ");
                                                Console.WriteLine("Press X to collect another parcel or SPACEBAR to exit to Main Menu.");
                                                
                                                if (Console.ReadKey(true).Key == ConsoleKey.X)
                                                {
                                                    break;
                                                }
                                                
                                            }
                                            
                                        }
                                        
                                        if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                                        {
                                            Console.WriteLine("                      ");
                                            Console.WriteLine("Exitting to Main Menu.");
                                            Console.WriteLine("                      ");
                                            LoginMenu exitToMenu = new LoginMenu();
                                            exitToMenu.ShowLoginMenu();
                                        }
                                    }
                                } while (true);

                                continue;
                            }


                            continue;
                        };

                    case ConsoleKey.S: // sprawdzenie statusu paczki
                        {
                            Console.WriteLine(" Podaj nr paczki lub jej nazwę: ");
                            string parcelNameOrId = null;
                            do
                            {
                                parcelNameOrId = Console.ReadLine();
                                var abc = packageRepository.GetAll();
                                var searchedParcelState = packageRepository.GetAll().FirstOrDefault(p => p.ID == parcelNameOrId || p.Name == parcelNameOrId);
                                Console.WriteLine(
                                   searchedParcelState != null
                                       ? $"For parcel with id {parcelNameOrId} actual state is: {searchedParcelState.ParcelStatus}."
                                       : $"Parcel with id {parcelNameOrId} not found, check the number!");
                            } while (parcelNameOrId == null);

                            break;
                        };

                    case ConsoleKey.Spacebar:
                        LoginMenu loginMenu = new LoginMenu();
                        loginMenu.ShowLoginMenu();

                        break;
                }

            } while (key.Key != ConsoleKey.Escape);
        }

        // rozumiem że całość poniżej możemy usunąć:

        private List<Parcel> CreateFakeData()
        {

            //fake data
            Console.WriteLine("Fake data for tests:");
            Parcel parcel1 = new Parcel();
            Console.WriteLine($"ID parcel 1: {parcel1.ParcelNumber}");
            Parcel parcel2 = new Parcel();
            parcel2.parcelStatus = ParcelStatus.ReadyToCollect;
            Console.WriteLine($"ID parcel 2: {parcel2.ParcelNumber}");
            Parcel parcel3 = new Parcel();
            parcel3.parcelStatus = ParcelStatus.InDelivery;
            Console.WriteLine($"ID parcel 3: {parcel3.ParcelNumber}");
            List<Parcel> parcelsFakeList = new List<Parcel>();
            parcelsFakeList.Add(parcel1);
            parcelsFakeList.Add(parcel2);
            parcelsFakeList.Add(parcel3);
            return parcelsFakeList;

        }

    }
}
