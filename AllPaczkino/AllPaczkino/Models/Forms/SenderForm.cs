

namespace AllPaczkino.Models.Forms
{
    internal class SenderForm
    {
        public SenderForm(string name, string surname, string email, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public SenderForm() { }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}

 public class ValidateNameAndSurName
{
    static void SenderForm()
    {
        string Name = "Jan";
        string SurName = "Kowalski";

        if (ValidateName(Name, SurName, 2, 20))
        {
            Console.WriteLine("Imię i nazwisko są poprawne.");
        }
        else
        {
            Console.WriteLine("Imię i nazwisko dodane niepoprawnie.");
        }
    }

    static bool ValidateName(string Name, string SurName, int minLength, int maxLength)
    {
        bool isNameValid = Name.Length >= minLength && Name.Length <= maxLength;
        bool isSurNameValid = SurName.Length >= minLength && SurName.Length <= maxLength;

        return isNameValid && isSurNameValid;
    }
}

class ValidateEmailAdress
{
    static void SenderForm()
    {
        string email = "jan.kowalski@example.com";

        if (IsValidEmail(email))
        {
            Console.WriteLine("Adres email jest prawidłowy");
        }
        else
        {
            Console.WriteLine("Adres email jest nieprawidłowy.");
        }
    }

    static bool IsValidEmail(string email)
    {
        return email.Contains("@") && email.Split('@')[1].Contains(".");
    }
}

class ValidatePhoneNumber
{
    static void SenderForm()
    {
        string phoneNumber = "+48 123-456-789";

        if (IsValidPhoneNumber(phoneNumber))
        {
            Console.WriteLine("Numer telefonu jest prawidłowy.");
        }
        else
        {
            Console.WriteLine("Numer telefonu jest nieprawidłowy.");
        }
    }

    static bool IsValidPhoneNumber(string phoneNumber)
    {
        foreach (char c in phoneNumber)
        {
            if (!Char.IsDigit(c) && c != ' ' && c != '-' && c != '+' && c != '(' && c != ')')
            {
                return false;
            }
        }
        return true;
    }
}
