using AllPaczkino.Clients.ContactInfo;
using Parcels.Parcels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPaczkino.Repositories
{
    internal class InMemoryContactDataRepository : IContactDataRepository
    {
        List<ContactData> contacts = new List<ContactData>()
            {
                       new ContactData("Zuzia", "Frydrych", "zuzia.frydrych@op.pl", "601888635", new Adress("Katowicka", 87, "Poznan", "Wlkp", "62-131", null, 10)),
            new ("Kuba", "Nowak", "kuba.nowak@op.pl", "897395173", new Adress("Polska", 2, "Poznan", "Wlkp", "60-221", null)),
            new ("Ola", "Wilska", "ola.wilska@op.pl", "607382175", new Adress("Marciniaka", 7, "Poznan", "Wlkp", "60-462", null, 7)),
            };

        public IEnumerable<ContactData> GetContactDataList()
        {
                 

            return contacts;
         
        }

        public void AddContact(string name, string surname, string email, string phoneNumber, Adress adress)
        {
            ContactData contactData = new ContactData(name, surname, email, phoneNumber, adress);

            contacts.Add(contactData);
        }

        public bool DeleteContact(string email)
        {
            var contactData = contacts.FirstOrDefault(x => x.Email == email);

            if (contactData != null)
            {
                contacts.Remove(contactData);
     
                return true;
            }
            else return false;
            
        }

        public bool EditContact(string email, ContactData updateData)
        {

            var contactUpdate = contacts.FirstOrDefault(x => x.Email == email);

            if (contactUpdate != null)
            {
                contactUpdate.Name = updateData.Name;
                contactUpdate.Surname = updateData.Surname;
                contactUpdate.Email = updateData.Email;
                contactUpdate.PhoneNumber = updateData.PhoneNumber;
                contactUpdate.Adress = updateData.Adress;                

                return true;
            }
            else return false;

        }



    }
    
}
