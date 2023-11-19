

namespace AllPaczkino.Models.Forms
{ }


//class Programm
//{
//    //static void Main()
//    //{
//    //    Console.WriteLine("Wybierz paczkomat nadawcy:");
//    //    Console.WriteLine("1 - Paczkomat A");
//    //    Console.WriteLine("2 - Paczkomat B");

//    //    if (int.TryParse(Console.ReadLine(), out int response))
//    //    {
//    //        SenderLocker senderLocker = GetSenderLocker(response);

//    //        if (senderLocker != null)
//    //        {
//    //            Console.WriteLine("Podaj nazwę paczkomatu nadawcy:");
//    //            senderLocker.Name = Console.ReadLine();

//    //            Console.WriteLine("Podaj kod pocztowy paczkomatu nadawcy:");
//    //            senderLocker.PostalCode = Console.ReadLine();

//    //            Console.WriteLine($"Paczkomat nadawcy: {senderLocker.Name}, Kod pocztowy: {senderLocker.PostalCode}");
//    //        }
//    //        else
//    //        {
//    //            Console.WriteLine("Nieprawidłowy wybór paczkomatu.");
//    //        }
//    //}

//    static SenderLocker GetSenderLocker(int choice)
//    {
//        return choice switch
//        {
//            1 => new SenderLocker("Paczkomat A"),
//            2 => new SenderLocker("Paczkomat B"),
//            _ => null
//        };
//    }
//}

        class SenderLocker
        {
            public string Name { get; set; }
            public string PostalCode { get; set; }

            public SenderLocker(string name)
            {
                Name = name;
                PostalCode = "00-000";
            }
        }
//}

