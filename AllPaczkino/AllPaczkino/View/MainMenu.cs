using AllPaczkino.Models;

namespace AllPaczkino.View
{
    public class MainMenu
    {
        ConsoleKeyInfo key;
        public void ShowUserMenu()
        {
            var parcelsFakeList = CreateFakeData();
            Console.WriteLine("###########################################");
            Console.WriteLine("Press 'A' to create and send new parcel.");
            Console.WriteLine("Press 'S' to get parcel actual status.");
            Console.WriteLine("Press 'Spacebar' to quit.");
            do
            {
                key = Console.ReadKey(intercept: true);
                switch (key.Key)
                {
                    case ConsoleKey.A:
                        {
                            Console.WriteLine(" Wypełnij pola niezbędne do nadania paczki: ");
                            break;
                        };
                    case ConsoleKey.S:
                        {
                            Console.WriteLine(" Podaj nr paczki: ");
                            if (decimal.TryParse(Console.ReadLine(), out decimal parcelNumberId))
                            {
                                var searchedParcelState = parcelsFakeList.Where(p => p.ParcelNumber == parcelNumberId).FirstOrDefault().parcelStatus;
                                Console.WriteLine(
                                   searchedParcelState != null
                                       ? $"For parcel with id {parcelNumberId} actual state is: {searchedParcelState}."
                                       : $"Parcel with id {parcelNumberId} not found, check the number!");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid number.");
                            }
                            break;
                        };
                    case ConsoleKey.Spacebar: break;
                }

            } while (key.Key != ConsoleKey.Spacebar);
        }
        private List<Parcel> CreateFakeData()
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
