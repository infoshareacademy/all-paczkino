using AllPaczkino.Clients.ContactInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPaczkino.Models
{
    public class Client
    {
        public ContactData ContactData { get; set; }

        public string Password { get; set; }
    }
}