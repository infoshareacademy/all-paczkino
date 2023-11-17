

namespace AllPaczkino.Models.Forms
{
    internal class ReceiverLocker
    {
        static void Main()
        {
            Console.WriteLine("Wybierz paczkomat odbiorcy:");
            Console.WriteLine("1 - Paczkomat A");
            Console.WriteLine("2 - Paczkomat B");

            if (int.TryParse(Console.ReadLine(), out int response))
            {
                ReceiverLocker receiverLocker = GetReceiverLocker(response);

                if (receiverLocker != null)
                {
                    Console.WriteLine("Podaj nazwę paczkomatu odbiorcy:");
                    receiverLocker.Name = Console.ReadLine();

                    Console.WriteLine("Podaj kod pocztowy paczkomatu odbiorcy:");
                    receiverLocker.PostalCode = Console.ReadLine();

                    Console.WriteLine($"Paczkomat odbiorcy: {receiverLocker.Name}, Kod pocztowy: {receiverLocker.PostalCode}");
                }
                else
                {
                    Console.WriteLine("Nieprawidłowy wybór paczkomatu.");
                }
            }

            static ReceiverLocker GetReceiverLocker(int choice)
            {
                return choice switch
                {
                    1 => new ReceiverLocker("Paczkomat A"),
                    2 => new ReceiverLocker("Paczkomat B"),
                    _ => null
                };
            }
        }

        public class ReceiverLocker
        {
            public string Name { get; set; }
            public string PostalCode { get; set; }

            public ReceiverLocker(string name)
            {
                Name = name;
                PostalCode = "00-000";
            }
        }
    }
}
