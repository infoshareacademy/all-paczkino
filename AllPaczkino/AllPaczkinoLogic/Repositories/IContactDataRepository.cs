using AllPaczkino.Clients.ContactInfo;
using Parcels.Parcels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPaczkino.Repositories
{
    internal interface IContactDataRepository
    {
        IEnumerable<ContactData> GetContactDataList();
        void AddContact(string name, string surname, string email, string phoneNumber, Adress adress);

        bool DeleteContact(string email);

        bool EditContact(string email, ContactData updatedContact);
    }
}
