using AllPaczkino.Clients.ContactInfo;
using AllPaczkino.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPaczkino.Clients
{
    public class Receiver : Client
    {
        public Receiver(ContactData contactData) : base(contactData)
        {
        }

        public Receiver() : base(null)
        {
            
        }
    }
}
