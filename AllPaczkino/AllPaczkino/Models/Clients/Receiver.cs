﻿using AllPaczkino.Clients.ContactInfo;
using AllPaczkino.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPaczkino.Clients
{
    internal class Receiver : Client
    {
        public ContactData ContactData { get; set; }
    }
}
