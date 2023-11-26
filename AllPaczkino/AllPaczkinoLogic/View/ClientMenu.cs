using AllPaczkino.DAL;
using AllPaczkino.Models;
using AllPaczkino.Repositories;
using AllPaczkino.Models.Forms;

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
                            SenderForm senderForm = new SenderForm();


                            //Console.WriteLine( "aaddin fake package");
                            //Package package = new Package()
                            //{
                            //    ID = "2",
                            //    Name = "TestPackage2",
                            //    Address = new Clients.ContactInfo.Adress("street Name ", 666, "City Name", "cos", "05-500"),
                            //    SenderLocker = new ParcelLocker(),
                            //    ReceiverLocker = new ParcelLocker(),
                            //    SendTime = DateTime.Now,
                            //    ReceiveTime = DateTime.Now.AddDays(30),
                            //    ParcelStatus = ParcelStatus.Registered
                            //};
                            //var packages = packageRepository.GetAll() ;
                            //packages.Add(package);
                            //packageRepository.SaveAll(packages);
                            //Console.WriteLine($"Fake package with ID: {package.ID} and Name: {package.Name} saved!");
                            break;
                        };

                    case ConsoleKey.P: // formularz odbioru paczki
                        {
                            // do uzupełnienia

                            break;
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

        //rozumiem że całość poniżej możemy usunąć:
        /*
		private List<Parcel> CreateFakeData()
        {
                        
            fake data
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
        */
    }
}
