

namespace AllPaczkino.Models.Forms
{
    public class PackageApproval
    
    {
        static void Main()
        {
            Console.WriteLine("Czy paczka została nadana? (TAK/NIE)");

            string answer= Console.ReadLine();

            if (answer.ToUpper() == "TAK")
            {
                Console.WriteLine("Paczka została nadana. Kod etykiety i numer nadania wysłane na wskazany adres email.");
            }
            else if (answer.ToUpper() == "NIE")
            {
                Console.WriteLine("Rozpocznij proces nadawania paczki od początku.");
            }
            

            Console.ReadLine(); 
        }
    }

}


class Program
{
    static void Main()
    {
        Console.WriteLine("Wygenerowano kod wysyłki.");
        Console.WriteLine("Potwierdzenie nadania paczki.");

        Console.ReadLine(); 
    }
}
