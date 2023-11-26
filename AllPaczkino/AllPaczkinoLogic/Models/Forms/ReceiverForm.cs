

namespace AllPaczkino.Models.Forms
{
    public class ReceiverForm
    {
        public ReceiverForm(string name, string surname, string email, string phoneNumber)
        {
            if (NameValidator.Validate(name, surname, 2, 30))
                throw new Exception();
            if (EmailValidator.Validate(email, 3, 100))
                throw new Exception();
            Name = name;
            Surname = surname;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        private ReceiverForm() { }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}

public static class NameValidator
{
    public static bool Validate(string Name, string SurName, int minLength, int maxLength)
    {
        var isNameValid = Name.Length >= minLength && Name.Length <= maxLength;
        var isSurNameValid = SurName.Length >= minLength && SurName.Length <= maxLength;

        return isNameValid && isSurNameValid;
    }
}

public class EmailValidator
{
    public static bool Validate(string email, int minLength, int maxLength)
    {
        return email.Length >= minLength && email.Length <= maxLength && email.Contains("@") && email.Split('@')[1].Contains(".");
    }
}


internal class PhoneNuberValidator
{
    private static bool IsValidPhoneNumber(string phoneNumber)
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

