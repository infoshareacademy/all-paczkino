
namespace AllPaczkino.Clients.ContactInfo
{
    public class ContactData
    {
        public ContactData(string name, string surname, string email, string phoneNumber, Adress adress)
        {
            Name = name;
            Surname = surname;
            Email = email;
            PhoneNumber = phoneNumber;
            Adress = adress;
        }

        private ContactData() { }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Adress Adress { get; set; }
    }
}
